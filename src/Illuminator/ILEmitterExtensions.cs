using System.Reflection.Emit;

namespace Illuminator
{
    public static class ILEmitterExtensions
    {
        public static ILEmitter UseIlluminator(this ILGenerator self) => new ILEmitter(self);
    }
}
