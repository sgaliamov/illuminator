module OpCodes

open System.Reflection.Emit
open System.Reflection
open FSharp.Data

/// All op codes
let private AllCodes =
    typeof<OpCodes>.GetFields(BindingFlags.Static ||| BindingFlags.Public ||| BindingFlags.GetField)
    |> Seq.map (fun field -> field.Name, field.GetValue null :?> OpCode )
    |> Seq.cache

/// Codes with not standart behaviour
let private ManualCodes = Set.ofList [
    OpCodes.Call.Name
    OpCodes.Calli.Name
    OpCodes.Callvirt.Name
    OpCodes.Newobj.Name
    OpCodes.Ret.Name ]

/// Codes info
type private OpCodesInfo = JsonProvider<"./opcodes.json">

let OpCodesInfo = OpCodesInfo.GetSamples()

/// Codes info grouped by name
let OpCodesInfoGrouped =
    OpCodesInfo
    |> Seq.groupBy (fun info -> info.Name)
    |> Seq.map (fun (key, group) -> (key, Array.ofSeq group))
    |> Map.ofSeq

/// Filtered codes
let FilteredCodes =
    AllCodes
    |> Seq.filter (fun (_, code) -> not (ManualCodes.Contains code.Name))
    |> Seq.sortBy (fun (name, _) -> name)
    |> Seq.map (fun (name, code) -> OpCodesInfoGrouped.[name] |> Seq.map (fun info -> name, info, code))
    |> Seq.collect id
    |> Seq.cache

/// Stack sizes
let StackBehaviourMap = Map.ofList [
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
    (StackBehaviour.Push0, [])
    (StackBehaviour.Push1, ["any"])
    (StackBehaviour.Push1_push1, ["any"; "any"])
    (StackBehaviour.Pushi, ["int"])
    (StackBehaviour.Pushi8, ["long"])
    (StackBehaviour.Pushr4, ["float"])
    (StackBehaviour.Pushr8, ["double"])
    (StackBehaviour.Pushref, ["ref"])
    (StackBehaviour.Varpop, [])
    (StackBehaviour.Varpush, []) ]
