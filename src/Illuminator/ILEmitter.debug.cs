using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        private readonly StringBuilder _debugger = new StringBuilder();
        private readonly List<Label> _debugLabels = new List<Label>();
        private readonly string _name;
        private readonly FieldInfo _maxMidStackCur = typeof(ILGenerator).GetField("m_maxMidStackCur", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance);

        public ILEmitter(string name, ILGenerator il) : this(il) => _name = name;

        public ILEmitter Break() => Emit(OpCodes.Break);

        partial void DebugLine(string message) => _debugger.AppendFormat("{0,-50} | {1}\n", message, GetStackSize());

        partial void DebugMarkLabel(Label label) => DebugLine($"\tLabel_{_debugLabels.IndexOf(label)}:\t");

        partial void DebugEmitLabel(OpCode opCode, Label label) => DebugLine($"\t\t{opCode} Label_{_debugLabels.IndexOf(label)}");

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

            ValidateStackSize();
        }

        private void ValidateStackSize()
        {
            var stackSize = GetStackSize();

            if (stackSize != 0) {
                throw new InvalidOperationException(
                    $"Stack should be empty, but it has {Math.Abs(stackSize)} element.");
            }
        }

        private int GetStackSize() => (int?)_maxMidStackCur?.GetValue(_il) ?? 0;
    }
}
