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

            public void Log(in string message, params object?[] args) =>
                _log.AppendLine($"\t{message} {Join(args)}");

            public void Log(in OpCode code, params object?[] args)
            {
                string message = $".{code} {Join(args)}";
                _log.AppendFormat(
                    "\t\t{0,3}: {1,-50} | {2}\n",
                    _owner._il.ILOffset,
                    message,
                    _owner.StackToString());
            }

            public void Flush()
            {
                if (_log.Length == 0) {
                    return;
                }

                var locals =
                    _owner._locals
                          .SelectMany(x => x.Value)
                          .OrderBy(x => x.LocalIndex)
                          .ToArray();

                if (locals.Length != 0) {
                    var sbLocals = new StringBuilder("\tLocals:\n");
                    foreach (var item in locals) {
                        sbLocals.AppendLine($"\t\t[{item.LocalIndex}] {item.LocalType}");
                    }

                    _log.Insert(0, sbLocals);
                }

                _log.Insert(0, $"{_owner._methodBuilder}\n");

                Trace.WriteLine(_log.ToString().TrimEnd());
                _log.Clear();
            }

            private static string Join<T>(IEnumerable<T> args) =>
                string.Join(
                    " ",
                    args.Select(x => {
                        var str = ToString(x);

                        return string.IsNullOrWhiteSpace(str)
                            ? "NONE" // todo: test or remove
                            : str;
                    }));

            private static string? ToString(in object? value) =>
                value switch {
                    Label label => $"Label_{label.GetHashCode()}",
                    string str => str,
                    IEnumerable enumerable => Join(ToString(enumerable)),
                    _ => value?.ToString()
                };

            private static IEnumerable<string?> ToString(IEnumerable enumerable)
            {
                foreach (var item in enumerable) {
                    yield return ToString(item);
                }
            }
        }
    }
}
