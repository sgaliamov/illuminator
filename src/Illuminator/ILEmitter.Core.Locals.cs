using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        private readonly Dictionary<Type, int> _counter = new();
        private readonly Dictionary<Type, List<LocalBuilder>> _locals = new();
        private readonly Stack<Scope> _scopes = new();

        public IDisposable LocalsScope()
        {
            var scope = new Scope(this);
            _scopes.Push(scope);

            return scope;
        }

        private sealed class Scope : IDisposable
        {
            private readonly ILEmitter _owner;
            private readonly Dictionary<Type, int> _state;

            public Scope(ILEmitter owner)
            {
                _owner = owner;
                _state = _owner._counter.ToDictionary(x => x.Key, x => x.Value);
            }

            public void Dispose()
            {
                foreach (var type in new List<Type>(_owner._counter.Keys)) {
                    _owner._counter[type] = _state.TryGetValue(type, out var count) ? count : 0;
                }

                _owner._scopes.Pop();
            }

            //public LocalBuilder ResolveLocal(Type type)
            //{
            //    if (!_owner._locals.TryGetValue(type, out var list)) {
            //        _owner._locals[type] = list = new List<LocalBuilder>();
            //    }

            //    if (!_owner._counter.TryGetValue(type, out var count)) {
            //        count = 0;
            //    }

            //    _owner._counter[type] = count + 1;

            //    if (list.Count != count) {
            //        return list[count];
            //    }

            //    var local = _owner.DeclareLocal(type);
            //    list.Add(local);

            //    return local;
            //}
        }
    }
}