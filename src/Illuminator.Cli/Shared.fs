﻿module Shared

open System
open System.Reflection.Emit
open System.Reflection
open FSharp.Data

// makes the first letter lower
let lowerFirst text =
    let text = text |> Seq.toList
    match text with
    | head :: tail -> Char.ToLowerInvariant head :: tail |> Seq.toArray |> String
    | _ -> String.Empty

// safe naming for parameters
let private excapedName = Set.ofList [
    "long"
    "short"
    nameof byte
    nameof double
    nameof float
    nameof int
    nameof sbyte
    nameof string ]

let getArgumentName (name: string) =
    if excapedName.Contains(name.ToLowerInvariant())
    then "value"
    else lowerFirst (name.Replace("[]", ""))

// join strings with separator
let join separator (values: seq<string>) = String.Join(separator, values)

// codes with not standart behaviour
let private manualCodes = Set.ofList [
    OpCodes.Call.Name
    OpCodes.Calli.Name
    OpCodes.Callvirt.Name
    OpCodes.Newobj.Name
    OpCodes.Ret.Name ]

// all op codes
let AllCodes =
    typeof<OpCodes>.GetFields(BindingFlags.Static ||| BindingFlags.Public ||| BindingFlags.GetField)
    |> Seq.map (fun field -> field.Name, field.GetValue null :?> OpCode )
    |> Seq.filter (fun (_, code) -> not (manualCodes.Contains code.Name))
    |> Seq.sortBy (fun (name, _) -> name)
    |> Seq.cache

// Codes info
type private OpCodesInfo = JsonProvider<"./opcodes.json">

let OpCodesInfo = OpCodesInfo.GetSamples()