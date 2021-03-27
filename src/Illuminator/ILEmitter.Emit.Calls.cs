using System.Reflection;
using System.Reflection.Emit;
using Illuminator.Exceptions;

namespace Illuminator
{
    // Calls op codes.
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

        /// <summary>
        ///     Calls the method indicated by the passed constructor descriptor.
        /// </summary>
        public ILEmitter Call(ConstructorInfo constructorInfo)
        {
            // todo: test. why would anyone call a constructor as a method? base constructor?
            if (!constructorInfo.IsStatic) {
                // todo: can constructor be static?
                _il.Emit(OpCodes.Call, constructorInfo);
            }

            Pop(constructorInfo.GetParameters());
            // todo: test
            Push(constructorInfo.DeclaringType);

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

        /// <summary>
        ///     Returns from the current method, pushing a return value (if present) from the callee's evaluation stack onto the
        ///     caller's evaluation stack.
        /// </summary>
        public ILEmitter Ret()
        {
            _il.Emit(OpCodes.Ret);

            if (_methodBuilder.ReturnType == typeof(void)) {
                VerifyStackIsEmpty();
                return this;
            }

            Pop(_methodBuilder.ReturnType);

            return this;
        }
    }
}
