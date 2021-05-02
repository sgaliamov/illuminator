using System;
using System.Reflection.Emit;

namespace Illuminator.Extensions
{
    public static class Functions
    {
        /// <summary>
        ///     Emit if statement.
        ///     <example>
        ///         <code>
        /// if (condition) {
        ///     then();
        /// } else {
        ///     otherwise();
        /// }
        ///         </code>
        ///     </example>
        /// </summary>
        /// <param name="condition">Expression that emit </param>
        /// <param name="then"></param>
        /// <param name="otherwise"></param>
        /// <returns>ILEmitterFunc</returns>
        public static ILEmitterFunc If(
            ILEmitterFunc condition,
            ILEmitterFunc then,
            ILEmitterFunc otherwise) => (in ILEmitter il) =>
            il.Brfalse(condition, out var label)
              .Emit(then)
              .Br(out var end)
              .MarkLabel(label)
              .Emit(otherwise)
              .MarkLabel(end);

        public static ILEmitter Stloc<T>(this ILEmitter self, ILEmitterFunc value, out LocalBuilder local)
        {
            var il = self.DeclareLocal<T>(out var output);
            local = output;

            return il.Stloc(value, local);
        }

        public static ILEmitterFunc Ret<T>(T value) => (in ILEmitter il) =>
            value switch {
                int val => il.Ldc_I4(val).Ret(),
                long val => il.Ldc_I8(val).Ret(),
                float val => il.Ldc_R4(val).Ret(),
                double val => il.Ldc_R8(val).Ret(),
                byte val => il.Ldc_I4_S(val).Ret(),
                sbyte val => il.Ldc_I4_S(val).Ret(),
                string val => il.Ldstr(val).Ret(),
                _ => throw new NotSupportedException("Only strings and numeric values are supported.")
            };
    }
}
