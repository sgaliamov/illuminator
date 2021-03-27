using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator
{
    /// <summary>
    ///     Extensions for manual wrappers over ILGenerator.
    /// </summary>
    public static partial class ILEmitterExtensions
    {
        public static ILEmitter UseIlluminator(this ILGenerator self, params ILEmitterFunc[] funs) =>
            new ILEmitter(self).Fun(funs);

        // todo: better name
        public static ILEmitter Fun(this ILEmitter self, params ILEmitterFunc[] funs) =>
            funs.Aggregate(self, (il, func) => func(il));

        public static ILEmitter EmitCall(
            this ILEmitter self,
            OpCode opcode,
            MethodInfo methodInfo,
            Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] funs) =>
            funs.Aggregate(self, (il, func) => func(il))
                .EmitCall(opcode, methodInfo, optionalParameterTypes);

        public static ILEmitter EmitCalli(
            this ILEmitter self,
            CallingConventions callingConvention,
            Type? returnType = null,
            Type[]? parameterTypes = null,
            Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] funs) =>
            funs.Aggregate(self, (il, func) => func(il))
                .EmitCalli(callingConvention, returnType, parameterTypes, optionalParameterTypes);
    }
}
