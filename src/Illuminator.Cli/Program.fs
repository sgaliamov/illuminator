open System
open FSharp.Data
open Scriban

let template = @"
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
    public sealed partial class ILEmitter
    {
        {{- for method in methods }}
        /// <summary>
        ///     {{ method.description }}
        /// </summary>
        public ILEmitter {{ method.name }}({{ method.parameters | array.join "", "" }})
        {
            _il.Emit(OpCode.{{ method.arguments | array.insert_at 0 method.name | array.join "", "" }});
            return this;
        }
        {{~ end ~}}
    }
}"

type OpCodesInfo = JsonProvider<"./opcodes.json">
let opCodesInfo = OpCodesInfo.GetSamples()

let lowerFirst text =
    let text = text |> Seq.toList
    match text with
    | head :: tail -> Char.ToLower(head) :: tail |> Seq.toArray |> String
    | _ -> String.Empty

[<EntryPoint>]
let main argv =
    let methods =
        opCodesInfo
        |> Seq.map (fun o -> 
        {|
            name = o.Name
            description = if String.IsNullOrWhiteSpace(o.Description) then o.Name else o.Description
            arguments = o.Args |> Seq.map lowerFirst
            parameters = o.Args |> Seq.map (fun a -> $"{a} {lowerFirst a}")
        |})
    
    let scriban = Template.Parse template
    let result = scriban.Render {| methods = methods |} // => "Hello World!"

    printfn "%s" (result.Trim())
    0
