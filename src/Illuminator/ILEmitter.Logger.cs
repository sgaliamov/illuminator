using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace Illuminator
{
    // Debug logger.
    public sealed partial class ILEmitter
    {
        private sealed class DebugLogger
        {
            private readonly ILEmitter _owner;
            private readonly StringBuilder _log = new();

            public DebugLogger(ILEmitter owner) => _owner = owner;

            public void Log(in string message, params object?[] args) =>
                _log.AppendLine($"\t{message} {string.Join(" ", args.Select(x => ToString(x)))}");

            public void Log(in OpCode code, params object?[] args)
            {
                string message = $".{code} {string.Join(" ", args.Select(x => ToString(x)))}";
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

                Debug.WriteLine(_log.ToString().TrimEnd());
                _log.Clear();
            }

            private static string? ToString(in object? value) =>
                value switch {
                    Label label => $"Label_{label.GetHashCode()}",
                    _ => value?.ToString()
                };
        }
    }
}