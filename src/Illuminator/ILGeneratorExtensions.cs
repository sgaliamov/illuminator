using System.Reflection.Emit;
using Illuminator.Logger;

namespace Illuminator
{
    /// <summary>
    ///     Extensions for manual wrappers over ILGenerator.
    /// </summary>
    public static class ILGeneratorExtensions
    {
        public static ILEmitter UseIlluminator(
            this ILGenerator self,
            params ILEmitterFunc[] funcs) =>
            new ILEmitter(self).Emit(funcs);

        public static ILEmitter UseIlluminator(
            this ILGenerator self,
            ILogger logger,
            params ILEmitterFunc[] funcs) =>
            new ILEmitter(self, logger).Emit(funcs);
    }
}
