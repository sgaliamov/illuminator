using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Illuminator
{
    public sealed partial class ILEmitter : IDisposable
    {
        private readonly ILGenerator _il;
        private int _stackSize;

        public ILEmitter(ILGenerator il) => 
            _il = il ?? throw new ArgumentNullException(nameof(il));

        public void Dispose()
        {
            if (_stackSize != 0)
            {
                throw new ILEmitterException($"Stack size is invalid: {_stackSize}");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Push(int count) => _stackSize += count;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Pop(int count) => _stackSize -= count;
    }
}