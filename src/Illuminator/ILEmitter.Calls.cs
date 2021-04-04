using System;
using System.Linq;
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
        public ILEmitter EmitCall(
            in OpCode opcode,
            in MethodInfo methodInfo,
            in Type[]? parameterTypes = null,
            in Type[]? optionalParameterTypes = null)
        {
            Pop(optionalParameterTypes?.Reverse().ToArray());
            Pop(parameterTypes?.Reverse().ToArray());

            if (!methodInfo.IsStatic) {
                Pop(methodInfo.DeclaringType!);
            }

            // op code is not calculated because it will change API and sometimes you may want to call a virtual method with Call code.
            _il.EmitCall(opcode, methodInfo, optionalParameterTypes);
            _logger?.Log(nameof(EmitCall), opcode, methodInfo, parameterTypes, optionalParameterTypes);

            Push(methodInfo.ReturnType);

            return this;
        }

        /// <summary>
        ///     Calls the method indicated on the evaluation stack (as a pointer to an entry point) with arguments described by a
        ///     calling convention.
        /// </summary>
        public ILEmitter EmitCalli(
            in CallingConventions callingConventions,
            in Type? returnType = null,
            in Type[]? parameterTypes = null,
            in Type[]? optionalParameterTypes = null)
        {
            Pop(IntType); // func pointer
            Pop(optionalParameterTypes?.Reverse().ToArray());
            Pop(parameterTypes?.Reverse().ToArray());

            if (callingConventions.HasFlag(CallingConventions.HasThis)) {
                Pop(AnyType);
            }

            _il.EmitCalli(OpCodes.Calli, callingConventions, returnType, parameterTypes, optionalParameterTypes);
            _logger?.Log(nameof(EmitCalli), callingConventions, returnType, parameterTypes, optionalParameterTypes);

            if (returnType != null) {
                Push(returnType);
            }

            return this;
        }

        /// <summary>
        ///     Calls the method indicated by the passed method descriptor.
        /// </summary>
        public ILEmitter Call(in MethodInfo methodInfo, params Type[]? parameterTypes)
        {
            Pop(parameterTypes?.Reverse().ToArray());

            if (!methodInfo.IsStatic) {
                Pop(methodInfo.DeclaringType!);
            }

            _il.Emit(OpCodes.Call, methodInfo);
            _logger?.Log(nameof(Call), methodInfo, parameterTypes);

            Push(methodInfo.ReturnType);

            return this;
        }

        /// <summary>
        ///     Calls the method indicated by the passed constructor descriptor.
        /// </summary>
        public ILEmitter Call(in ConstructorInfo constructorInfo, params Type[]? parameterTypes)
        {
            Pop(parameterTypes?.Reverse().ToArray());

            if (!constructorInfo.IsStatic) {
                Pop(constructorInfo.DeclaringType!);
            }

            _il.Emit(OpCodes.Call, constructorInfo);
            _logger?.Log(nameof(Call), constructorInfo, parameterTypes);

            return this;
        }

        /// <summary>Calls a late-bound method on an object, pushing the return value onto the evaluation stack.</summary>
        public ILEmitter Callvirt(in MethodInfo methodInfo, params Type[]? parameterTypes)
        {
            if (methodInfo.IsStatic) {
                throw new IlluminatorException(
                    $"Can't make virtual call on the static method {methodInfo.DeclaringType!.FullName}.{methodInfo.Name}");
            }

            Pop(parameterTypes?.Reverse().ToArray());
            Pop(methodInfo.DeclaringType!);

            _il.Emit(OpCodes.Callvirt, methodInfo);
            _logger?.Log(nameof(Callvirt), methodInfo, parameterTypes);

            Push(methodInfo.ReturnType);

            return this;
        }

        /// <summary>
        ///     Creates a new object or a new instance of a value type, pushing an object reference (type O) onto the
        ///     evaluation stack.
        /// </summary>
        public ILEmitter Newobj(in ConstructorInfo constructorInfo, params Type[]? parameterTypes)
        {
            if (constructorInfo.IsStatic) {
                throw new NotSupportedException("Static constructors are not supported.");
            }

            Pop(parameterTypes?.Reverse().ToArray());

            _il.Emit(OpCodes.Newobj, constructorInfo);
            _logger?.Log(nameof(Newobj), constructorInfo, parameterTypes);

            Push(constructorInfo.DeclaringType!);

            return this;
        }

        /// <summary>
        ///     Returns from the current method, pushing a return value (if present) from the callee's evaluation stack onto the
        ///     caller's evaluation stack.
        /// </summary>
        public ILEmitter Ret()
        {
            _il.Emit(OpCodes.Ret);
            _logger?.Log(nameof(Ret));

            if (_methodBuilder.ReturnType == typeof(void)) {
                VerifyStackIsEmpty();
                return this;
            }

            Pop(_methodBuilder.ReturnType);

            return this;
        }
    }
}
