/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator
{
    public static class Functional
    {
        public static ILEmitterFunc Add(ILEmitterFunc a, ILEmitterFunc b) => il => il.Add(a, b);
        public static ILEmitterFunc AreSame(ILEmitterFunc a, ILEmitterFunc b) => il => il.AreSame(a, b);
        public static ILEmitterFunc BeginExceptionBlock() => il => il.BeginExceptionBlock();
        public static ILEmitterFunc BeginFinallyBlock() => il => il.BeginFinallyBlock();
        public static ILEmitterFunc Box(Type type) => il => il.Box(type);
        public static ILEmitterFunc Box(ILEmitterFunc value, Type type) => il => il.Box(value, type);
        public static ILEmitterFunc Break() => il => il.Break();
        public static ILEmitterFunc Call(MethodInfo methodInfo, params ILEmitterFunc[] parameters) => il => il.Call(methodInfo, parameters);
        public static ILEmitterFunc Call(MethodInfo methodInfo) => il => il.Call(methodInfo);
        public static ILEmitterFunc Call(ConstructorInfo constructor) => il => il.Call(constructor);
        public static ILEmitterFunc Cast(Type type) => il => il.Cast(type);
        public static ILEmitterFunc Cast<T>(ILEmitterFunc value) => il => il.Cast<T>(value);
        public static ILEmitterFunc Constrained(Type type) => il => il.Constrained(type);
        public static ILEmitterFunc EndExceptionBlock() => il => il.EndExceptionBlock();
        public static ILEmitterFunc Execute(params ILEmitterFunc[] actions) => il => il.Execute(actions);
        public static ILEmitterFunc ExecuteIf(bool condition, params ILEmitterFunc[] actions) => il => il.ExecuteIf(condition, actions);
        public static ILEmitterFunc GoTo(Label label) => il => il.GoTo(label);
        public static ILEmitterFunc Greater_S(ILEmitterFunc a, ILEmitterFunc b, Label label) => il => il.Greater_S(a, b, label);
        public static ILEmitterFunc If(ILEmitterFunc action, ILEmitterFunc whenTrue, ILEmitterFunc elseAction) => il => il.If(action, whenTrue, elseAction);
        public static ILEmitterFunc If(ILEmitterFunc action, ILEmitterFunc whenTrue) => il => il.If(action, whenTrue);
        public static ILEmitterFunc If_S(ILEmitterFunc action, ILEmitterFunc whenTrue, ILEmitterFunc elseAction) => il => il.If_S(action, whenTrue, elseAction);
        public static ILEmitterFunc If_S(ILEmitterFunc action, ILEmitterFunc whenTrue) => il => il.If_S(action, whenTrue);
        public static ILEmitterFunc IfFalse(Label label) => il => il.IfFalse(label);
        public static ILEmitterFunc IfFalse_S(Label label) => il => il.IfFalse_S(label);
        public static ILEmitterFunc IfTrue(Label label) => il => il.IfTrue(label);
        public static ILEmitterFunc IfTrue_S(ILEmitterFunc action, Label label) => il => il.IfTrue_S(action, label);
        public static ILEmitterFunc IfTrue_S(Label label) => il => il.IfTrue_S(label);
        public static ILEmitterFunc LessOrEqual_S(ILEmitterFunc a, ILEmitterFunc b, Label label) => il => il.LessOrEqual_S(a, b, label);
        public static ILEmitterFunc LoadAddress(LocalVariableInfo local) => il => il.LoadAddress(local);
        public static ILEmitterFunc LoadArgument(ushort argumentIndex) => il => il.LoadArgument(argumentIndex);
        public static ILEmitterFunc LoadArgumentAddress(ushort argumentIndex) => il => il.LoadArgumentAddress(argumentIndex);
        public static ILEmitterFunc LoadCaller(LocalVariableInfo local) => il => il.LoadCaller(local);
        public static ILEmitterFunc LoadField(FieldInfo field) => il => il.LoadField(field);
        public static ILEmitterFunc LoadFieldAddress(FieldInfo field) => il => il.LoadFieldAddress(field);
        public static ILEmitterFunc LoadInteger(int value) => il => il.LoadInteger(value);
        public static ILEmitterFunc LoadLocal(LocalVariableInfo local) => il => il.LoadLocal(local);
        public static ILEmitterFunc LoadLocal(int localIndex) => il => il.LoadLocal(localIndex);
        public static ILEmitterFunc LoadLong(long value) => il => il.LoadLong(value);
        public static ILEmitterFunc LoadNull() => il => il.LoadNull();
        public static ILEmitterFunc LoadString(string value) => il => il.LoadString(value);
        public static ILEmitterFunc MarkLabel(Label label) => il => il.MarkLabel(label);
        public static ILEmitterFunc New(ConstructorInfo constructor, params ILEmitterFunc[] parameters) => il => il.New(constructor, parameters);
        public static ILEmitterFunc Nop() => il => il.Nop();
        public static ILEmitterFunc Not() => il => il.Not();
        public static ILEmitterFunc Or(ILEmitterFunc a, ILEmitterFunc b) => il => il.Or(a, b);
        public static ILEmitterFunc Pop() => il => il.Pop();
        public static ILEmitterFunc Return() => il => il.Return();
        public static ILEmitterFunc Return(ILEmitterFunc action) => il => il.Return(action);
        public static ILEmitterFunc Return(int value) => il => il.Return(value);
        public static ILEmitterFunc Return(LocalBuilder local) => il => il.Return(local);
        public static ILEmitterFunc SetField(ILEmitterFunc loadObject, ILEmitterFunc loadValue, FieldInfo field) => il => il.SetField(loadObject, loadValue, field);
        public static ILEmitterFunc ShiftLeft(ILEmitterFunc value, ILEmitterFunc numberOfBits) => il => il.ShiftLeft(value, numberOfBits);
        public static ILEmitterFunc Store(LocalBuilder local) => il => il.Store(local);
        public static ILEmitterFunc Sub(ILEmitterFunc a, ILEmitterFunc b) => il => il.Sub(a, b);
        public static ILEmitterFunc Throw(ILEmitterFunc exception) => il => il.Throw(exception);
        public static ILEmitterFunc Xor(ILEmitterFunc a, ILEmitterFunc b) => il => il.Xor(a, b);
    }
}
