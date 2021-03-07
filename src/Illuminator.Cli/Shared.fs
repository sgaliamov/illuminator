module Shared

open System

// makes the first letter lower
let lowerFirst text =
    let text = text |> Seq.toList
    match text with
    | head :: tail -> Char.ToLowerInvariant head :: tail |> Seq.toArray |> String
    | _ -> String.Empty

// safe naming for parameters
let private excapedName = Set.ofList [nameof Byte]
let getArgumentName name =
    if excapedName.Contains name
    then $"@{lowerFirst name}"
    else lowerFirst name