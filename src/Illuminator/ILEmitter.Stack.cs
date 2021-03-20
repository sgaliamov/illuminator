using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Illuminator.Exceptions;

namespace Illuminator
{
    public sealed partial class ILEmitter : IDisposable
    {
        private readonly Stack<string> _stack = new Stack<string>();

        public void Dispose()
        {
            DebugVerifyStackSize();
            VerifyStackIsEmpty();
        }

        private void VerifyStackIsEmpty()
        {
            if (_stack.Count != 0) {
                throw new IlluminatorStackException($"Stack should be empty: [{string.Join(", ", _stack)}]");
            }
        }

        [Conditional("DEBUG")]
        private void DebugVerifyStackSize()
        {
            var maxMidStackCur = (int)typeof(ILGenerator)
                .GetField("m_maxMidStackCur", PrivateFieldBindingFlags)
                .GetValue(_il);

            if (_stack.Count != maxMidStackCur) {
                throw new IlluminatorStackException($"Stack size does not match to ILGenerator stack. [{string.Join(", ", _stack)}].");
            }
        }

        /// <summary>
        ///     Ignores Void type
        /// </summary>
        private void Push(Type type)
        {
            if (type == typeof(void)) {
                return;
            }

            Push(ToSimpleType(type));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Push(params string[] types)
        {
            Debug.Assert(types.Length != 0);

            foreach (var item in types) {
                _stack.Push(item);
            }
        }

        private void Pop(params ParameterInfo[] types)
        {
            if (types.Length == 0) {
                return;
            }

            Pop(types.Select(x => x.ParameterType).ToArray());
        }

        private void Pop(params Type[] types) => Pop(types.Select(ToSimpleType).ToArray());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Pop(params string[] types)
        {
            Debug.Assert(types.Length != 0);

            if (_stack.Count == 0) {
                throw new IlluminatorStackException("Stack is empty to return a value.");
            }

            foreach (var item in types) {
                var pop = _stack.Pop();
                if (pop != item && pop != "any" && item != "any") {
                    // todo: test
                    throw new IlluminatorStackException($"Unexpected type {item} in stack {pop}.");
                }
            }
        }

        private static string ToSimpleType(Type type)
        {
            Debug.Assert(type != typeof(void));

            if (type == typeof(int)) {
                return "int";
            }

            if (type == typeof(long)) {
                return "long";
            }

            if (type == typeof(double)) {
                return "double";
            }

            if (type == typeof(float)) {
                return "float";
            }

            // todo: smart types check
            return "any";
        }
    }
}
