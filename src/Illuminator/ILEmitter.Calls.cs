using System;
using System.Reflection;
using System.Reflection.Emit;
using Illuminator.Exceptions;

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        /// <summary>
        ///     Calls the method indicated by the passed method descriptor.
        /// </summary>
        public ILEmitter Call(MethodInfo methodInfo)
        {
            _il.Emit(OpCodes.Call, methodInfo);

            if (!methodInfo.IsStatic) {
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

            if (methodInfo.IsStatic) {
                throw new IlluminatorException(
                    $"Can't make virtual call on the static method {methodInfo.DeclaringType.FullName}.{methodInfo.Name}");
            }

            Pop(methodInfo.DeclaringType);
            Pop(methodInfo.GetParameters());
            Push(methodInfo.ReturnType);

            return this;
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
    }
}
