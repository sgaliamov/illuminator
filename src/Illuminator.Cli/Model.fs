module Model

open System
open System.Reflection
open System.Reflection.Emit;
open FSharp.Data

type OpCodesInfo = JsonProvider<"./opcodes.json">

// provides metainformation about codes
let getMethods () =
    // additional information about op codes
    let opCodesInfo =
        OpCodesInfo.GetSamples()
        |> Seq.map (fun info -> info.Name, info)
        |> Map.ofSeq

    // makes the first letter lower
    let lowerFirst text =
        let text = text |> Seq.toList
        match text with
        | head :: tail -> Char.ToLowerInvariant head :: tail |> Seq.toArray |> String
        | _ -> String.Empty

    // stack sizes
    let stackBehaviourMap = Map.ofList [
        // pops
        (StackBehaviour.Pop0, 0)
        (StackBehaviour.Pop1, 1)
        (StackBehaviour.Pop1_pop1, 2)
        (StackBehaviour.Popi, 1)
        (StackBehaviour.Popi_pop1, 2)
        (StackBehaviour.Popi_popi, 2)
        (StackBehaviour.Popi_popi8, 2)
        (StackBehaviour.Popi_popi_popi, 3)
        (StackBehaviour.Popi_popr4, 2)
        (StackBehaviour.Popi_popr8, 2)
        (StackBehaviour.Popref, 1)
        (StackBehaviour.Popref_pop1, 2)
        (StackBehaviour.Popref_popi, 2)
        (StackBehaviour.Popref_popi_pop1, 3)
        (StackBehaviour.Popref_popi_popi, 3)
        (StackBehaviour.Popref_popi_popi8, 3)
        (StackBehaviour.Popref_popi_popr4, 3)
        (StackBehaviour.Popref_popi_popr8, 3)
        (StackBehaviour.Popref_popi_popref, 3)
        // pushes
        (StackBehaviour.Push0, 0)
        (StackBehaviour.Push1, 1)
        (StackBehaviour.Push1_push1, 2)
        (StackBehaviour.Pushi, 1)
        (StackBehaviour.Pushi8, 1)
        (StackBehaviour.Pushr4, 1)
        (StackBehaviour.Pushr8, 1)
        (StackBehaviour.Pushref, 1) ]
    
    // codes with not standart behaviour
    let manualCodes = Set.ofList [
        OpCodes.Call.Name 
        OpCodes.Calli.Name
        OpCodes.Callvirt.Name 
        OpCodes.Newobj.Name 
        OpCodes.Ret.Name ]
    // safe naming for parameters
    let excapedName = Set.ofList [nameof Byte]
    let getParamName name =
        if excapedName.Contains name
        then $"@{lowerFirst name}"
        else lowerFirst name

    // result
    typeof<OpCodes>.GetFields(BindingFlags.Static ||| BindingFlags.Public ||| BindingFlags.GetField)
    |> Seq.map (fun field -> field.Name, field.GetValue null :?> OpCode )
    |> Seq.filter (fun (_, code) -> not (manualCodes.Contains code.Name))
    |> Seq.sortBy (fun (name, _) -> name)
    |> Seq.map (fun (name, code) ->
        let hasInfo, info = opCodesInfo.TryGetValue name
        {|
            name = name
            description = if hasInfo then info.Description else "TBD"
            arguments = if hasInfo then info.Args |> Seq.map getParamName else Seq.empty
            parameters = if hasInfo then info.Args |> Seq.map (fun a -> $"{a} {getParamName a}") else Seq.empty
            pops = stackBehaviourMap.[code.StackBehaviourPop]
            pushes = stackBehaviourMap.[code.StackBehaviourPush]
            pop_behaviour = code.StackBehaviourPop.ToString()
            push_behaviour = code.StackBehaviourPush.ToString()
        |}
    )
