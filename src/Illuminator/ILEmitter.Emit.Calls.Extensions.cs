using System.Linq;
using System.Reflection;

namespace Illuminator
{
    // Extensions for call methods with ILEmitterFunc parameters.
    public static partial class ILEmitterExtensions
    {
        public static ILEmitter Call(this ILEmitter self, MethodInfo methodInfo, params ILEmitterFunc[] parameters) =>
            parameters
                .Aggregate(self, (il, func) => func(il))
                .Call(methodInfo);

        public static ILEmitter Call(this ILEmitter self, ConstructorInfo constructorInfo, params ILEmitterFunc[] parameters) =>
            parameters
                .Aggregate(self, (il, func) => func(il))
                .Call(constructorInfo);

        public static ILEmitter Callvirt(this ILEmitter self, MethodInfo methodInfo, params ILEmitterFunc[] parameters) =>
            parameters
                .Aggregate(self, (il, func) => func(il))
                .Callvirt(methodInfo);

        public static ILEmitter Newobj(this ILEmitter self, ConstructorInfo constructorInfo, params ILEmitterFunc[] parameters) =>
            parameters
                .Aggregate(self, (il, func) => func(il))
                .Newobj(constructorInfo);
    }
}
