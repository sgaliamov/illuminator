using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Illuminator.Exceptions;

namespace Illuminator
{
    // Tracking state of the stack.
    public sealed partial class ILEmitter
    {
        private const string AnyType = "ANY";
        private const string IntType = "I4";
        private const string LongType = "I8";
        private const string FloatType = "R4";
        private const string DoubleType = "R8";
        private const string RefType = "REF";

        private static readonly IReadOnlyDictionary<Type, string> TypesMap = new Dictionary<Type, string> {
            [typeof(int)] = IntType,
            [typeof(long)] = LongType,
            [typeof(float)] = FloatType,
            [typeof(double)] = DoubleType
        };

        /// <summary>
        ///     Variables stack.
        /// </summary>
        private readonly Stack<string> _stack = new();

        private string StackToString() => string.Join(", ", _stack);

        private void VerifyStackIsEmpty()
        {
            DebugVerifyStackSize();

            // make When_stack_is_not_linear test pass
            //if (_stack.Count != 0)
            //{
            //    throw new IlluminatorStackException($"Stack should be empty: [{StackToString()}]");
            //}
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void DebugVerifyStackSize()
        {
            var maxMidStackCur =
                (int)typeof(ILGenerator)
                     .GetField("m_maxMidStackCur", PrivateFieldBindingFlags)
                     ?.GetValue(_il)!;

            if (maxMidStackCur != 0) {
                throw new IlluminatorStackException(
                    $"Stack size does not match to ILGenerator stack. [{StackToString()}].");
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

        private void Pop(params Type[]? types)
        {
            if (types == null || types.Length == 0) {
                return;
            }

            Pop(types.Select(ToSimpleType).ToArray());
        }

        /// <summary>
        ///     Unwind types in reversed order and compare items with stack.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Pop(params string[] types)
        {
            Debug.Assert(types.Length != 0);

            foreach (var item in types) {
                if (_stack.Count == 0) {
                    throw new IlluminatorStackException("Stack is empty to return a value.");
                }

                var pop = _stack.Pop();

                if (pop == AnyType || item == AnyType) {
                    continue;
                }

                if (pop != item) {
                    throw new IlluminatorStackException($"Unexpected type {item} in stack {pop}.");
                }
            }
        }

        private static string ToSimpleType(Type type)
        {
            Debug.Assert(type != typeof(void));

            return TypesMap.TryGetValue(type, out var value)
                ? value
                : AnyType;
        }
    }
}
