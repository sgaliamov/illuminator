﻿module FunctionsGenerator

open Scriban
open Shared
open CoreMethods
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
        public static ILEmitterFunc {{ method.name }}({{ method.parameters | array.join "", "" }}) => (in ILEmitter il) => il.{{ method.name }}({{ method.arguments | array.join "", "" }});
        {{~ end ~}}
    }
}"

let generate () =
    let emitMethods =
        FilteredCodes
        |> Seq.map (fun (name, info, code) ->
            let (arguments, parameters) = getFunArgs code

            let parameters =
                info.Args
                |> Seq.map (fun typeName -> $"{typeName} {getArgumentName typeName}")
                |> Seq.append parameters
                |> Seq.toList

            let arguments =
                info.Args
                |> Seq.map getArgumentName
                |> Seq.append arguments
                |> Seq.toList

            {| arguments = arguments
               description = info.Description 
               name = name
               parameters = parameters |})

    let coreMethods =
        CoreMethods
        |> Seq.filter (fun info -> not info.has_output)
        |> Seq.map (fun info ->
        {| arguments = info.arguments
           description = info.description 
           name = info.name
           parameters = info.parameters |})

    let methods =
        emitMethods
        |> Seq.append coreMethods
        |> Seq.toArray

    let scriban = Template.Parse template
    let result = scriban.Render {| methods = methods |}
    result.Trim()
