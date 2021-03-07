using System;
using System.Reflection.Emit;

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        private readonly ILGenerator _il;
        private int _stackSize;

        public ILEmitter(ILGenerator il) => _il = il ?? throw new ArgumentNullException(nameof(il));

        private void Push(int count)
        {
            _stackSize += count;
        }
    }
}