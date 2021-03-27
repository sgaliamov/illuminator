module CoreMethods

open System.Reflection.Emit
open System.Reflection
open Shared

/// Core methods for manula implementation.
let private Exclude = Set.ofList [
    "Emit"
    "EmitCall"
    "EmitCalli"
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
    |> Seq.filter (fun m -> not (Exclude.Contains m.Name))
    |> Seq.filter (fun m -> not m.IsSpecialName)
    |> Seq.sortBy (fun x -> x.Name)
    |> Seq.map toModel
    |> Seq.cache

