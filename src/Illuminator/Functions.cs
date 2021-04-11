using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator
{
    // Manual functions.
    public static partial class Functions
    {
        public static ILEmitterFunc Emit(params ILEmitterFunc[] funcs) => (in ILEmitter il) => il.Emit(funcs);

        public static ILEmitterFunc EmitCall(
            OpCode opcode,
            MethodInfo methodInfo,
            Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] funcs) =>
            (in ILEmitter il) =>
                il.EmitCall(
                    opcode,
                    methodInfo,
                    optionalParameterTypes,
                    funcs);

        public static ILEmitterFunc EmitCalli(
            CallingConventions callingConvention,
            Type? returnType = null,
            Type[]? parameterTypes = null,
            Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] funcs) =>
            (in ILEmitter il) =>
                il.EmitCalli(
                    callingConvention,
                    returnType,
                    parameterTypes,
                    optionalParameterTypes,
                    funcs);

        public static ILEmitterFunc Newobj(
            ConstructorInfo constructorInfo,
            params ILEmitterFunc[] funcs) =>
            (in ILEmitter il) =>
                il.Newobj(
                    constructorInfo,
                    funcs);

        public static ILEmitterFunc Call(
            ConstructorInfo constructorInfo,
            params ILEmitterFunc[] funcs) =>
            (in ILEmitter il) =>
                il.Call(
                    constructorInfo,
                    funcs);

        public static ILEmitterFunc Call(
            MethodInfo methodInfo,
            params ILEmitterFunc[] funcs) =>
            (in ILEmitter il) =>
                il.Call(
                    methodInfo,
                    funcs);

        public static ILEmitterFunc Callvirt(
            MethodInfo methodInfo,
            params ILEmitterFunc[] funcs) =>
            (in ILEmitter il) =>
                il.Callvirt(
                    methodInfo,
                    funcs);

        public static ILEmitterFunc Ret(params ILEmitterFunc[] funcs) => (in ILEmitter il) => il.Ret(funcs);

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.MarkLabel(Label)" />.
        /// </summary>
        public static ILEmitterFunc MarkLabel(Label loc) => (in ILEmitter il) => il.MarkLabel(loc);
    }
}
