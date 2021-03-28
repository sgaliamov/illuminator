using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator
{
    // Extensions for call methods with ILEmitterFunc parameters.
    public static partial class ILEmitterExtensions
    {
        public static ILEmitter EmitCall(
            this ILEmitter self,
            OpCode opcode,
            MethodInfo methodInfo,
            Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] parameters) =>
            parameters.Aggregate(self, (il, func) => func(il))
                      .EmitCall(opcode, methodInfo, optionalParameterTypes);

        public static ILEmitter EmitCalli(
            this ILEmitter self,
            CallingConventions callingConvention,
            Type? returnType = null,
            Type[]? parameterTypes = null,
            Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] parameters) =>
            parameters.Aggregate(self, (il, func) => func(il))
                      .EmitCalli(callingConvention, returnType, parameterTypes, optionalParameterTypes);

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

        public static ILEmitter Ret(this ILEmitter self, params ILEmitterFunc[] parameters) =>
            parameters
                .Aggregate(self, (il, func) => func(il))
                .Ret();
    }
}
