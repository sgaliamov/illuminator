using System.Reflection.Emit;

namespace Illuminator.Extensions
{
    public static class DynamicMethodExtensions
    {
        public static ILEmitter UseIlluminator(
            this DynamicMethod method,
            params ILEmitterFunc[] funcs) =>
            method.GetILGenerator()
                  .UseIlluminator(funcs);

        public static ILEmitter UseIlluminator(
            this DynamicMethod method,
            bool enableTraceLogger,
            params ILEmitterFunc[] funcs) =>
            method.GetILGenerator()
                  .UseIlluminator(enableTraceLogger, funcs);
    }
}
