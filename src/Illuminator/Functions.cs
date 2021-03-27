using System.Reflection;

namespace Illuminator
{
    // Manual functions for call methods.
    public static partial class Functions
    {
        public static ILEmitterFunc Newobj(ConstructorInfo constructorInfo, params ILEmitterFunc[] funs) => il => il.Newobj(constructorInfo, funs);

        public static ILEmitterFunc Ret() => il => il.Ret();
    }
}
