module CoreGenerator

open System.Linq
open System.Reflection.Emit;
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

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        {{- for method in methods }}
        /// <summary>
        ///     <para>{{ method.description }}</para>
        /// </summary>
        public ILEmitter {{ method.name }}({{ method.parameters | array.join "", "" }})
        {
            _il.{{ method.name }}({{ method.arguments | array.join "", "" }});

            return this;
        }
        {{~ end ~}}
    }
}"

let exclude = Set.ofList [
    "Emit"
    "EmitCall"
    "EmitCalli"
    "Equals"
    "GetHashCode"
    "GetType"
    "MarkSequencePoint"
    "ToString" ]

let generate () =
    let methods =
        typeof<ILGenerator>.GetMethods()
            |> Seq.filter (fun m -> not (exclude.Contains m.Name))
            |> Seq.filter (fun m -> not m.IsSpecialName)
            |> Seq.map (fun m ->
            {|
                name = m.Name
                description = $"Wrapper over {m.Name}."
                returnType = m.ReturnType
                arguments =
                    m.GetParameters()
                    |> Array.map (fun p -> getParamName p.Name)
                parameters =
                    m.GetParameters()
                    |> Array.map (fun p ->
                        $"{p.ParameterType.Name} {getParamName p.Name}")
            |})
            |> Array.ofSeq
    let scriban = Template.Parse template
    let result = scriban.Render {| methods = methods |} // => "Hello World!"
    result.Trim()