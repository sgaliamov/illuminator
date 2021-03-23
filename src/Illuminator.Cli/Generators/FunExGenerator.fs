module FunExGenerator

open Scriban
open Shared

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

namespace Illuminator.Functional
{
    public static class FunExtensions
    {
        {{- 
        for method in methods 
            if method.fun_args.size != 0 }}
        /// <summary>
        ///     {{ method.description }}
        /// </summary>
        public static ILEmitter {{ method.name }}({{ method.parameters | array.insert_at 0 ""this ILEmitter self"" | array.join "", "" }})
        {
            {{~ for item in method.fun_args ~}}
            {{ item }}(self);
            {{~ end }}
            return self.{{ method.name }}({{ method.arguments | array.join "", "" }});
        }
        {{~ end
        end ~}}
    }
}"

let generate () =
    // provides metainformation about codes
    let getNamedMethods () =
        AllCodes
        |> Seq.map (fun (name, code) -> OpCodesInfoGrouped.[name] |> Seq.map (fun info -> name, info, code))
        |> Seq.collect id
        |> Seq.map (fun (name, info, code) ->
            let funArgs = 
                Seq.init StackBehaviourMap.[code.StackBehaviourPop].Length (fun i -> $"fun{i}")
                |> Seq.toArray // must be array to make `method.fun_args.size != 0` work

            let parameters =
                funArgs
                |> Seq.map (fun name -> $"ILEmitterFunc {name}")

            let parameters =
                info.Args
                |> Seq.map (fun typeName -> $"{typeName} {getArgumentName typeName}")
                |> Seq.append parameters

            {| arguments = info.Args |> Seq.map getArgumentName
               description = info.Description 
               name = name
               parameters = parameters
               fun_args = funArgs |})

    let scriban = Template.Parse template
    let result = scriban.Render {| methods = getNamedMethods() |}
    result.Trim()
