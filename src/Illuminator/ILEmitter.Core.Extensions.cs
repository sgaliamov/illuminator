using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator
{
    public static partial class ILEmitterExtensions
    {
        /// <summary>
        ///     Generic version of <see cref="ILEmitter.DeclareLocal(Type, out LocalBuilder)" />
        /// </summary>
        public static ILEmitter DeclareLocal<T>(this ILEmitter self, out LocalBuilder output) =>
            self.DeclareLocal(typeof(T), out output);

        public static ILEmitter EmitCalli(
            this ILEmitter self,
            in CallingConventions callingConvention,
            in Type? returnType = null,
            in Type[]? parameterTypes = null,
            in Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] funcs) =>
            funcs
                .Aggregate(self, (emitter, func) => func(emitter))
                .EmitCalli(callingConvention, returnType, parameterTypes, optionalParameterTypes);

        public static ILEmitter EmitCall(
            this ILEmitter self,
            in OpCode opcode,
            in MethodInfo methodInfo,
            in Type[]? optionalParameterTypes = null,
            params ILEmitterFunc[] funcs) =>
            funcs
                .Aggregate(self, (emitter, func) => func(emitter))
                .EmitCall(opcode, methodInfo, optionalParameterTypes);
    }
}
