[<EntryPoint>]
let main args =
    match args with
    | [| "emit" |]-> printfn "%s" (EmitGenerator.generate())
    | [| "core" |]-> printfn "%s" (CoreGenerator.generate())
    | [| "json" |]-> printfn "%s" (JsonGenerator.generate())
    | _ -> ()
    0
