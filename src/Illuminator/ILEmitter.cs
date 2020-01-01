using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Illuminator.Extensions;

namespace Illuminator
{
    public sealed partial class ILEmitter : IDisposable
    {
        private const byte ShortFormLimit = byte.MaxValue; // 255

        private readonly Dictionary<Type, int> _counter = new Dictionary<Type, int>();
        private readonly ILGenerator _il;
        private readonly Dictionary<Type, List<LocalBuilder>> _locals = new Dictionary<Type, List<LocalBuilder>>();
        private readonly Stack<Scope> _scopes = new Stack<Scope>();

        public ILEmitter(ILGenerator il) {
            _il = il;
            LocalsScope();
        }

        public void Dispose() {
            _scopes.Pop();
            DebugOutput();
        }

        public ILEmitter Emit(OpCode opCode) {
            DebugLine($"\t\t{opCode}");
            _il.Emit(opCode);

            return this;
        }

        public ILEmitter Emit(OpCode opCode, int arg) {
            DebugLine($"\t\t{opCode} {arg}");
            _il.Emit(opCode, arg);

            return this;
        }

        public ILEmitter DefineLabel(out Label label) {
            label = _il.DefineLabel();
            AddDebugLabel(label);

            return this;
        }

        public ILEmitter MarkLabel(Label label) {
            DebugMarkLabel(label);
            _il.MarkLabel(label);

            return this;
        }

        public ILEmitter Emit(OpCode opCode, Label label) {
            DebugEmitLabel(opCode, label);
            _il.Emit(opCode, label);

            return this;
        }

        public ILEmitter Emit(OpCode opCode, MethodInfo methodInfo) {
            DebugLine($"\t\t{opCode} {methodInfo.DisplayName()}");
            _il.Emit(opCode, methodInfo);

            return this;
        }

        public ILEmitter Emit(OpCode opCode, FieldInfo field) {
            DebugLine($"\t\t{opCode} {field.DisplayName()}");
            _il.Emit(opCode, field);

            return this;
        }

        public ILEmitter Emit(OpCode opCode, ConstructorInfo constructorInfo) {
            DebugLine($"\t\t{opCode} {constructorInfo.DisplayName()}");
            _il.Emit(opCode, constructorInfo);

            return this;
        }

        //public ILEmitter BeginFinallyBlock()
        //{
        //    DebugLine("\t.finally");
        //    _il.BeginFinallyBlock();

        //    return this;
        //}

        //public ILEmitter BeginExceptionBlock()
        //{
        //    DebugLine("\t.try {");
        //    _il.BeginExceptionBlock();

        //    return this;
        //}

        //public ILEmitter EndExceptionBlock()
        //{
        //    DebugLine("\t} // .try");
        //    _il.EndExceptionBlock();

        //    return this;
        //}

        public ILEmitter Call(MethodInfo methodInfo) {
            var owner = methodInfo.DeclaringType;
            if (owner == null) {
                throw new InvalidOperationException(
                    $"It's not expected that {methodInfo.DisplayName()} doesn't have a declaring type.");
            }

            var opCode = methodInfo.IsStatic || owner.IsValueType || owner.IsSealed
                             ? OpCodes.Call
                             : OpCodes.Callvirt;

            return Emit(opCode, methodInfo);
        }

        public ILEmitter Return() => Emit(OpCodes.Ret);

        public ILEmitter Return(int value) => LoadConstant(value).Return();

        public ILEmitter EmitCast(Type objectType) {
            var castOp = objectType.IsValueType
                             ? OpCodes.Unbox_Any
                             : OpCodes.Castclass;

            DebugLine($"\t\t{castOp} {objectType.DisplayName()}");
            _il.Emit(castOp, objectType);

            return this;
        }

        public ILEmitter Branch(OpCode opCode, Label label) {
            if (opCode.FlowControl != FlowControl.Branch
                && opCode.FlowControl != FlowControl.Cond_Branch) {
                throw new ArgumentOutOfRangeException(nameof(opCode),
                    $"Only a branch instruction is allowed. OpCode: {opCode}.");
            }

            return Emit(opCode, label);
        }

        public ILEmitter Branch(OpCode opCode, out Label label) {
            if (opCode.FlowControl != FlowControl.Branch
                && opCode.FlowControl != FlowControl.Cond_Branch) {
                throw new ArgumentOutOfRangeException(nameof(opCode),
                    $"Only a branch instruction is allowed. OpCode: {opCode}.");
            }

            return DefineLabel(out label).Emit(opCode, label);
        }

        public ILEmitter LoadArgument(ushort argumentIndex) {
            switch (argumentIndex) {
                case 0: return Emit(OpCodes.Ldarg_0);
                case 1: return Emit(OpCodes.Ldarg_1);
                case 2: return Emit(OpCodes.Ldarg_2);
                case 3: return Emit(OpCodes.Ldarg_3);
                default:
                    var opCode = argumentIndex <= ShortFormLimit ? OpCodes.Ldarg_S : OpCodes.Ldarg;
                    return Emit(opCode, argumentIndex);
            }
        }

        public ILEmitter LoadArgumentAddress(ushort argumentIndex) {
            var opCode = argumentIndex <= ShortFormLimit ? OpCodes.Ldarga_S : OpCodes.Ldarga;
            return Emit(opCode, argumentIndex);
        }

        public ILEmitter LoadConstant(int value) {
            switch (value) {
                case -1: return Emit(OpCodes.Ldc_I4_M1);
                case 0: return Emit(OpCodes.Ldc_I4_0);
                case 1: return Emit(OpCodes.Ldc_I4_1);
                case 2: return Emit(OpCodes.Ldc_I4_2);
                case 3: return Emit(OpCodes.Ldc_I4_3);
                case 4: return Emit(OpCodes.Ldc_I4_4);
                case 5: return Emit(OpCodes.Ldc_I4_5);
                case 6: return Emit(OpCodes.Ldc_I4_6);
                case 7: return Emit(OpCodes.Ldc_I4_7);
                case 8: return Emit(OpCodes.Ldc_I4_8);
                default:
                    var opCode = value <= ShortFormLimit ? OpCodes.Ldc_I4_S : OpCodes.Ldc_I4;
                    return Emit(opCode, value);
            }
        }

        public ILEmitter LoadLocal(LocalVariableInfo local) => LoadLocal(local.LocalIndex);

        public ILEmitter LoadLocal(int localIndex) {
            switch (localIndex) {
                case 0: return Emit(OpCodes.Ldloc_0);
                case 1: return Emit(OpCodes.Ldloc_1);
                case 2: return Emit(OpCodes.Ldloc_2);
                case 3: return Emit(OpCodes.Ldloc_3);
                default:
                    var opCode = localIndex <= ShortFormLimit ? OpCodes.Ldloc_S : OpCodes.Ldloc;
                    return Emit(opCode, localIndex);
            }
        }

        public ILEmitter LoadString(string value) {
            DebugLine($"\t\t{OpCodes.Ldstr} \"{value}\"");
            _il.Emit(OpCodes.Ldstr, value);

            return this;
        }

        public ILEmitter LoadAddress(LocalVariableInfo local) {
            var localIndex = local.LocalIndex;
            var opCode = localIndex <= ShortFormLimit ? OpCodes.Ldloca_S : OpCodes.Ldloca;

            DebugLine($"\t\t{opCode} {localIndex}");
            _il.Emit(opCode, localIndex);

            return this;
        }

        public ILEmitter Store(LocalBuilder local) {
            switch (local.LocalIndex) {
                case 0: return Emit(OpCodes.Stloc_0);
                case 1: return Emit(OpCodes.Stloc_1);
                case 2: return Emit(OpCodes.Stloc_2);
                case 3: return Emit(OpCodes.Stloc_3);

                default:
                    var opCode = local.LocalIndex <= ShortFormLimit ? OpCodes.Stloc_S : OpCodes.Stloc;
                    DebugLine($"\t\t{opCode} {local.LocalIndex}");
                    _il.Emit(opCode, local);
                    return this;
            }
        }

        public ILEmitter Store(Type localType, out LocalBuilder local) {
            var scope = _scopes.Peek();
            local = scope.ResolveLocal(localType);

            return Store(local);
        }

        public IDisposable LocalsScope() {
            var scope = new Scope(this);
            _scopes.Push(scope);

            return scope;
        }

        private class Scope : IDisposable
        {
            private readonly ILEmitter _owner;
            private readonly Dictionary<Type, int> _state;

            public Scope(ILEmitter owner) {
                _owner = owner;
                _state = _owner._counter.ToDictionary(x => x.Key, x => x.Value);
            }

            public void Dispose() {
                foreach (var type in new List<Type>(_owner._counter.Keys)) {
                    _owner._counter[type] = _state.TryGetValue(type, out var count) ? count : 0;
                }

                _owner._scopes.Pop();
            }

            public LocalBuilder ResolveLocal(Type type) {
                if (!_owner._locals.TryGetValue(type, out var list)) {
                    _owner._locals[type] = list = new List<LocalBuilder>();
                }

                if (!_owner._counter.TryGetValue(type, out var count)) {
                    count = 0;
                }

                _owner._counter[type] = count + 1;

                if (list.Count != count) {
                    return list[count];
                }

                var local = _owner._il.DeclareLocal(type);
                list.Add(local);

                return local;
            }
        }

        #region DEBUG

        // ReSharper disable PartialMethodWithSinglePart

        partial void DebugOutput();
        partial void DebugEmitLabel(OpCode opCode, Label label);
        partial void DebugMarkLabel(Label label);
        partial void DebugLine(string message);
        partial void AddDebugLabel(Label label);

        // ReSharper restore PartialMethodWithSinglePart

#if DEBUG

        public ILEmitter DebugWriteLine(LocalBuilder local) {
            DebugLine($"\t\tWrite local: {local.LocalIndex}");
            _il.Emit(OpCodes.Ldloca, local);
            if (local.LocalType != null && local.LocalType != typeof(string)) {
                _il.Emit(OpCodes.Callvirt, local.LocalType.GetMethod(nameof(ToString), Type.EmptyTypes));
            }

            _il.Emit(OpCodes.Call, typeof(Debug).GetMethod(nameof(Debug.WriteLine), new[] { typeof(string) }));

            return this;
        }

        public ILEmitter DebugWriteLine(string message) {
            DebugLine($"\t\tWrite: {message}");
            _il.Emit(OpCodes.Ldstr, message);
            _il.Emit(OpCodes.Call, typeof(Debug).GetMethod(nameof(Debug.WriteLine), new[] { typeof(string) }));

            return this;
        }

#endif

        #endregion
    }
}
