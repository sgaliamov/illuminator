[<EntryPoint>]
let main args =
    match args with
    | [| "fun" |]-> printfn "%s" (FunGenerator.generate())
    | [| "emit" |]-> printfn "%s" (EmitGenerator.generate())
    | [| "core" |]-> printfn "%s" (CoreGenerator.generate())
    | [| "json" |]-> printfn "%s" (JsonGenerator.generate())
    | [| "label" |]-> printfn "%s" (LabelGenerator.generate())
    | _ -> ()
    0
