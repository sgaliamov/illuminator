using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator
{
    // Manual wrappers over ILGenerator methods that cannot be generated, inducing calls.
    public sealed partial class ILEmitter : IDisposable
    {
        private const BindingFlags PrivateFieldBindingFlags = BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance;
        private readonly ILGenerator _il;
        private readonly MethodInfo _methodBuilder;
        private readonly TraceLogger? _logger;

        public ILEmitter(in ILGenerator il, bool enableTraceLogger = false)
        {
            _il = il ?? throw new ArgumentNullException(nameof(il));

            _methodBuilder =
                (MethodInfo)typeof(ILGenerator)
                            .GetField("m_methodBuilder", PrivateFieldBindingFlags)
                            ?.GetValue(_il)!;

            _logger = enableTraceLogger ? new TraceLogger(this) : null;

            _globalScope = LocalsScope();
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
            _il.EmitCalli(OpCodes.Calli, callingConventions, returnType, parameterTypes, optionalParameterTypes);
            _logger?.Log(OpCodes.Calli, callingConventions, returnType, parameterTypes, optionalParameterTypes);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EmitCall(OpCode, MethodInfo, Type[])" />.
        /// </summary>
        public ILEmitter EmitCall(in OpCode opcode, in MethodInfo methodInfo, in Type[]? optionalParameterTypes = null)
        {
            _il.EmitCall(opcode, methodInfo, optionalParameterTypes);
            _logger?.Log(nameof(EmitCall), opcode, methodInfo, optionalParameterTypes);

            return this;
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
            Dispose();

            return (T)_methodBuilder.CreateDelegate(typeof(T));
        }

        public int GetStackSize() =>
            (int)typeof(ILGenerator)
                 .GetField("m_maxMidStackCur", PrivateFieldBindingFlags)
                 ?.GetValue(_il)!;

        public void Dispose()
        {
            _logger?.Flush();
            CloseScopes();
        }
    }
}
