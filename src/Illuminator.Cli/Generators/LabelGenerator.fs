module LabelGenerator

open Scriban
open Shared

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
        {{~ end ~}}
    }
}"

let generate () =
    let methods =
        OpCodesInfo
        |> Seq.filter (fun x -> x.Args = [| "Label" |])
        |> Seq.sortBy (fun x -> x.Name)
        |> Seq.map (fun x -> {| name = x.Name; description = x.Description |})
    
    let scriban = Template.Parse template
    let result = scriban.Render {| methods = methods |}
    result.Trim()