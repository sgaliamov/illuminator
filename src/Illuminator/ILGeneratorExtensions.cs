using System.Reflection.Emit;

namespace Illuminator
{
    /// <summary>
    ///     Extensions for manual wrappers over ILGenerator.
    /// </summary>
    public static class ILGeneratorExtensions
    {
        // we need this overload to be able to not define `enableTraceLogger` parameter.
        public static ILEmitter UseIlluminator(
            this ILGenerator self,
            params ILEmitterFunc[] funcs) =>
            new ILEmitter(self).Emit(funcs);

        public static ILEmitter UseIlluminator(
            this ILGenerator self,
            bool enableTraceLogger,
            params ILEmitterFunc[] funcs) =>
            new ILEmitter(self, enableTraceLogger).Emit(funcs);
    }
}
