﻿using System;
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
            il => il.EmitCall(opcode, methodInfo, parametersTypes, optionalParameterTypes, parameters);

        public static ILEmitterFunc EmitCalli(
            CallingConventions callingConvention,
            Type? returnType = null,
            Type[]? parameterTypes = null,
            Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] parameters) =>
            il => il.EmitCalli(callingConvention, returnType, parameterTypes, optionalParameterTypes, parameters);

        public static ILEmitterFunc Newobj(
            ConstructorInfo constructorInfo,
            Type[]? parametersTypes = null,
            params ILEmitterFunc[] parameters) =>
            il => il.Newobj(constructorInfo, parametersTypes, parameters);

        public static ILEmitterFunc Call(
            ConstructorInfo constructorInfo,
            Type[]? parametersTypes = null,
            params ILEmitterFunc[] parameters) =>
            il => il.Call(constructorInfo, parametersTypes, parameters);

        public static ILEmitterFunc Call(
            MethodInfo methodInfo,
            Type[]? parametersTypes = null,
            params ILEmitterFunc[] parameters) =>
            il => il.Call(methodInfo, parametersTypes, parameters);

        public static ILEmitterFunc Callvirt(
            MethodInfo methodInfo,
            Type[]? parametersTypes = null,
            params ILEmitterFunc[] parameters) =>
            il => il.Callvirt(methodInfo, parametersTypes, parameters);

        public static ILEmitterFunc Ret(params ILEmitterFunc[] funcs) => il => il.Ret(funcs);
    }
}
