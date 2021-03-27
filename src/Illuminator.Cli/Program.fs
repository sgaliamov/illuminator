[<EntryPoint>]
let main args =
    match args with
    | [| "emit" |]-> printfn "%s" (EmitGenerator.generate())
    | [| "core" |]-> printfn "%s" (CoreGenerator.generate())
    | [| "json" |]-> printfn "%s" (JsonGenerator.generate())
    | [| "label" |]-> printfn "%s" (LabelGenerator.generate())
    | [| "extensions" |]-> printfn "%s" (ExtensionsGenerator.generate())
    | [| "functions" |]-> printfn "%s" (FunctionsGenerator.generate())
    | _ -> ()
    0
