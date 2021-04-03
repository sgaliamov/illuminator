using System.Reflection.Emit;

namespace Illuminator.Extensions
{
    public static class CoreExtensions
    {
        /// <summary>
        ///     Generic version of <see cref="ILEmitter.DeclareLocal(System.Type, out LocalBuilder)" />
        /// </summary>
        public static ILEmitter DeclareLocal<T>(this ILEmitter self, out LocalBuilder output) =>
            self.DeclareLocal(typeof(T), out output);

        /// <summary>
        ///     Define and mark label.
        /// </summary>
        public static ILEmitter MarkLabel(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .MarkLabel(label);
    }
}
