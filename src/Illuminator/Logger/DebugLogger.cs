using System.Diagnostics;
using System.Reflection.Emit;
using System.Text;

namespace Illuminator.Logger
{
    public sealed class DebugLogger : ILogger
    {
        private readonly StringBuilder _debugger = new();

        public void Log(in string message, params object?[] args) =>
            Debug.WriteLine($"{message}({string.Join(", ", args)})");

        public void Log(in OpCode code, params object?[] args) =>
            Debug.WriteLine($"{code}({string.Join(", ", args)})");

        //partial void DebugLine(string message) => _debugger.AppendFormat("{0,-50} | {1}\n", message, GetStackSize());

        //partial void DebugMarkLabel(Label label) => DebugLine($"\tLabel_{_debugLabels.IndexOf(label)}:\t");

        //partial void DebugEmitLabel(OpCode opCode, Label label) => DebugLine($"\t\t{opCode} Label_{_debugLabels.IndexOf(label)}");

        //partial void AddDebugLabel(Label label) => _debugLabels.Add(label);

        //partial void Flush()
        //{
        //    Debug.WriteLine(_name);

        //    var locals = _locals
        //        .SelectMany(x => x.Value)
        //        .OrderBy(x => x.LocalIndex)
        //        .ToArray();

        //    if (locals.Length != 0) {
        //        Debug.WriteLine("\t.locals init (");
        //        foreach (var item in locals) {
        //            Debug.WriteLine($"\t\t[{item.LocalIndex}] {item.LocalType}");
        //        }

        //        Debug.WriteLine("\t)");
        //    }

        //    Debug.WriteLine(_debugger.ToString().TrimEnd());

        //    if (_scopes.Count != 0) {
        //        throw new InvalidOperationException("Bad locals scope state.");
        //    }

        //    ValidateStackSize();
        //}
    }
}