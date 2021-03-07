using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        private readonly ILGenerator _il;
        private int _stackSize;

        public ILEmitter(ILGenerator il) => _il = il ?? throw new ArgumentNullException(nameof(il));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Push(int count) => _stackSize += count;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Pop(int count) => _stackSize -= count;
    }
}