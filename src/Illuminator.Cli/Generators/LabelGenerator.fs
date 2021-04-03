module LabelGenerator

open Scriban
open OpCodes

let private template = @"
/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System.Reflection.Emit;

namespace Illuminator.Extensions
{
    public static class LabelMethodsExtensions
    {
        {{- for method in methods }}
        /// <summary>
        ///     {{ method.description }}
        /// </summary>
        public static ILEmitter {{ method.name }}(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .{{ method.name }}(label);
        {{~ if method.fun_args.size != 0 }}
        /// <summary>
        ///     {{ method.description }}
        /// </summary>
        public static ILEmitter {{ method.name }}({{ method.parameters | array.insert_at 0 ""this ILEmitter self"" | array.join "", "" }}, out Label label)
        {
            {{~ for item in method.fun_args ~}}
            {{ item }}(self);
            {{~ end }}
            return self.DefineLabel(out label)
                       .{{ method.name }}(label);
        }
        {{~ end ~}}
        {{~ end ~}}
    }
}"

let generate () =
    let methods =
        FilteredCodes
        |> Seq.filter (fun (_, info, _) -> info.Args = [| "Label" |])
        |> Seq.map (fun (name, info, code) ->
            let (args, parameters) = getFunArgs code

            {| 
                name = name
                fun_args = args
                parameters = parameters
                description = info.Description
            |})
    
    let scriban = Template.Parse template
    let result = scriban.Render {| methods = methods |}
    result.Trim()