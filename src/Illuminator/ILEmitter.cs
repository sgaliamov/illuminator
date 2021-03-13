using System;
using System.Reflection;
using System.Reflection.Emit;
using Illuminator.Exceptions;

namespace Illuminator
{
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
        ///     Calls the method indicated by the passed method descriptor.
        /// </summary>
        public ILEmitter Call(MethodInfo methodInfo)
        {
            _il.Emit(OpCodes.Call, methodInfo);

            if (!methodInfo.IsStatic)
            {
                Pop(methodInfo.DeclaringType);
            }

            Pop(methodInfo.GetParameters());
            Push(methodInfo.ReturnType);

            return this;
        }

        /// <summary>Calls a late-bound method on an object, pushing the return value onto the evaluation stack.</summary>
        public ILEmitter Callvirt(MethodInfo methodInfo)
        {
            _il.Emit(OpCodes.Callvirt, methodInfo);

            if (methodInfo.IsStatic)
            {
                throw new IlluminatorException(
                    $"Can't make virtual call on the static method {methodInfo.DeclaringType.FullName}.{methodInfo.Name}");
            }

            Pop(methodInfo.DeclaringType);
            Pop(methodInfo.GetParameters());
            Push(methodInfo.ReturnType);

            return this;
        }

        /// <summary>
        ///     Calls the method indicated on the evaluation stack (as a pointer to an entry point) with arguments described by a
        ///     calling convention.
        /// </summary>
        private ILEmitter EmitCalli(
            CallingConventions callingConvention,
            Type? returnType,
            Type[]? parameterTypes,
            Type[]? optionalParameterTypes)
        {
            // todo: test
            _il.EmitCalli(OpCodes.Calli, callingConvention, returnType, parameterTypes, optionalParameterTypes);

            return this;
        }

        /// <summary>
        ///     Puts a call or callvirt instruction onto the Microsoft intermediate language
        ///     (MSIL) stream to call a varargs method.
        /// </summary>
        private ILEmitter EmitCall(OpCode opcode, MethodInfo methodInfo, Type[]? optionalParameterTypes)
        {
            // todo: test with var args
            _il.EmitCall(opcode, methodInfo, optionalParameterTypes);

            if (!methodInfo.IsStatic)
            {
                Pop(methodInfo.DeclaringType);
            }

            Pop(methodInfo.GetParameters());
            if (optionalParameterTypes != null)
            {
                Pop(optionalParameterTypes);
            }

            Push(methodInfo.ReturnType);

            return this;
        }

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

            Pop(_methodBuilder.ReturnType);

            return this;
        }

        /// <summary>
        ///     Creates a new object or a new instance of a value type, pushing an object reference (type O) onto the
        ///     evaluation stack.
        /// </summary>
        public ILEmitter Newobj(ConstructorInfo constructorInfo)
        {
            _il.Emit(OpCodes.Newobj, constructorInfo);

            Pop(constructorInfo.GetParameters());
            Push(constructorInfo.DeclaringType);

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