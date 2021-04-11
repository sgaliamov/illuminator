using System.Linq;
using System.Reflection;

namespace Illuminator
{
    // Extensions for call methods with ILEmitterFunc funcs.
    // This class cannot be generated, because `ILEmitterFunc[]` should be last parameter.
    public static partial class ILEmitterExtensions
    {
        public static ILEmitter Call(
            this ILEmitter self,
            in MethodInfo methodInfo,
            params ILEmitterFunc[] funcs) =>
            funcs
                .Aggregate(self, (il, func) => func(il))
                .Call(methodInfo);

        public static ILEmitter Call(
            this ILEmitter self,
            in ConstructorInfo constructorInfo,
            params ILEmitterFunc[] funcs) =>
            funcs
                .Aggregate(self, (il, func) => func(il))
                .Call(constructorInfo);

        public static ILEmitter Callvirt(
            this ILEmitter self,
            in MethodInfo methodInfo,
            params ILEmitterFunc[] funcs) =>
            funcs
                .Aggregate(self, (il, func) => func(il))
                .Callvirt(methodInfo);

        public static ILEmitter Newobj(
            this ILEmitter self,
            in ConstructorInfo constructorInfo,
            params ILEmitterFunc[] funcs) =>
            funcs
                .Aggregate(self, (il, func) => func(il))
                .Newobj(constructorInfo);

        public static ILEmitter Ret(this ILEmitter self, params ILEmitterFunc[] funcs) =>
            funcs
                .Aggregate(self, (il, func) => func(il))
                .Ret();
    }
}
