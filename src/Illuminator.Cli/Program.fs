open System.Linq
open System.Reflection.Emit
open Scriban

[<EntryPoint>]
let main argv =
    let template = @"
/*
    ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
    / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
    | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
    \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System;
using System.Diagnostics.SymbolStore;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        private readonly ILGenerator _il;

        public ILEmitter(ILGenerator il)
        {
            _il = il;
        }
        {{ for method in methods }}
        public ILEmitter {{ method.name }}({{ method.parameters | array.join "", "" }})
        {
            _il.{{ method.name }}({{ method.arguments | array.join "", "" }});
            return this;
        }
        {{ end }}
    }
}"

    let exclude = ["GetType"; "ToString"; "Equals"; "GetHashCode"]

    let methods = 
        typeof<ILGenerator>.GetMethods()
            |> Seq.filter (fun m -> not (exclude.Contains m.Name))
            |> Seq.filter (fun m -> not m.IsSpecialName)
            |> Seq.map (fun m -> 
            {|
                name = m.Name
                returnType = m.ReturnType
                arguments =
                    m.GetParameters()
                    |> Array.map (fun p -> p.Name)
                parameters =
                    m.GetParameters()
                    |> Array.map (fun p -> $"{p.ParameterType.Name} {p.Name}")
            |})
            |> Array.ofSeq
    let scriban = Template.Parse template
    let result = scriban.Render {| methods = methods |} // => "Hello World!"

    printfn "%s" (result.Trim())
    0
