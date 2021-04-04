using System.Reflection.Emit;

namespace Illuminator
{
    public static partial class ILEmitterExtensions
    {
        /// <summary>
        ///     Define and mark label.
        /// </summary>
        public static ILEmitter MarkLabel(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .MarkLabel(label);
    }
}
