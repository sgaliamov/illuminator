module ExtensionsGenerator

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
    public static partial class ILEmitterExtensions
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
        FilteredCodes
        |> Seq.map (fun (name, info, code) ->
            let (funArgs, parameters) = getFunArgs code
            let parameters = parameters |> Seq.map (fun p -> $"in {p}")

            let parameters =
                info.Args
                |> Seq.map (fun typeName -> $"in {typeName} {getArgumentName typeName}")
                |> Seq.append parameters

            {| arguments = info.Args |> Seq.map getArgumentName
               description = info.Description 
               name = name
               parameters = parameters
               fun_args = funArgs |})

    let scriban = Template.Parse template
    let result = scriban.Render {| methods = getNamedMethods() |}
    result.Trim()
