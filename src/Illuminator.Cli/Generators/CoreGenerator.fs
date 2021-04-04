module CoreGenerator

open Scriban
open CoreMethods

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
    // Generated wrappers over ILGenerator.
    public sealed partial class ILEmitter
    {
        {{- for method in methods }}
        /// <summary>
        ///     {{ method.description }}
        /// </summary>
        public ILEmitter {{ method.name }}({{ method.parameters | array.join "", "" }})
        {
            {{ if method.has_output -}}
            output =
            {{- end -}}
            _il.{{ method.name }}({{ method.arguments | array.join "", "" }});
            {{- message = 'nameof(' + method.name + ')' }}
            _logger?.Log({{ method.arguments | array.insert_at 0 message | array.join "", "" }});

            return this;
        }
        {{~ end ~}}
    }
}"

let generate () =
    let scriban = Template.Parse template
    let methods =
        CoreMethods 
        |> Seq.map (fun m ->
            let parameters =
                m.parameters 
                |> Seq.map (fun p -> if p.StartsWith "out" then p else $"in {p}")
                |> Seq.toList

            {| m with parameters = parameters |})
        |> Seq.toList

    let result = scriban.Render {| methods = methods |}
    result.Trim()