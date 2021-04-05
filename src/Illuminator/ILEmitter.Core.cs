using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Illuminator.Logger;

namespace Illuminator
{
    // Manual wrappers over ILGenerator methods that cannot be generated, inducing calls.
    public sealed partial class ILEmitter : IDisposable
    {
        private const BindingFlags PrivateFieldBindingFlags = BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance;
        private readonly ILGenerator _il;
        private readonly ILogger? _logger;
        private readonly MethodInfo _methodBuilder;

        public ILEmitter(in ILGenerator il, ILogger? logger = null)
        {
            _il = il ?? throw new ArgumentNullException(nameof(il));
            _logger = logger;
            _methodBuilder =
                (MethodInfo)typeof(ILGenerator).GetField("m_methodBuilder", PrivateFieldBindingFlags)!.GetValue(_il);

            LocalsScope();
        }

        /// <summary>
        ///     Runs emit functions sequentially.
        /// </summary>
        public ILEmitter Emit(params ILEmitterFunc[] funcs) => funcs.Aggregate(this, (il, func) => func(il));

        /// <summary>Creates a delegate of type <typeparamref name="T" /> from this method.</summary>
        /// <typeparam name="T">The type of the delegate to create.</typeparam>
        /// <returns>The delegate for this method.</returns>
        public T CreateDelegate<T>() where T : Delegate
        {
            VerifyStackIsEmpty();

            return (T)_methodBuilder.CreateDelegate(typeof(T));
        }
        
        public void Dispose()
        {
            _scopes.Pop();
            VerifyStackIsEmpty();
        }
    }
}
