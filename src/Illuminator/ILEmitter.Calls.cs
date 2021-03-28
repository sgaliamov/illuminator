using System;
using System.Reflection;
using System.Reflection.Emit;
using Illuminator.Exceptions;

namespace Illuminator
{
    // Calls op codes.
    public sealed partial class ILEmitter
    {
        /// <summary>
        ///     Puts a call or callvirt instruction onto the Microsoft intermediate language
        ///     (MSIL) stream to call a varargs method.
        /// </summary>
        public ILEmitter EmitCall(OpCode opcode, MethodInfo methodInfo, Type[]? optionalParameterTypes = null)
        {
            if (!methodInfo.IsStatic) {
                Pop(methodInfo.DeclaringType);
            }

            Pop(methodInfo.GetParameters());
            if (optionalParameterTypes != null) {
                Pop(optionalParameterTypes);
            }

            // op code is not calculated because it will change API and sometimes you may want to call a virtual method with Call code.
            _il.EmitCall(opcode, methodInfo, optionalParameterTypes);

            Push(methodInfo.ReturnType);

            return this;
        }

        /// <summary>
        ///     Calls the method indicated on the evaluation stack (as a pointer to an entry point) with arguments described by a
        ///     calling convention.
        /// </summary>
        public ILEmitter EmitCalli(
            CallingConventions callingConventions,
            Type? returnType = null,
            Type[]? parameterTypes = null,
            Type[]? optionalParameterTypes = null)
        {
            Pop(AnyType);

            if (callingConventions.HasFlag(CallingConventions.HasThis)) {
                Pop(AnyType);
            }

            if (parameterTypes != null) {
                Pop(parameterTypes);
            }

            if (optionalParameterTypes != null) {
                Pop(optionalParameterTypes);
            }

            _il.EmitCalli(OpCodes.Calli, callingConventions, returnType, parameterTypes, optionalParameterTypes);

            if (returnType != null) {
                Push(returnType);
            }

            return this;
        }

        /// <summary>
        ///     Calls the method indicated by the passed method descriptor.
        /// </summary>
        public ILEmitter Call(MethodInfo methodInfo)
        {
            if (!methodInfo.IsStatic) {
                Pop(methodInfo.DeclaringType);
            }

            Pop(methodInfo.GetParameters());

            _il.Emit(OpCodes.Call, methodInfo);

            Push(methodInfo.ReturnType);

            return this;
        }

        /// <summary>
        ///     Calls the method indicated by the passed constructor descriptor.
        /// </summary>
        public ILEmitter Call(ConstructorInfo constructorInfo)
        {
            // todo: test. why would anyone call a constructor as a method? base constructor?
            if (!constructorInfo.IsStatic) {
                // todo: can constructor be static?
                Pop(constructorInfo.DeclaringType);
            }

            Pop(constructorInfo.GetParameters());

            _il.Emit(OpCodes.Call, constructorInfo);

            // todo: test
            Push(constructorInfo.DeclaringType);

            return this;
        }

        /// <summary>Calls a late-bound method on an object, pushing the return value onto the evaluation stack.</summary>
        public ILEmitter Callvirt(MethodInfo methodInfo)
        {
            if (methodInfo.IsStatic) {
                throw new IlluminatorException(
                    $"Can't make virtual call on the static method {methodInfo.DeclaringType.FullName}.{methodInfo.Name}");
            }

            Pop(methodInfo.DeclaringType);
            Pop(methodInfo.GetParameters());

            _il.Emit(OpCodes.Callvirt, methodInfo);

            Push(methodInfo.ReturnType);

            return this;
        }

        /// <summary>
        ///     Creates a new object or a new instance of a value type, pushing an object reference (type O) onto the
        ///     evaluation stack.
        /// </summary>
        public ILEmitter Newobj(ConstructorInfo constructorInfo)
        {
            Pop(constructorInfo.GetParameters());

            _il.Emit(OpCodes.Newobj, constructorInfo);

            Push(constructorInfo.DeclaringType);

            return this;
        }

        /// <summary>
        ///     Returns from the current method, pushing a return value (if present) from the callee's evaluation stack onto the
        ///     caller's evaluation stack.
        /// </summary>
        public ILEmitter Ret()
        {
            if (_methodBuilder.ReturnType == typeof(void)) {
                VerifyStackIsEmpty();
                return this;
            }

            Pop(_methodBuilder.ReturnType);

            _il.Emit(OpCodes.Ret);

            return this;
        }
    }
}
