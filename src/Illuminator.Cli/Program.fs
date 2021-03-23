[<EntryPoint>]
let main args =
    match args with
    | [| "emit" |]-> printfn "%s" (EmitGenerator.generate())
    | [| "core" |]-> printfn "%s" (CoreGenerator.generate())
    | [| "json" |]-> printfn "%s" (JsonGenerator.generate())
    | [| "label" |]-> printfn "%s" (LabelGenerator.generate())
    | [| "fun" |]-> printfn "%s" (FunGenerator.generate())
    | _ -> ()
    0
