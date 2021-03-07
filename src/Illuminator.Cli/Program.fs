[<EntryPoint>]
let main args =
    match args with
    | [| "named" |]-> 
       
        printfn "%s" (NamedGenerator.generate())
    | _ -> ()
    0
