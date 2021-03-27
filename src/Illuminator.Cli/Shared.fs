module Shared

open System

/// Makes the first letter lower.
let lowerFirst text =
    let text = text |> Seq.toList
    match text with
    | head :: tail -> Char.ToLowerInvariant head :: tail |> Seq.toArray |> String
    | _ -> String.Empty

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
