using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator
{
    // Manual functions for call methods.
    public static partial class Functions
    {
        public static ILEmitterFunc EmitCall(
            OpCode opcode,
            MethodInfo methodInfo,
            Type[]? parametersTypes = null,
            Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] parameters) =>
            (in ILEmitter il) => il.EmitCall(opcode, methodInfo, parametersTypes, optionalParameterTypes, parameters);

        public static ILEmitterFunc EmitCalli(
            CallingConventions callingConvention,
            Type? returnType = null,
            Type[]? parameterTypes = null,
            Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] parameters) =>
            (in ILEmitter il) => il.EmitCalli(callingConvention, returnType, parameterTypes, optionalParameterTypes, parameters);

        public static ILEmitterFunc Newobj(
            ConstructorInfo constructorInfo,
            Type[]? parametersTypes = null,
            params ILEmitterFunc[] parameters) =>
            (in ILEmitter il) => il.Newobj(constructorInfo, parametersTypes, parameters);

        public static ILEmitterFunc Call(
            ConstructorInfo constructorInfo,
            Type[]? parametersTypes = null,
            params ILEmitterFunc[] parameters) =>
            (in ILEmitter il) => il.Call(constructorInfo, parametersTypes, parameters);

        public static ILEmitterFunc Call(
            MethodInfo methodInfo,
            Type[]? parametersTypes = null,
            params ILEmitterFunc[] parameters) =>
            (in ILEmitter il) => il.Call(methodInfo, parametersTypes, parameters);

        public static ILEmitterFunc Callvirt(
            MethodInfo methodInfo,
            Type[]? parametersTypes = null,
            params ILEmitterFunc[] parameters) =>
            (in ILEmitter il) => il.Callvirt(methodInfo, parametersTypes, parameters);

        public static ILEmitterFunc Ret(params ILEmitterFunc[] funcs) => (in ILEmitter il) => il.Ret(funcs);

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.MarkLabel(Label)" />.
        /// </summary>
        public static ILEmitterFunc MarkLabel(Label loc) => (in ILEmitter il) => il.MarkLabel(loc);
    }
}
