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

        /// <summary>
        ///     Calls the method indicated by the passed method descriptor.
        /// </summary>
        public ILEmitter Call(MethodInfo methodInfo)
        {
            Pop(methodInfo.GetParameters().Count());
            Push(methodInfo.ReturnType == typeof(void) ? 0 : 1);

            _il.Emit(OpCodes.Call, methodInfo);

            return this;
        }

        /// <summary>
        ///     Creates a new object or a new instance of a value type, pushing an object reference (type O) onto the evaluation
        ///     stack.
        /// </summary>
        public ILEmitter Newobj(ConstructorInfo constructorInfo)
        {
            Pop(constructorInfo.GetParameters().Count());
            Push(1);

            _il.Emit(OpCodes.Newobj, constructorInfo);

            return this;
        }
    }
}