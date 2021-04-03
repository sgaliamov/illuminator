using System.Reflection.Emit;

namespace Illuminator
{
    /// <summary>
    ///     Extensions for manual wrappers over ILGenerator.
    /// </summary>
    public static class ILGeneratorExtensions
    {
        public static ILEmitter UseIlluminator(this ILGenerator self, params ILEmitterFunc[] funcs) =>
            new ILEmitter(self).Emit(funcs);
    }
}
