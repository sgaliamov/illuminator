﻿using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator
{
    // todo: interface at the end
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
