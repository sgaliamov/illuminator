module Shared

open System

// makes the first letter lower
let lowerFirst text =
    let text = text |> Seq.toList
    match text with
    | head :: tail -> Char.ToLowerInvariant head :: tail |> Seq.toArray |> String
    | _ -> String.Empty

// safe naming for parameters
let private excapedName = Set.ofList [
    nameof byte
    nameof string ]

let getArgumentName (name: string) =
    if excapedName.Contains(name.ToLowerInvariant())
    then "value"
    else lowerFirst name

// join strings with separator
let join (separator: string) (values: seq<string>) = String.Join(separator, values)
