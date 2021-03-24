[<EntryPoint>]
let main args =
    match args with
    | [| "emit" |]-> printfn "%s" (EmitGenerator.generate())
    | [| "core" |]-> printfn "%s" (CoreGenerator.generate())
    | [| "json" |]-> printfn "%s" (JsonGenerator.generate())
    | [| "label" |]-> printfn "%s" (LabelGenerator.generate())
    | [| "fun-ex" |]-> printfn "%s" (FunExGenerator.generate())
    | [| "functions" |]-> printfn "%s" (FunctionsGenerator.generate())
    | _ -> ()
    0
