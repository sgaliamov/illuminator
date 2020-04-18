using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Illuminator.Extensions;
#if DEBUG
using System.Diagnostics;
#endif

namespace Illuminator
{
    public sealed partial class ILEmitter : IDisposable
    {
        private const byte ShortFormLimit = byte.MaxValue; // 255
        private readonly Dictionary<Type, int> _counter = new Dictionary<Type, int>();
        private readonly ILGenerator _il;
        private readonly Dictionary<Type, List<LocalBuilder>> _locals = new Dictionary<Type, List<LocalBuilder>>();
        private readonly Stack<Scope> _scopes = new Stack<Scope>();

        // todo: 3. pass method definition to checks on loading arguments
        public ILEmitter(ILGenerator il)
        {
            _il = il;
            LocalsScope();
        }

        public void Dispose()
        {
            _scopes.Pop();
            DebugFinish();
        }

        public ILEmitter DefineLabel(out Label label)
        {
            label = _il.DefineLabel();
            AddDebugLabel(label);

            return this;
        }

        //public ILEmitter Block(Action<ILEmitter, Label> between)
        //{
        //    var blockEnd = _il.DefineLabel();

        //    AddDebugLabel(blockEnd);

        //    between(this, blockEnd);

        //    return MarkLabel(blockEnd);
        //}

        public ILEmitter MarkLabel(Label label)
        {
            DebugMarkLabel(label);
            _il.MarkLabel(label);

            return this;
        }

        public ILEmitter BeginFinallyBlock()
        {
            _il.BeginFinallyBlock();
            DebugLine("\t.finally");

            return this;
        }

        public ILEmitter BeginExceptionBlock()
        {
            _il.BeginExceptionBlock();
            DebugLine("\t.try {");

            return this;
        }

        public ILEmitter EndExceptionBlock()
        {
            _il.EndExceptionBlock();
            DebugLine("\t} // .try");

            return this;
        }

        public ILEmitter Break() => Emit(OpCodes.Break);

        public ILEmitter Constrained(Type type) => Emit(OpCodes.Constrained, type);

        public ILEmitter Call(MethodInfo methodInfo, params Func<ILEmitter, ILEmitter>[] parameters)
        {
            if (!(methodInfo is MethodBuilder)) {
                var methodParametesLenght = methodInfo.GetParameters().Length;

                if ((methodInfo.IsStatic && methodParametesLenght != parameters.Length)
                    || (!methodInfo.IsStatic && methodParametesLenght != parameters.Length - 1)) {
                    throw new ArgumentException($"Amount of parameters does not match method {methodInfo} signature.");
                }
            }

            foreach (var parameter in parameters) {
                parameter(this);
            }

            return Call(methodInfo);
        }

        public ILEmitter Call(MethodInfo methodInfo)
        {
            var owner = methodInfo.DeclaringType;
            if (owner == typeof(ValueType)) {
                owner = methodInfo.ReflectedType; // todo: 0. test
            }

            if (owner == null) {
                throw new InvalidOperationException(
                    $"It's not expected that {methodInfo.DisplayName()} doesn't have a declaring type.");
            }

            if (methodInfo.IsGenericMethodDefinition) {
                throw new InvalidOperationException(
                    $"Generic method {methodInfo.DisplayName()} is not initialized.");
            }

            // if the method belongs to Enum type, them it should be called as virtual and with constrained prefix
            // https://docs.microsoft.com/en-us/dotnet/api/system.reflection.emit.opcodes.constrained
            //var isEnum = owner.IsAssignableFrom(typeof(Enum));
            var opCode = methodInfo.IsStatic || owner.IsValueType || owner.IsSealed || !methodInfo.IsVirtual // todo: 0. test
                ? OpCodes.Call
                : OpCodes.Callvirt;

            //if (isEnum) {
            //    Constrained(owner); // todo: 0. test
            //}

            return Emit(opCode, methodInfo);
        }

        public ILEmitter Return() => Emit(OpCodes.Ret);

        public ILEmitter Return(Func<ILEmitter, ILEmitter> action) => action(this).Emit(OpCodes.Ret);

        public ILEmitter Return(int value) => LoadInteger(value).Return();

        public ILEmitter Return(LocalBuilder local) => LoadLocal(local).Return();

        // todo: 3. test
        public ILEmitter Cast(Type objectType) => Type.GetTypeCode(objectType) switch
        {
            TypeCode.Int64 => Emit(OpCodes.Conv_I8),
            TypeCode.Int32 => Emit(OpCodes.Conv_I4),
            _ => Emit(objectType.IsValueType
                ? OpCodes.Unbox_Any
                : OpCodes.Castclass, objectType)
        };

        public ILEmitter LoadArgument(ushort argumentIndex)
        {
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

        public ILEmitter LoadArgumentAddress(ushort argumentIndex)
        {
            var opCode = argumentIndex <= ShortFormLimit ? OpCodes.Ldarga_S : OpCodes.Ldarga;
            return Emit(opCode, argumentIndex);
        }

        public ILEmitter LoadLong(long value) => Emit(OpCodes.Ldc_I8, value);

        public ILEmitter LoadInteger(int value)
        {
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

        public ILEmitter LoadLocal(int localIndex)
        {
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

        public ILEmitter LoadString(string value) => Emit(OpCodes.Ldstr, value);

        public ILEmitter LoadAddress(LocalVariableInfo local)
        {
            var localIndex = local.LocalIndex;
            var opCode = localIndex <= ShortFormLimit ? OpCodes.Ldloca_S : OpCodes.Ldloca;

            return Emit(opCode, localIndex);
        }

        public ILEmitter Store(LocalBuilder local)
        {
            switch (local.LocalIndex) {
                case 0: return Emit(OpCodes.Stloc_0);
                case 1: return Emit(OpCodes.Stloc_1);
                case 2: return Emit(OpCodes.Stloc_2);
                case 3: return Emit(OpCodes.Stloc_3);

                default:
                    var opCode = local.LocalIndex <= ShortFormLimit ? OpCodes.Stloc_S : OpCodes.Stloc;
                    return Emit(opCode, local);
            }
        }

        public ILEmitter Store(Type localType, out LocalBuilder local)
        {
            var scope = _scopes.Peek();
            local = scope.ResolveLocal(localType);

            return Store(local);
        }

        public IDisposable LocalsScope()
        {
            var scope = new Scope(this);
            _scopes.Push(scope);

            return scope;
        }

        public ILEmitter SetField(Func<ILEmitter, ILEmitter> loadObject, Func<ILEmitter, ILEmitter> loadValue, FieldInfo field)
        {
            loadObject(this);
            loadValue(this);

            return Emit(OpCodes.Stfld, field);
        }

        public ILEmitter LoadField(FieldInfo field) => Emit(OpCodes.Ldfld, field);

        public ILEmitter LoadFieldAddress(FieldInfo field) => Emit(OpCodes.Ldflda, field);

        public ILEmitter New(ConstructorInfo constructor) => Emit(OpCodes.Newobj, constructor);

        // todo: 3. helper to generate constructors
        public ILEmitter Call(ConstructorInfo constructor) => Emit(OpCodes.Call, constructor);

        public ILEmitter LoadNull() => Emit(OpCodes.Ldnull);

        public ILEmitter Not() => Emit(OpCodes.Not);

        public ILEmitter AreSame(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b)
        {
            // todo: 3. verify stack and types of variables
            a(this);
            b(this);

            return Emit(OpCodes.Ceq);
        }

        public ILEmitter AreSame(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b, out LocalBuilder local) => AreSame(a, b).Store(typeof(int), out local);

        public ILEmitter ShiftLeft(Func<ILEmitter, ILEmitter> value, Func<ILEmitter, ILEmitter> numberOfBits)
        {
            // todo: 3. verify stack and types of variables
            value(this);
            numberOfBits(this);

            return Emit(OpCodes.Shl);
        }

        public ILEmitter Or(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b)
        {
            // todo: 3. verify stack and types of variables
            a(this);
            b(this);

            return Emit(OpCodes.Or);
        }

        public ILEmitter Xor(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b)
        {
            // todo: 3. verify stack and types of variables
            a(this);
            b(this);

            return Emit(OpCodes.Xor);
        }

        public ILEmitter Sub(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b)
        {
            // todo: 3. verify stack and types of variables
            a(this);
            b(this);

            return Emit(OpCodes.Sub);
        }

        public ILEmitter Add(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b)
        {
            // todo: 3. verify stack and types of variables
            a(this);
            b(this);

            return Emit(OpCodes.Add);
        }

        public ILEmitter Throw() => Emit(OpCodes.Throw);

        public ILEmitter GoTo(Label label) => Branch(OpCodes.Br, label);

        public ILEmitter GoTo(out Label label) => DefineLabel(out label).Branch(OpCodes.Br_S, label);

        public ILEmitter Greater(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b, Label label)
        {
            a(this);
            b(this);

            return Branch(OpCodes.Bgt_S, label);
        }

        public ILEmitter LessOrEqual(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b, Label label)
        {
            a(this);
            b(this);

            return Branch(OpCodes.Ble_S, label);
        }

        public ILEmitter IfTrue_S(Func<ILEmitter, ILEmitter> action, out Label label)
        {
            action(this);
            return IfTrue_S(out label);
        }

        public ILEmitter IfTrue_S(out Label label) => Branch(OpCodes.Brtrue_S, out label);

        public ILEmitter IfTrue(Label label) => Branch(OpCodes.Brtrue, label);

        // todo: 1. smart branching?
        public ILEmitter IfFalse_S(Func<ILEmitter, ILEmitter> action, out Label label)
        {
            action(this);
            return IfFalse_S(out label);
        }

        public ILEmitter IfFalse_S(out Label label) => Branch(OpCodes.Brfalse_S, out label);

        public ILEmitter IfFalse_S(Label label) => Branch(OpCodes.Brfalse_S, label);

        public ILEmitter IfFalse(out Label label) => Branch(OpCodes.Brfalse, out label);

        public ILEmitter IfFalse(Label label) => Branch(OpCodes.Brfalse, label);

        public ILEmitter IfNotEqual_Un_S(out Label label) => Branch(OpCodes.Bne_Un_S, out label);

        public ILEmitter IfNotEqual_Un_S(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b, out Label label)
        {
            a(this);
            b(this);

            return IfNotEqual_Un_S(out label);
        }

        public ILEmitter Execute(params Func<ILEmitter, ILEmitter>[] actions)
        {
            foreach (var action in actions) {
                action(this);
            }

            return this;
        }

        private ILEmitter Branch(OpCode opCode, Label label)
        {
            if (opCode.FlowControl != FlowControl.Branch
                && opCode.FlowControl != FlowControl.Cond_Branch) {
                throw new InvalidOperationException(
                    $"Only a branch instruction is allowed. OpCode: {opCode}.");
            }

            return Emit(opCode, label);
        }

        private ILEmitter Branch(OpCode opCode, out Label label)
        {
            if (opCode.FlowControl != FlowControl.Branch
                && opCode.FlowControl != FlowControl.Cond_Branch) {
                throw new InvalidOperationException(
                    $"Only a branch instruction is allowed. OpCode: {opCode}.");
            }

            return DefineLabel(out label).Emit(opCode, label);
        }

        private ILEmitter Emit(OpCode opCode, LocalBuilder local)
        {
            _il.Emit(opCode, local);
            DebugLine($"\t\t{opCode} {local.LocalIndex}");

            return this;
        }

        private ILEmitter Emit(OpCode opCode, string str)
        {
            _il.Emit(opCode, str);
            DebugLine($"\t\t{opCode} \"{str}\"");

            return this;
        }

        private ILEmitter Emit(OpCode opCode, Type type)
        {
            _il.Emit(opCode, type);
            DebugLine($"\t\t{opCode} {type.DisplayName()}");

            return this;
        }

        private ILEmitter Emit(OpCode opCode)
        {
            _il.Emit(opCode);
            DebugLine($"\t\t{opCode}");

            return this;
        }

        private ILEmitter Emit(OpCode opCode, int arg)
        {
            _il.Emit(opCode, arg);
            DebugLine($"\t\t{opCode} {arg}");

            return this;
        }

        private ILEmitter Emit(OpCode opCode, long arg)
        {
            _il.Emit(opCode, arg);
            DebugLine($"\t\t{opCode} {arg}");

            return this;
        }

        private ILEmitter Emit(OpCode opCode, Label label)
        {
            _il.Emit(opCode, label);
            DebugEmitLabel(opCode, label);

            return this;
        }

        private ILEmitter Emit(OpCode opCode, MethodInfo methodInfo)
        {
            if (!new[] { OpCodes.Call, OpCodes.Calli, OpCodes.Callvirt }.Contains(opCode)) {
                throw new InvalidOperationException($"Expected a call operation but {opCode} is used.");
            }

            _il.Emit(opCode, methodInfo);
            DebugLine($"\t\t{opCode} {methodInfo.GetMethodInfoName()}");

            return this;
        }

        private ILEmitter Emit(OpCode opCode, FieldInfo field)
        {
            _il.Emit(opCode, field);
            DebugLine($"\t\t{opCode} {field.DisplayName()}");

            return this;
        }

        private ILEmitter Emit(OpCode opCode, ConstructorInfo constructor)
        {
            _il.Emit(opCode, constructor);
            DebugLine($"\t\t{opCode} {constructor.DisplayName()}");

            return this;
        }

        internal sealed class Scope : IDisposable
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

            public LocalBuilder ResolveLocal(Type type)
            {
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

        partial void DebugFinish();
        partial void DebugEmitLabel(OpCode opCode, Label label);
        partial void DebugMarkLabel(Label label);
        partial void DebugLine(string message);
        partial void AddDebugLabel(Label label);

#if DEBUG

        /// <summary>
        ///     Emit <see cref="Debug.WriteLine(object)" />.
        /// </summary>
        /// <param name="local">Value to write.</param>
        public ILEmitter DebugWriteLine(LocalBuilder local)
        {
            if (local.LocalType.IsValueType) {
                LoadAddress(local);
            } else {
                LoadLocal(local);
            }

            if (local.LocalType != null && local.LocalType != typeof(string)) {
                Call(local.LocalType.GetMethod(nameof(ToString), Type.EmptyTypes));
            }

            var methodInfo = typeof(Debug).GetMethod(nameof(Debug.WriteLine), new[] { typeof(string) });
            Call(methodInfo);

            DebugLine($"\t\tWrite local: {local.LocalIndex}");
            return this;
        }

        /// <summary>
        ///     Emit <see cref="Debug.WriteLine(string)" />.
        /// </summary>
        /// <param name="message">String to write.</param>
        public ILEmitter DebugWriteLine(string message)
        {
            _il.Emit(OpCodes.Ldstr, message);
            _il.Emit(OpCodes.Call, typeof(Debug).GetMethod(nameof(Debug.WriteLine), new[] { typeof(string) }));

            DebugLine($"\t\tWrite: {message}");
            return this;
        }

#endif

        #endregion
    }
}
