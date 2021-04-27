using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace Illuminator
{
    // Debug logger.
    public sealed partial class ILEmitter
    {
        private sealed class TraceLogger
        {
            private readonly ILEmitter _owner;
            private readonly StringBuilder _log = new();

            public TraceLogger(ILEmitter owner) => _owner = owner;

            public void Log(in string message, params object?[] args)
            {
                switch (message) {
                    case "DefineLabel":
                        return;

                    case "MarkLabel":
                        _log.AppendLine($"\t{Join(args)}:");
                        return;

                    default:
                        _log.AppendLine($"\t{message} {Join(args)}");
                        return;
                }
            }

            public void Log(in OpCode code, params object?[] args)
            {
                string message = $".{code} {Join(args)}";
                _log.AppendFormat(
                    "\t\t{0,3}: {1,-120} | {2}\n",
                    _owner._il.ILOffset,
                    message,
                    _owner.GetStackSize());
            }

            public void Flush()
            {
                if (_log.Length == 0) {
                    return;
                }

                WriteLocals();

                var declaringType = _owner._methodBuilder.DeclaringType == null
                    ? string.Empty
                    : $"Type: {Stringify(_owner._methodBuilder.DeclaringType)}\n";

                _log.Insert(0, $"\n\n{declaringType}{Stringify(_owner._methodBuilder)}\n");

                Trace.WriteLine(_log.ToString().TrimEnd());

                _log.Clear();
            }

            private void WriteLocals()
            {
                var locals =
                    _owner._locals
                          .SelectMany(x => x.Value)
                          .OrderBy(x => x.LocalIndex)
                          .ToArray();

                if (locals.Length == 0) {
                    return;
                }

                var sbLocals = new StringBuilder("\tLocals:\n");

                foreach (var item in locals) {
                    sbLocals.AppendLine($"\t\t[{item.LocalIndex}] {item.LocalType}");
                }

                _log.Insert(0, sbLocals);
            }

            private static string Join<T>(IEnumerable<T>? args)
            {
                if (args == null) {
                    return string.Empty;
                }

                return string.Join(
                    " ",
                    args.Select(x => {
                        var str = Stringify(x);

                        return string.IsNullOrWhiteSpace(str)
                            ? "NONE" // todo: test or remove
                            : str;
                    }));
            }

            private static IEnumerable<string?> Stringify(IEnumerable enumerable) =>
                from object? item in enumerable
                select Stringify(item);

            private static string Stringify(in object? value) =>
                value switch {
                    Label label => $"Label_{label.GetHashCode()}",
                    string str => str.Replace("System.", ""),
                    IEnumerable enumerable => Join(Stringify(enumerable)),
                    _ => Join(value
                              ?.ToString()
                              .Split('\n')
                              .Select(x => x.Trim())
                              .Where(x => !string.IsNullOrWhiteSpace(x)))
                };
        }
    }
}
