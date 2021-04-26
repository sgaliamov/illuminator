using System;

namespace Illuminator.Extensions
{
    public static class Functions
    {
        public static ILEmitterFunc If(
            ILEmitterFunc condition,
            ILEmitterFunc then,
            ILEmitterFunc @else) => (in ILEmitter il) =>
            il.Brfalse(condition, out var otherwise)
              .Emit(then)
              .Br(out var end)
              .MarkLabel(otherwise)
              .Emit(@else)
              .MarkLabel(end);

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
