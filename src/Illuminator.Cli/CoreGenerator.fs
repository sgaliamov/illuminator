module CoreGenerator

open Scriban
open Shared
open System.Reflection.Emit;
open System.Reflection

let private template = @"
/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        {{- for method in methods }}
        /// <summary>
        ///     {{ method.description }}
        /// </summary>
        public ILEmitter {{ method.name }}({{ method.parameters | array.join "", "" }})
        {
            {{ if method.has_output -}}
            output =
            {{- end -}}
            _il.{{ method.name }}({{ method.arguments | array.join "", "" }});

            return this;
        }
        {{~ end ~}}
    }
}"

let exclude = Set.ofList [
    "Emit"
    "EmitCall"
    "EmitCalli"
    "Equals"
    "GetHashCode"
    "GetType"
    "MarkSequencePoint"
    "ToString" ]

let generate () =
    let toModel (m: MethodInfo) =
        let parameters =
            m.GetParameters()
            |> Seq.map (fun p -> $"{p.ParameterType.Name} {getArgumentName p.Name}")
            |> List.ofSeq

        let hasOutput = m.ReturnType <> typeof<System.Void>

        let parameters =
            match hasOutput with
            | false -> parameters
            | _ -> parameters @ [$"out {m.ReturnType.Name} output"]

        let parameterTypes =
            m.GetParameters()
            |> Seq.map (fun p -> p.ParameterType.Name)
            |> join ", "

        {| name = m.Name
           has_output = hasOutput
           description = $"Wrapper over <see cref=\"ILGenerator.{m.Name}({parameterTypes})\"/>."
           arguments = m.GetParameters() |> Array.map (fun p -> getArgumentName p.Name)
           parameters = parameters |}

    let methods =
        typeof<ILGenerator>.GetMethods()
        |> Seq.filter (fun m -> not (exclude.Contains m.Name))
        |> Seq.filter (fun m -> not m.IsSpecialName)
        |> Seq.sortBy (fun x -> x.Name)
        |> Seq.map toModel

    let scriban = Template.Parse template
    let result = scriban.Render {| methods = methods |}
    result.Trim()