using System.Reflection.Emit;

namespace Illuminator
{
    /// <summary>
    ///     Generic helpers.
    /// </summary>
    public static class ILEmitterExtensions
    {
        public static ILEmitter UseIlluminator(this ILGenerator self, params ILEmitterFunc[] funs) =>
            new ILEmitter(self).Fun(funs);

        // todo: better name
        public static ILEmitter Fun(this ILEmitter self, params ILEmitterFunc[] funs)
        {
            foreach (var fun in funs) {
                fun(self);
            }

            return self;
        }
    }
}
