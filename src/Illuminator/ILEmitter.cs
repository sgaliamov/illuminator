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
            _methodBuilder = (MethodInfo)typeof(ILGenerator)
                .GetField("m_methodBuilder", PrivateFieldBindingFlags)
                .GetValue(_il);
        }

        public void Dispose()
        {
            VerifyStackSize();
            VerifyStackIsEmpty();
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
                VerifyStackIsEmpty(); // todo: test fail
                return this;
            }

            Pop(_methodBuilder.ReturnType);

            return this;
        }

        /// <summary>
        ///     Creates a new object or a new instance of a value type, pushing an object reference (type O) onto the evaluation
        ///     stack.
        /// </summary>
        public ILEmitter Newobj(ConstructorInfo constructorInfo)
        {
            _il.Emit(OpCodes.Newobj, constructorInfo);

            Pop(constructorInfo.GetParameters().Select(x => x.ParameterType).ToArray());
            Push(constructorInfo.DeclaringType);

            return this;
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
            var maxMidStackCur = (int)typeof(ILGenerator)
                .GetField("m_maxMidStackCur", PrivateFieldBindingFlags)
                .GetValue(_il);

            if (_stack.Count != maxMidStackCur)
            {
                throw new ILEmitterException($"Stack size does not match to ILGenerator stack. [{string.Join(", ", _stack)}].");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Push(params Type[] types) => Push(types.Select(ToSimpleType).ToArray());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Push(params string[] types)
        {
            Debug.Assert(types.Length != 0);

            foreach (var item in types)
            {
                _stack.Push(item);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Pop(params Type[] types) => Pop(types.Select(ToSimpleType).ToArray());

        /// <summary>
        ///     test
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Pop(params string[] types)
        {
            Debug.Assert(types.Length != 0);

            if (_stack.Count == 0)
            {
                throw new ILEmitterException("Stack is empty to return a value.");
            }

            foreach (var item in types)
            {
                var pop = _stack.Pop();
                if (pop != item && pop != "any" && item != "any")
                {
                    // todo: test
                    throw new ILEmitterException($"Unexpected type {item} in stack {pop}.");
                }
            }
        }

        private static string ToSimpleType(Type type)
        {
            // todo: smart types check
            if (type == typeof(int))
            {
                return "int";
            }

            if (type == typeof(long))
            {
                // todo: test
                return "long";
            }

            if (type == typeof(double))
            {
                // todo: test
                return "double";
            }

            if (type == typeof(float))
            {
                // todo: test
                return "float";
            }

            return "any";
        }
    }
}