using System.Reflection.Emit;

namespace Illuminator
{
    public static partial class ILEmitterExtensions
    {
        /// <summary>
        ///     Generic version of <see cref="ILEmitter.DeclareLocal(System.Type, out LocalBuilder)" />
        /// </summary>
        public static ILEmitter DeclareLocal<T>(this ILEmitter self, out LocalBuilder output) =>
            self.DeclareLocal(typeof(T), out output);
    }
}
