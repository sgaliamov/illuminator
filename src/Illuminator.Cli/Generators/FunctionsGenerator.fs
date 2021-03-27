module FunctionsGenerator

open Scriban
open Shared
open OpCodes

let private template = @"
/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator
{
    // Generated functions for op code methods.
    public static partial class Functions
    {
        {{- for method in methods }}
        /// <summary>
        ///     {{ method.description }}
        /// </summary>
        public static ILEmitterFunc {{ method.name }}({{ method.parameters | array.join "", "" }}) => il => il.{{ method.name }}({{ method.arguments | array.join "", "" }});
        {{~ end ~}}
    }
}"

let generate () =
    let getEmitMethods () =
        FilteredCodes
        |> Seq.map (fun (name, code) -> OpCodesInfoGrouped.[name] |> Seq.map (fun info -> name, info, code))
        |> Seq.collect id
        |> Seq.map (fun (name, info, code) ->
            let arguments =
                Seq.init StackBehaviourMap.[code.StackBehaviourPop].Length (fun i -> $"fun{i + 1}")
                |> Seq.cache

            let parameters =
                arguments
                |> Seq.map (fun name -> $"ILEmitterFunc {name}")

            let parameters =
                info.Args
                |> Seq.map (fun typeName -> $"{typeName} {getArgumentName typeName}")
                |> Seq.append parameters

            let arguments =
                info.Args
                |> Seq.map getArgumentName
                |> Seq.append arguments

            {| arguments = arguments
               description = info.Description 
               name = name
               parameters = parameters |})
        |> Seq.toArray

    let scriban = Template.Parse template
    let result = scriban.Render {| methods = getEmitMethods() |}
    result.Trim()
