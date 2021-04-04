using System.Diagnostics;

namespace Illuminator.Logger
{
    public sealed class DebugLogger : ILogger
    {
        public void Log(in string message, params object?[] args) =>
            Debug.WriteLine($"{message}({string.Join(", ", args)})");
    }
}
