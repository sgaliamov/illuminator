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
            params ILEmitterFunc[] funcs) =>
            il => il.EmitCall(opcode, methodInfo, optionalParameterTypes, funcs);

        public static ILEmitterFunc EmitCalli(
            CallingConventions callingConvention,
            Type? returnType = null,
            Type[]? parameterTypes = null,
            Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] funcs) =>
            il => il.EmitCalli(callingConvention, returnType, parameterTypes, optionalParameterTypes, funcs);

        public static ILEmitterFunc Newobj(ConstructorInfo constructorInfo, params ILEmitterFunc[] funcs) =>
            il => il.Newobj(constructorInfo, funcs);

        public static ILEmitterFunc Call(ConstructorInfo constructorInfo, params ILEmitterFunc[] funcs) =>
            il => il.Call(constructorInfo, funcs);

        public static ILEmitterFunc Call(MethodInfo methodInfo, params ILEmitterFunc[] funcs) =>
            il => il.Call(methodInfo, funcs);

        public static ILEmitterFunc Callvirt(MethodInfo methodInfo, params ILEmitterFunc[] funcs) =>
            il => il.Callvirt(methodInfo, funcs);

        public static ILEmitterFunc Ret(params ILEmitterFunc[] funcs) => il => il.Ret(funcs);
    }
}
