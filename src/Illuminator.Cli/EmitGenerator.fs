﻿module EmitGenerator

open FSharp.Data
open Scriban
open Shared
open System.Reflection
open System.Reflection.Emit;

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

// codes with not standart behaviour
let manualCodes = Set.ofList [
    OpCodes.Call.Name
    OpCodes.Calli.Name
    OpCodes.Callvirt.Name
    OpCodes.Newobj.Name
    OpCodes.Ret.Name ]

type private OpCodesInfo = JsonProvider<"./opcodes.json">

let generate () =
    // additional information about op codes
    let opCodesInfo =
        OpCodesInfo.GetSamples()
        |> Seq.map (fun info -> info.Name, info)
        |> Map.ofSeq

    let IntType = typeof<int>.FullName

    // stack sizes
    let stackBehaviourMap = Map.ofList [
        // pops
        (StackBehaviour.Pop0, [])
        (StackBehaviour.Pop1, ["any"])
        (StackBehaviour.Pop1_pop1, ["any"; "any"])
        (StackBehaviour.Popi, [IntType])
        (StackBehaviour.Popi_pop1, [IntType; "any"])
        (StackBehaviour.Popi_popi, [IntType; IntType])
        (StackBehaviour.Popi_popi_popi, [IntType; IntType; IntType])
        (StackBehaviour.Popi_popi8, [IntType; "long"])
        (StackBehaviour.Popi_popr4, [IntType; "float"])
        (StackBehaviour.Popi_popr8, [IntType; "double"])
        (StackBehaviour.Popref, ["ref"])
        (StackBehaviour.Popref_pop1, ["ref"; "any"])
        (StackBehaviour.Popref_popi, ["ref"; IntType])
        (StackBehaviour.Popref_popi_pop1, ["ref"; IntType; "any"])
        (StackBehaviour.Popref_popi_popi, ["ref"; IntType; IntType])
        (StackBehaviour.Popref_popi_popi8, ["ref"; IntType; "long"])
        (StackBehaviour.Popref_popi_popr4, ["ref"; IntType; "float"])
        (StackBehaviour.Popref_popi_popr8, ["ref"; IntType; "double"])
        (StackBehaviour.Popref_popi_popref, ["ref"; IntType; "ref"])
        // pushes
        (StackBehaviour.Push0, [])
        (StackBehaviour.Push1, ["any"])
        (StackBehaviour.Push1_push1, ["any"; "any"])
        (StackBehaviour.Pushi, [IntType])
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

        typeof<OpCodes>.GetFields(BindingFlags.Static ||| BindingFlags.Public ||| BindingFlags.GetField)
        |> Seq.map (fun field -> field.Name, field.GetValue null :?> OpCode )
        |> Seq.filter (fun (_, code) -> not (manualCodes.Contains code.Name))
        |> Seq.sortBy (fun (name, _) -> name)
        |> Seq.map (fun (name, code) ->
            let hasInfo, info = opCodesInfo.TryGetValue name
            {| arguments = if hasInfo then info.Args |> Seq.map getArgumentName else Seq.empty
               description = if hasInfo then info.Description else "TBD"
               name = name
               parameters = if hasInfo then info.Args |> Seq.map (fun a -> $"{a} {getArgumentName a}") else Seq.empty
               pop_behaviour = code.StackBehaviourPop.ToString()
               pops = stackBehaviourMap.[code.StackBehaviourPop] |> join
               push_behaviour = code.StackBehaviourPush.ToString()
               pushes = stackBehaviourMap.[code.StackBehaviourPush] |> join |})

    let scriban = Template.Parse template
    let result = scriban.Render {| methods = getNamedMethods() |} // => "Hello World!"
    result.Trim()
