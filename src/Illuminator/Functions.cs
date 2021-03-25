using System.Reflection;

namespace Illuminator
{
    public static partial class Functions
    {
        public static ILEmitterFunc Newobj(ConstructorInfo constructorInfo, params ILEmitterFunc[] funs) => il => il.Newobj(constructorInfo, funs);

        public static ILEmitterFunc Ret() => il => il.Ret();
    }
}
