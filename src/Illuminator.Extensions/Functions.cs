using System;

namespace Illuminator.Extensions
{
    public static class Functions
    {
        public static ILEmitterFunc If(
            ILEmitterFunc condition,
            ILEmitterFunc then,
            ILEmitterFunc otherwise) => (in ILEmitter il) =>
            il.Brfalse(condition, out var @else)
              .Emit(then)
              .Br(out var end)
              .MarkLabel(@else)
              .Emit(otherwise)
              .MarkLabel(end);

        public static ILEmitterFunc Ret<T>(T value) => (in ILEmitter il) =>
            value switch {
                int val => il.Ldc_I4(val).Ret(),
                long val => il.Ldc_I8(val).Ret(),
                float val => il.Ldc_R4(val).Ret(),
                double val => il.Ldc_R8(val).Ret(),
                byte val => il.Ldc_I4_S(val).Ret(),
                sbyte val => il.Ldc_I4_S(val).Ret(),
                _ => throw new NotSupportedException("Only numeric values are supported")
            };
    }
}
