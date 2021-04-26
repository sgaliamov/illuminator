using System;

namespace Illuminator.Extensions
{
    public static class ILEmitterExtensions
    {
        public static Func<TResult> CreateFunction<TResult>(this ILEmitter self) =>
            self.CreateDelegate<Func<TResult>>();

        public static Func<T, TResult> CreateFunction<T, TResult>(this ILEmitter self) =>
            self.CreateDelegate<Func<T, TResult>>(); // todo: generate all funcs and actions
    }
}
