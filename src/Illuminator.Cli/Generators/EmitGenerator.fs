module EmitGenerator

open System.Reflection.Emit
open Scriban
open Shared
open OpCodes

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
        ///     <para>{{ method.description }}</para>
        ///     <para>{{ method.pop_behaviour }}, {{ method.push_behaviour }}.</para>
        /// </summary>
        public ILEmitter {{ method.name }}({{ method.parameters | array.join "", "" }})
        {
            {{~ if method.pops | !string.empty ~}}
            Pop({{ method.pops }});
            {{~ end ~}}
            {{~ if method.validate_jump ~}}
            ValidateJump(label);
            {{~ end ~}}
            _il.Emit(OpCodes.{{ method.arguments | array.insert_at 0 method.name | array.join "", "" }});
            {{~ if method.pushes | !string.empty ~}}
            Push({{ method.pushes }});
            {{~ end ~}}

            return this;
        }
        {{~ end ~}}
    }
}"

let generate () =
    // provides metainformation about codes
    let getNamedMethods () =
        FilteredCodes
        |> Seq.map (fun (name, info, code) ->
            let validate_jump =
                (code.FlowControl = FlowControl.Branch || code.FlowControl = FlowControl.Cond_Branch) 
                && code.OperandType = OperandType.ShortInlineBrTarget

            {|
                arguments = info.Args |> Seq.map getArgumentName
                description = info.Description 
                name = name
                parameters = info.Args |> Seq.map (fun a -> $"in {a} {getArgumentName a}")
                pop_behaviour = code.StackBehaviourPop.ToString()
                pops = StackBehaviourMap.[code.StackBehaviourPop] |> Seq.rev |> join ", "
                push_behaviour = code.StackBehaviourPush.ToString()
                pushes = StackBehaviourMap.[code.StackBehaviourPush] |> join ", "
                validate_jump = validate_jump
            |})

    let scriban = Template.Parse template
    let result = scriban.Render {| methods = getNamedMethods() |}
    result.Trim()
