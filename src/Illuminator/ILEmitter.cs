using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Illuminator
{
    public sealed partial class ILEmitter : IDisposable
    {
        private const BindingFlags PrivateFieldBindingFlags = BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance;
        private readonly ILGenerator _il;
        private readonly MethodInfo _methodBuilder;
        private readonly Stack<Type?> _stack = new Stack<Type?>();

        public ILEmitter(ILGenerator il)
        {
            _il = il ?? throw new ArgumentNullException(nameof(il));
            _methodBuilder = (MethodInfo) typeof(ILGenerator).GetField("m_methodBuilder", PrivateFieldBindingFlags).GetValue(_il);
        }

        public void Dispose()
        {
            VerifyStackSize();

            if (_stack.Count != 0)
            {
                throw new ILEmitterException($"Stack is invalid: {_stack}");
            }
        }

        [Conditional("DEBUG")]
        private void VerifyStackSize()
        {
            var maxMidStackCur = (int) typeof(ILGenerator)
                .GetField("m_maxMidStackCur", PrivateFieldBindingFlags)
                .GetValue(_il);

            if (_stack.Count != maxMidStackCur)
            {
                throw new ILEmitterException("Stack size does not match to ILGenerator stack.");
            }
        }

        /// <summary>
        ///     Push unknown type parameters in the stack.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void PushAny(int count)
        {
            for (var i = 0; i < count; i++)
            {
                _stack.Push(null);
            }
        }

        /// <summary>
        ///     Pop any type parameters from the stack.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void PopAny(int count)
        {
            for (var i = 0; i < count; i++)
            {
                _stack.Pop();
            }
        }

        ///// <summary>
        /////     Calls the method indicated by the passed method descriptor.
        ///// </summary>
        //public ILEmitter Call(MethodInfo methodInfo)
        //{
        //    PopAny(methodInfo.GetParameters().Count());
        //    PushAny(methodInfo.ReturnType == typeof(void) ? 0 : 1);

        //    _il.Emit(OpCodes.Call, methodInfo);

        //    return this;
        //}

        /// <summary>
        ///     Returns from the current method, pushing a return value (if present) from the callee's evaluation stack onto the
        ///     caller's evaluation stack.
        /// </summary>
        public ILEmitter Ret()
        {
            _il.Emit(OpCodes.Ret);

            if (_methodBuilder.ReturnType == typeof(void))
            {
                return this;
            }

            var expected = _stack.Pop();
            if (expected != _methodBuilder.ReturnType)
            {
                throw new ILEmitterException(
                    $"Invalid return type. Expected {expected}; actual: {_methodBuilder.ReturnType}.");
            }

            return this;
        }

        /// <summary>
        ///     Creates a new object or a new instance of a value type, pushing an object reference (type O) onto the evaluation
        ///     stack.
        /// </summary>
        public ILEmitter Newobj(ConstructorInfo constructorInfo)
        {
            _il.Emit(OpCodes.Newobj, constructorInfo);

            PopAny(constructorInfo.GetParameters().Count());
            _stack.Push(constructorInfo.DeclaringType); // todo: test

            return this;
        }
    }
}