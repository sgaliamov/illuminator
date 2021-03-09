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
        private readonly Stack<string> _stack = new Stack<string>();

        public ILEmitter(ILGenerator il)
        {
            _il = il ?? throw new ArgumentNullException(nameof(il));
            _methodBuilder = (MethodInfo) typeof(ILGenerator).GetField("m_methodBuilder", PrivateFieldBindingFlags).GetValue(_il);
        }

        public void Dispose()
        {
            VerifyStackSize();
            VerifyStackIsEmpty();
        }

        private void VerifyStackIsEmpty()
        {
            if (_stack.Count != 0)
            {
                throw new ILEmitterException($"Stack should be empty: [{string.Join(", ", _stack)}]");
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
                throw new ILEmitterException($"Stack size does not match to ILGenerator stack. [{string.Join(", ", _stack)}].");
            }
        }

        /// <summary>
        ///     test
        /// </summary>
        /// <param name="types"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Push(params string[] types)
        {
            foreach (var item in types)
            {
                _stack.Push(item);
            }
        }

        /// <summary>
        ///     test
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Pop(params string[] types)
        {
            foreach (var item in types)
            {
                var pop = _stack.Pop();
                if (pop != item)
                {
                    throw new ILEmitterException($"Unexpected type {item} in stack {pop}.");
                }
            }
        }

        ///// <summary>
        /////     Calls the method indicated by the passed method descriptor.
        ///// </summary>
        //public ILEmitter Call(MethodInfo methodInfo)
        //{
        //    Pop(methodInfo.GetParameters().Count());
        //    Push(methodInfo.ReturnType == typeof(void) ? 0 : 1);

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
                VerifyStackIsEmpty();
                return this;
            }

            var expected = _stack.Pop();
            if (expected != _methodBuilder.ReturnType.FullName)
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

            Pop(constructorInfo.GetParameters().Select(x => x.ParameterType.FullName).ToArray());
            _stack.Push(constructorInfo.DeclaringType.FullName); // todo: test

            return this;
        }
    }
}