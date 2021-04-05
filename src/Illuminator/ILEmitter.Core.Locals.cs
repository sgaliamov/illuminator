using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using Illuminator.Exceptions;

namespace Illuminator
{
    // Reusing locals.
    public sealed partial class ILEmitter
    {
        /// <summary>
        ///     Counter for used types in the current scope.
        /// </summary>
        private readonly Dictionary<Type, int> _counter = new();

        /// <summary>
        ///     List of all created locals associated with a type.
        /// </summary>
        private readonly Dictionary<Type, List<LocalBuilder>> _locals = new();

        /// <summary>
        ///     Stack of scopes.
        /// </summary>
        private readonly Stack<Scope> _scopes = new();

        /// <summary>
        ///     Global scope.
        /// </summary>
        private readonly IDisposable _globalScope;

        /// <summary>
        ///     Start locals scope.
        /// </summary>
        public IDisposable LocalsScope()
        {
            var scope = new Scope(this);
            _scopes.Push(scope);

            return scope;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.DeclareLocal(Type)" />.
        /// </summary>
        public ILEmitter DeclareLocal(in Type localType, out LocalBuilder output)
        {
            output = DeclareLocal(localType, false);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.DeclareLocal(Type, bool)" />.
        /// </summary>
        public ILEmitter DeclareLocal(in Type localType, in bool pinned, out LocalBuilder output)
        {
            output = DeclareLocal(localType, pinned);

            return this;
        }

        /// <summary>
        ///     Releases global scope and check that the scopes stack is empty.
        /// </summary>
        private void CloseScopes()
        {
            _globalScope.Dispose();

            if (_scopes.Count != 0) {
                throw new IlluminatorScopeException("Misused locals scopes.");
            }
        }

        /// <summary>
        ///     Resolves local for type from current scope.
        /// </summary>
        private LocalBuilder DeclareLocal(Type localType, in bool pinned)
        {
            var list = EnsureLocalsList(localType);
            var index = GetCurrentIndex(localType);

            _counter[localType] = index + 1;

            if (list.Count != index) {
                // returns a previously allocated local if current index is not exceed amount of available locals.
                return list[index];
            }

            var local = _il.DeclareLocal(localType, pinned);
            list.Add(local);

            _logger?.Log(nameof(DeclareLocal), localType, pinned);

            return local;
        }

        private int GetCurrentIndex(Type localType)
        {
            if (!_counter.TryGetValue(localType, out var index)) {
                index = 0;
            }

            return index;
        }

        private List<LocalBuilder> EnsureLocalsList(Type localType)
        {
            if (!_locals.TryGetValue(localType, out var list)) {
                _locals[localType] = list = new List<LocalBuilder>();
            }

            return list;
        }

        /// <summary>
        ///     Controls stack of a scope.
        ///     On dispose it restores previous state for types counter.
        /// </summary>
        private sealed class Scope : IDisposable
        {
            /// <summary>
            ///     Initial state of the scope.
            /// </summary>
            private readonly Dictionary<Type, int> _state;

            /// <summary>
            ///     Owners types counter.
            /// </summary>
            private readonly Dictionary<Type, int> _counter;

            /// <summary>
            ///     Owners scope.
            /// </summary>
            private readonly Stack<Scope> _scopes;

            public Scope(ILEmitter owner)
            {
                _counter = owner._counter;
                _scopes = owner._scopes;
                _state = _counter.ToDictionary(x => x.Key, x => x.Value);
            }

            /// <summary>
            ///     Clean the scope and pop it from the stack.
            /// </summary>
            public void Dispose()
            {
                if (_scopes.Count == 0) {
                    return;
                }

                foreach (var type in _counter.Keys) {
                    _counter[type] = _state.TryGetValue(type, out var count) ? count : 0;
                }

                _scopes.Pop();
            }
        }
    }
}
