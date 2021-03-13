using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

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

        ///// <summary>
        /////     Calls a late-bound method on an object, pushing the return value onto the evaluation stack.
        ///// </summary>
        //public ILEmitter Callvirt(MethodInfo methodInfo)
        //{
        //    _il.Emit(OpCodes.Callvirt, methodInfo);

        //    Pop(methodInfo.GetParameters());
        //    Push(methodInfo.ReturnType);

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

            Type[] types = { _methodBuilder.ReturnType };
            Pop(types.Select(ToSimpleType).ToArray());

            return this;
        }

        /// <summary>
        ///     Creates a new object or a new instance of a value type, pushing an object reference (type O) onto the evaluation
        ///     stack.
        /// </summary>
        public ILEmitter Newobj(ConstructorInfo constructorInfo)
        {
            _il.Emit(OpCodes.Newobj, constructorInfo);

            Pop(constructorInfo.GetParameters());
            Push(constructorInfo.DeclaringType);

            return this;
        }

        public T CreateDelegate<T>() where T : Delegate => (T)_methodBuilder.CreateDelegate(typeof(T));
    }
}