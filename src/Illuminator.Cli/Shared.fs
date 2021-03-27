module Shared

open System
open System.Reflection.Emit

/// Makes the first letter lower.
let lowerFirst text =
    let text = text |> Seq.toList
    match text with
    | head :: tail -> Char.ToLowerInvariant head :: tail |> Seq.toArray |> String
    | _ -> String.Empty

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

/// Core methods
let CoreMethods =
    typeof<ILGenerator>.GetMethods()
    |> Seq.filter (fun m -> not (Exclude.Contains m.Name))
    |> Seq.filter (fun m -> not m.IsSpecialName)
    |> Seq.sortBy (fun x -> x.Name)
    |> Seq.cache

/// safe naming for parameters
let private ExcapedName = Set.ofList [
    "long"
    "short"
    nameof byte
    nameof double
    nameof float
    nameof int
    nameof sbyte
    nameof string ]

/// Creates argument name
let getArgumentName (name: string) =
    if ExcapedName.Contains(name.ToLowerInvariant())
    then "value"
    else lowerFirst (name.Replace("[]", ""))

/// join strings with separator
let join separator (values: seq<string>) = String.Join(separator, values)
