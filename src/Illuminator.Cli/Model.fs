module Model

open System
open System.Reflection.Emit;
open FSharp.Data
open System.Reflection

// additional information about op codes.
type OpCodesInfo = JsonProvider<"./opcodes.json">
let opCodesInfo =
    OpCodesInfo.GetSamples()
    |> Seq.map (fun info -> info.Name, info)
    |> Map.ofSeq

// makes the first letter lower.
let lowerFirst text =
    let text = text |> Seq.toList
    match text with
    | head :: tail -> Char.ToLowerInvariant head :: tail |> Seq.toArray |> String
    | _ -> String.Empty

// makes the first letter upper.
let upperFirst text =
    let text = text |> Seq.toList
    match text with
    | head :: tail -> Char.ToUpperInvariant head :: tail |> Seq.toArray |> String
    | _ -> String.Empty

// convets il code to name.
let codeToName (code: string) =
    code.Split('.', StringSplitOptions.RemoveEmptyEntries)
    |> Seq.map upperFirst
    |> (fun parts -> String.Join("", parts))

// provides metainformation about codes.
let getMethods () =
    typeof<OpCodes>.GetFields(BindingFlags.Static ||| BindingFlags.Public ||| BindingFlags.GetField)
    |> Seq.map (fun field -> field.Name, field.GetValue null :?> OpCode )
    |> Seq.sortBy (fun (name, _) -> name)
    |> Seq.map (fun (name, code) ->
        let hasInfo, info = opCodesInfo.TryGetValue name
        {|
            name = name
            description = if hasInfo then info.Description else "TBD"
            arguments = if hasInfo then info.Args |> Seq.map lowerFirst else Seq.empty
            parameters = if hasInfo then info.Args |> Seq.map (fun a -> $"{a} {lowerFirst a}") else Seq.empty
        |}
    )