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
            Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] parameters) =>
            il => il.EmitCall(opcode, methodInfo, optionalParameterTypes, parameters);

        public static ILEmitterFunc EmitCalli(
            CallingConventions callingConvention,
            Type? returnType = null,
            Type[]? parameterTypes = null,
            Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] parameters) =>
            il => il.EmitCalli(callingConvention, returnType, parameterTypes, optionalParameterTypes, parameters);

        public static ILEmitterFunc Newobj(ConstructorInfo constructorInfo, params ILEmitterFunc[] parameters) =>
            il => il.Newobj(constructorInfo, parameters);

        public static ILEmitterFunc Call(ConstructorInfo constructorInfo, params ILEmitterFunc[] parameters) =>
            il => il.Call(constructorInfo, parameters);

        public static ILEmitterFunc Call(MethodInfo methodInfo, params ILEmitterFunc[] parameters) =>
            il => il.Call(methodInfo, parameters);

        public static ILEmitterFunc Callvirt(MethodInfo methodInfo, params ILEmitterFunc[] parameters) =>
            il => il.Callvirt(methodInfo, parameters);

        public static ILEmitterFunc Ret(params ILEmitterFunc[] funcs) => il => il.Ret(funcs);
    }
}
