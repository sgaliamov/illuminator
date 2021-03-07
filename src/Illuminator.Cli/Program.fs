open Scriban
open Model

let template = @"
/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System.Reflection.Emit;

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        {{- for method in methods }}
        /// <summary>
        ///     {{ method.description }}
        ///     Size: {{ method.size }}.
        ///     StackBehaviourPop: {{ method.pop_behaviour }}.
        ///     StackBehaviourPush: {{ method.push_behaviour }}.
        /// </summary>
        public ILEmitter {{ method.name }}({{ method.parameters | array.join "", "" }})
        {
            Pop({{ method.pops }});
            Push({{ method.pushes }});
            
            _il.Emit(OpCodes.{{ method.arguments | array.insert_at 0 method.name | array.join "", "" }});
            
            return this;
        }
        {{~ end ~}}
    }
}"

[<EntryPoint>]
let main _ =
    let scriban = Template.Parse template
    let result = scriban.Render {| methods = getMethods() |} // => "Hello World!"
    printfn "%s" (result.Trim())
    0
