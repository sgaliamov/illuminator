using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator
{
    // Extensions for call methods with ILEmitterFunc parameters.
    // This class cannot be generated, because `ILEmitterFunc[]` should be last parameter
    // and `parametersTypes` parameter has to be places in right position.
    public static partial class ILEmitterExtensions
    {
        public static ILEmitter EmitCall(
            this ILEmitter self,
            in OpCode opcode,
            in MethodInfo methodInfo,
            in Type[]? parametersTypes = null,
            in Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] parameters) =>
            parameters
                .Aggregate(self, (il, func) => func(il))
                .EmitCall(opcode, methodInfo, parametersTypes, optionalParameterTypes);

        public static ILEmitter EmitCalli(
            this ILEmitter self,
            in CallingConventions callingConvention,
            in Type? returnType = null,
            in Type[]? parameterTypes = null,
            in Type[]? optionalParameterTypes = null,
            in ILEmitterFunc? method = null,
            params ILEmitterFunc[] parameters)
        {
            var il = parameters
                .Aggregate(self, (emitter, func) => func(emitter));

            if (method != null) {
                il.Emit(method);
            }

            return il.EmitCalli(callingConvention, returnType, parameterTypes, optionalParameterTypes);
        }

        public static ILEmitter Call(
            this ILEmitter self,
            in MethodInfo methodInfo,
            in Type[]? parametersTypes = null,
            params ILEmitterFunc[] parameters) =>
            parameters
                .Aggregate(self, (il, func) => func(il))
                .Call(methodInfo, parametersTypes);

        public static ILEmitter Call(
            this ILEmitter self,
            in ConstructorInfo constructorInfo,
            in Type[]? parametersTypes = null,
            params ILEmitterFunc[] parameters) =>
            parameters
                .Aggregate(self, (il, func) => func(il))
                .Call(constructorInfo, parametersTypes);

        public static ILEmitter Callvirt(
            this ILEmitter self,
            in MethodInfo methodInfo,
            in Type[]? parametersTypes = null,
            params ILEmitterFunc[] parameters) =>
            parameters
                .Aggregate(self, (il, func) => func(il))
                .Callvirt(methodInfo, parametersTypes);

        public static ILEmitter Newobj(
            this ILEmitter self,
            in ConstructorInfo constructorInfo,
            in Type[]? parametersTypes = null,
            params ILEmitterFunc[] parameters) =>
            parameters
                .Aggregate(self, (il, func) => func(il))
                .Newobj(constructorInfo, parametersTypes);

        public static ILEmitter Ret(this ILEmitter self, params ILEmitterFunc[] parameters) =>
            parameters
                .Aggregate(self, (il, func) => func(il))
                .Ret();
    }
}