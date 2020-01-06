using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        private static readonly Dictionary<StackBehaviour, int> StackBehaviourSize = new Dictionary<StackBehaviour, int> {
            { StackBehaviour.Pop0, 0 },
            { StackBehaviour.Pop1, 1 },
            { StackBehaviour.Pop1_pop1, 2 },
            { StackBehaviour.Popi, 1 },
            { StackBehaviour.Popi_pop1, 2 },
            { StackBehaviour.Popi_popi, 2 },
            { StackBehaviour.Popi_popi8, 2 },
            { StackBehaviour.Popi_popi_popi, 3 },
            { StackBehaviour.Popi_popr4, 2 },
            { StackBehaviour.Popi_popr8, 2 },
            { StackBehaviour.Popref, 1 },
            { StackBehaviour.Popref_pop1, 2 },
            { StackBehaviour.Popref_popi, 2 },
            { StackBehaviour.Popref_popi_popi, 3 },
            { StackBehaviour.Popref_popi_popi8, 3 },
            { StackBehaviour.Popref_popi_popr4, 3 },
            { StackBehaviour.Popref_popi_popr8, 3 },
            { StackBehaviour.Popref_popi_popref, 3 },
            { StackBehaviour.Push0, 0 },
            { StackBehaviour.Push1, 1 },
            { StackBehaviour.Push1_push1, 2 },
            { StackBehaviour.Pushi, 1 },
            { StackBehaviour.Pushi8, 1 },
            { StackBehaviour.Pushr4, 1 },
            { StackBehaviour.Pushr8, 1 },
            { StackBehaviour.Pushref, 1 },
            { StackBehaviour.Varpop, 0 },
            { StackBehaviour.Varpush, 0 },
            { StackBehaviour.Popref_popi_pop1, 3 }
        };
        private readonly StringBuilder _debugger = new StringBuilder();
        private readonly List<Label> _debugLabels = new List<Label>();
        private readonly string _name;
        private int _stackSize;

        public ILEmitter(string name, ILGenerator il) : this(il) => _name = name;

        public ILEmitter Break() => Emit(OpCodes.Break);

        partial void TrackStack(OpCode opCode, int change)
        {
            _stackSize += change;
            ValidateStackSize(opCode);
        }

        partial void TrackStack(OpCode opCode)
        {
            var change = StackBehaviourSize[opCode.StackBehaviourPush] - StackBehaviourSize[opCode.StackBehaviourPop];
            TrackStack(opCode, change);
        }

        private void ValidateStackSize(OpCode opCode)
        {
            if (_stackSize < 0) {
                throw new InvalidOperationException($"Negative stack on {opCode}.");
            }
        }

        partial void DebugLine(string message) => _debugger.AppendLine(message);

        partial void DebugMarkLabel(Label label) => DebugLine($"\tLabel_{_debugLabels.IndexOf(label)}:");

        partial void DebugEmitLabel(OpCode opCode, Label label) =>
            DebugLine($"\t\t{opCode} Label_{_debugLabels.IndexOf(label)}");

        partial void AddDebugLabel(Label label) => _debugLabels.Add(label);

        partial void DebugFinish()
        {
            Debug.WriteLine(_name);

            var locals = _locals
                         .SelectMany(x => x.Value)
                         .OrderBy(x => x.LocalIndex)
                         .ToArray();

            if (locals.Length != 0) {
                Debug.WriteLine("\t.locals init (");
                foreach (var item in locals) {
                    Debug.WriteLine($"\t\t[{item.LocalIndex}] {item.LocalType}");
                }

                Debug.WriteLine("\t)");
            }

            Debug.WriteLine(_debugger.ToString().TrimEnd());

            if (_scopes.Count != 0) {
                throw new InvalidOperationException("Bad locals scope state.");
            }

            if (_stackSize != 0) {
                throw new InvalidOperationException($"Stack should be empty, but it has {Math.Abs(_stackSize)} element.");
            }
        }

        /// <summary>
        ///     Emit <see cref="Debug.WriteLine(object)" />.
        /// </summary>
        /// <param name="local">Value to write.</param>
        partial void DebugWriteLine(LocalBuilder local)
        {
            DebugLine($"\t\tWrite local: {local.LocalIndex}");
            _il.Emit(OpCodes.Ldloca, local);
            if (local.LocalType != null && local.LocalType != typeof(string)) {
                _il.Emit(OpCodes.Callvirt, local.LocalType.GetMethod(nameof(ToString), Type.EmptyTypes));
            }

            _il.Emit(OpCodes.Call, typeof(Debug).GetMethod(nameof(Debug.WriteLine), new[] { typeof(string) }));
        }

        /// <summary>
        ///     Emit <see cref="Debug.WriteLine(string)" />.
        /// </summary>
        /// <param name="message">String to write.</param>
        partial void DebugWriteLine(string message)
        {
            DebugLine($"\t\tWrite: {message}");
            _il.Emit(OpCodes.Ldstr, message);
            _il.Emit(OpCodes.Call, typeof(Debug).GetMethod(nameof(Debug.WriteLine), new[] { typeof(string) }));
        }
    }
}
