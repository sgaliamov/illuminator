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
let ManualCodes = [
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
    |> Seq.filter (fun (_, code) -> List.contains code.Name ManualCodes |> not)
    |> Seq.sortBy (fun (name, _) -> name)
    |> Seq.map (fun (name, code) -> OpCodesInfoGrouped.[name] |> Seq.map (fun info -> name, info, code))
    |> Seq.collect id
    |> Seq.cache

[<Literal>]
let AnyType = "AnyType"

[<Literal>]
let IntType = "IntType"

[<Literal>]
let LongType = "LongType"

[<Literal>]
let FloatType = "FloatType"

[<Literal>]
let DoubleType = "DoubleType"

[<Literal>]
let RefType = "RefType"

/// Stack sizes
let StackBehaviourMap = Map.ofList [
    (StackBehaviour.Pop0, [])
    (StackBehaviour.Pop1, [AnyType])
    (StackBehaviour.Pop1_pop1, [AnyType; AnyType])
    (StackBehaviour.Popi, [IntType])
    (StackBehaviour.Popi_pop1, [IntType; AnyType])
    (StackBehaviour.Popi_popi, [IntType; IntType])
    (StackBehaviour.Popi_popi_popi, [IntType; IntType; IntType])
    (StackBehaviour.Popi_popi8, [IntType; LongType])
    (StackBehaviour.Popi_popr4, [IntType; FloatType])
    (StackBehaviour.Popi_popr8, [IntType; DoubleType])
    (StackBehaviour.Popref, [RefType])
    (StackBehaviour.Popref_pop1, [RefType; AnyType])
    (StackBehaviour.Popref_popi, [RefType; IntType])
    (StackBehaviour.Popref_popi_pop1, [RefType; IntType; AnyType])
    (StackBehaviour.Popref_popi_popi, [RefType; IntType; IntType])
    (StackBehaviour.Popref_popi_popi8, [RefType; IntType; LongType])
    (StackBehaviour.Popref_popi_popr4, [RefType; IntType; FloatType])
    (StackBehaviour.Popref_popi_popr8, [RefType; IntType; DoubleType])
    (StackBehaviour.Popref_popi_popref, [RefType; IntType; RefType])
    (StackBehaviour.Push0, [])
    (StackBehaviour.Push1, [AnyType])
    (StackBehaviour.Push1_push1, [AnyType; AnyType])
    (StackBehaviour.Pushi, [IntType])
    (StackBehaviour.Pushi8, [LongType])
    (StackBehaviour.Pushr4, [FloatType])
    (StackBehaviour.Pushr8, [DoubleType])
    (StackBehaviour.Pushref, [RefType])
    (StackBehaviour.Varpop, [])
    (StackBehaviour.Varpush, []) ]

/// Pair of functional parameters and arguments.
let getFunArgs (code: OpCode) =
    let arguments =
        Seq.init StackBehaviourMap.[code.StackBehaviourPop].Length (fun i -> $"func{i + 1}")
        |> Seq.toArray // must be array to make `method.fun_args.size != 0` work
    
    let parameters =
        arguments
        |> Seq.map (fun name -> $"ILEmitterFunc {name}")
        |> Seq.toArray
    
    (arguments, parameters)