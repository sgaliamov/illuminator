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
            params ILEmitterFunc[] funs) =>
            il => il.EmitCall(opcode, methodInfo, optionalParameterTypes, funs);

        public static ILEmitterFunc EmitCalli(
            CallingConventions callingConvention,
            Type? returnType = null,
            Type[]? parameterTypes = null,
            Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] funs) =>
            il => il.EmitCalli(callingConvention, returnType, parameterTypes, optionalParameterTypes, funs);

        public static ILEmitterFunc Newobj(ConstructorInfo constructorInfo, params ILEmitterFunc[] funs) =>
            il => il.Newobj(constructorInfo, funs);

        public static ILEmitterFunc Call(ConstructorInfo constructorInfo, params ILEmitterFunc[] funs) =>
            il => il.Call(constructorInfo, funs);

        public static ILEmitterFunc Call(MethodInfo methodInfo, params ILEmitterFunc[] funs) =>
            il => il.Call(methodInfo, funs);

        public static ILEmitterFunc Callvirt(MethodInfo methodInfo, params ILEmitterFunc[] funs) =>
            il => il.Callvirt(methodInfo, funs);

        public static ILEmitterFunc Ret() => il => il.Ret();
    }
}
