module CoreGenerator

let exclude = ["GetType"; "ToString"; "Equals"; "GetHashCode"; "Emit"]










//let methods =
//    typeof<ILGenerator>.GetMethods()
//        |> Seq.filter (fun m -> not (exclude.Contains m.Name))
//        |> Seq.filter (fun m -> not m.IsSpecialName)
//        |> Seq.map (fun m -> 
//    {|
//            name = m.Name
//            returnType = m.ReturnType
//            arguments =
//                m.GetParameters()
//                |> Array.map (fun p -> p.Name)
//            parameters =
//                m.GetParameters()
//                |> Array.map (fun p -> $"{p.ParameterType.Name} {p.Name}")
//    |})
//        |> Array.ofSeq