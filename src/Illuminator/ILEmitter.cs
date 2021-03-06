using System;
using System.Reflection.Emit;

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        private readonly ILGenerator _il;

        public ILEmitter(ILGenerator il) => _il = il ?? throw new ArgumentNullException(nameof(il));
    }
}