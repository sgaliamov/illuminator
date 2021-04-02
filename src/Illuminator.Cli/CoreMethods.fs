module CoreMethods

open System.Reflection.Emit
open System.Reflection
open Shared

/// Call methods for manual implementation.
let CallMethods = [
    "Emit"
    "EmitCall"
    "EmitCalli" ]

/// Core methods for manual implementation.
let private Exclude = 
    CallMethods @ [
        "Equals"
        "GetHashCode"
        "GetType"
        "MarkSequencePoint"
        "ToString" ]

let toModel (m: MethodInfo) =
    let parameters =
        m.GetParameters()
        |> Seq.map (fun p -> $"{p.ParameterType.Name} {getArgumentName p.Name}")
        |> Seq.toList
    
    let hasOutput = m.ReturnType <> typeof<System.Void>
    
    let parameters =
        match hasOutput with
        | false -> parameters
        | _ -> parameters @ [$"out {m.ReturnType.Name} output"]
    
    let parameterTypes =
        m.GetParameters()
        |> Seq.map (fun p -> p.ParameterType.Name)
        |> join ", "
    
    {| name = m.Name
       has_output = hasOutput
       description = $"Wrapper over <see cref=\"ILGenerator.{m.Name}({parameterTypes})\"/>."
       arguments = m.GetParameters() |> Seq.map (fun p -> getArgumentName p.Name) |> Seq.toList
       parameters = parameters |}

/// Core methods
let CoreMethods =
    typeof<ILGenerator>.GetMethods()
    |> Seq.filter (fun m -> List.contains m.Name Exclude |> not)
    |> Seq.filter (fun m -> not m.IsSpecialName)
    |> Seq.sortBy (fun x -> x.Name)
    |> Seq.map toModel
    |> Seq.cache

