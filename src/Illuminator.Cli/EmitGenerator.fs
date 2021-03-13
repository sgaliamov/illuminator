module EmitGenerator

open FSharp.Data
open Scriban
open Shared
open System.Reflection
open System.Reflection.Emit;
open System.IO

let private template = @"
/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System;
using System.Reflection.Emit;

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        {{- for method in methods }}
        /// <summary>
        ///     <para>{{ method.description }}</para>
        ///     <para>StackBehaviourPop: {{ method.pop_behaviour }}.</para>
        ///     <para>StackBehaviourPush: {{ method.push_behaviour }}.</para>
        /// </summary>
        public ILEmitter {{ method.name }}({{ method.parameters | array.join "", "" }})
        {
            _il.Emit(OpCodes.{{ method.arguments | array.insert_at 0 method.name | array.join "", "" }});
            {{~ if method.pops | !string.empty ~}}
            Pop({{ method.pops }});
            {{~ end ~}}
            {{~ if method.pushes | !string.empty ~}}
            Push({{ method.pushes }});
            {{~ end ~}}

            return this;
        }
        {{~ end ~}}
    }
}"

type private OpCodesInfo = JsonProvider<"./opcodes.json">

let generate () =
    // additional information about op codes
    let opCodesInfo =
        OpCodesInfo.GetSamples()
        |> Seq.map (fun info -> info.Name, info)
        |> Map.ofSeq

    // stack sizes
    let stackBehaviourMap = Map.ofList [
        // pops
        (StackBehaviour.Pop0, [])
        (StackBehaviour.Pop1, ["any"])
        (StackBehaviour.Pop1_pop1, ["any"; "any"])
        (StackBehaviour.Popi, ["int"])
        (StackBehaviour.Popi_pop1, ["int"; "any"])
        (StackBehaviour.Popi_popi, ["int"; "int"])
        (StackBehaviour.Popi_popi_popi, ["int"; "int"; "int"])
        (StackBehaviour.Popi_popi8, ["int"; "long"])
        (StackBehaviour.Popi_popr4, ["int"; "float"])
        (StackBehaviour.Popi_popr8, ["int"; "double"])
        (StackBehaviour.Popref, ["ref"])
        (StackBehaviour.Popref_pop1, ["ref"; "any"])
        (StackBehaviour.Popref_popi, ["ref"; "int"])
        (StackBehaviour.Popref_popi_pop1, ["ref"; "int"; "any"])
        (StackBehaviour.Popref_popi_popi, ["ref"; "int"; "int"])
        (StackBehaviour.Popref_popi_popi8, ["ref"; "int"; "long"])
        (StackBehaviour.Popref_popi_popr4, ["ref"; "int"; "float"])
        (StackBehaviour.Popref_popi_popr8, ["ref"; "int"; "double"])
        (StackBehaviour.Popref_popi_popref, ["ref"; "int"; "ref"])
        // pushes
        (StackBehaviour.Push0, [])
        (StackBehaviour.Push1, ["any"])
        (StackBehaviour.Push1_push1, ["any"; "any"])
        (StackBehaviour.Pushi, ["int"])
        (StackBehaviour.Pushi8, ["long"])
        (StackBehaviour.Pushr4, ["float"])
        (StackBehaviour.Pushr8, ["double"])
        (StackBehaviour.Pushref, ["ref"]) ]

    // provides metainformation about codes
    let getNamedMethods () =
        let join (values: seq<string>) =
            values
            |> Seq.map (fun x -> $"\"{x}\"")
            |> join ", "

        allCodes
        |> Seq.map (fun (name, code) ->
            let info = opCodesInfo.[name]

            {| arguments = info.Args |> Seq.map getArgumentName
               description = info.Description 
               name = name
               parameters = info.Args |> Seq.map (fun a -> $"{a} {getArgumentName a}")
               pop_behaviour = code.StackBehaviourPop.ToString()
               pops = stackBehaviourMap.[code.StackBehaviourPop] |> join
               push_behaviour = code.StackBehaviourPush.ToString()
               pushes = stackBehaviourMap.[code.StackBehaviourPush] |> join |})

    let scriban = Template.Parse template
    let result = scriban.Render {| methods = getNamedMethods() |} // => "Hello World!"
    result.Trim()
