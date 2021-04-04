namespace Illuminator.Logger
{
    public interface ILogger
    {
        void Log(in string message, params object?[] args);
    }
}
