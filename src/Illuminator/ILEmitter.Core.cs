using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator
{
    // todo: interface at the end
    // Manual wrappers over ILGenerator methods that cannot be generated, inducing calls.
    public sealed partial class ILEmitter
    {
        private const BindingFlags PrivateFieldBindingFlags = BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance;
        private readonly ILGenerator _il;
        private readonly MethodInfo _methodBuilder;

        public ILEmitter(ILGenerator il)
        {
            _il = il ?? throw new ArgumentNullException(nameof(il));
            _methodBuilder = (MethodInfo)typeof(ILGenerator)
                                         .GetField("m_methodBuilder", PrivateFieldBindingFlags)
                                         .GetValue(_il);
        }

        /// <summary>
        ///     Puts a call or callvirt instruction onto the Microsoft intermediate language
        ///     (MSIL) stream to call a varargs method.
        /// </summary>
        public ILEmitter EmitCall(OpCode opcode, MethodInfo methodInfo, Type[]? optionalParameterTypes = null)
        {
            // op code is not calculated because it will change API and sometimes you may want to call a virtual method with Call code.
            _il.EmitCall(opcode, methodInfo, optionalParameterTypes);

            if (!methodInfo.IsStatic) {
                Pop(methodInfo.DeclaringType);
            }

            Pop(methodInfo.GetParameters());
            if (optionalParameterTypes != null) {
                Pop(optionalParameterTypes);
            }

            Push(methodInfo.ReturnType);

            return this;
        }

        /// <summary>
        ///     Calls the method indicated on the evaluation stack (as a pointer to an entry point) with arguments described by a
        ///     calling convention.
        /// </summary>
        public ILEmitter EmitCalli(
            CallingConventions callingConvention,
            Type? returnType = null,
            Type[]? parameterTypes = null,
            Type[]? optionalParameterTypes = null)
        {
            // todo: test
            _il.EmitCalli(OpCodes.Calli, callingConvention, returnType, parameterTypes, optionalParameterTypes);

            return this;
        }

        /// <summary>Creates a delegate of type <typeparamref name="T" /> from this method.</summary>
        /// <typeparam name="T">The type of the delegate to create.</typeparam>
        /// <returns>The delegate for this method.</returns>
        public T CreateDelegate<T>() where T : Delegate
        {
            VerifyStackIsEmpty();

            return (T)_methodBuilder.CreateDelegate(typeof(T));
        }
    }
}
