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
        public static Action<ILEmitter> Execute(Func<ILEmitter, ILEmitter> action) => il => action(il);
        public static Action<ILEmitter> MarkLabel(Label label) => il => il.MarkLabel(label);
        public static Action<ILEmitter> Call(MethodInfo methodInfo, params Action<ILEmitter>[] parameters) => il => il.Call(methodInfo, parameters);
        public static Action<ILEmitter> Call(MethodInfo methodInfo) => il => il.Call(methodInfo);
        public static Action<ILEmitter> Return(Action<ILEmitter> action) => il => il.Return(action);
        public static Action<ILEmitter> Return(int value) => il => il.Return(value);
        public static Action<ILEmitter> Cast(Type objectType) => il => il.Cast(objectType);
        public static Action<ILEmitter> LoadArgument(ushort argumentIndex) => il => il.LoadArgument(argumentIndex);
        public static Action<ILEmitter> LoadArgumentAddress(ushort argumentIndex) => il => il.LoadArgumentAddress(argumentIndex);
        public static Action<ILEmitter> LoadLong(long value) => il => il.LoadLong(value);
        public static Action<ILEmitter> LoadInteger(int value) => il => il.LoadInteger(value);
        public static Action<ILEmitter> LoadLocal(LocalVariableInfo local) => il => il.LoadLocal(local);
        public static Action<ILEmitter> LoadLocal(int localIndex) => il => il.LoadLocal(localIndex);
        public static Action<ILEmitter> LoadString(string value) => il => il.LoadString(value);
        public static Action<ILEmitter> LoadAddress(LocalVariableInfo local) => il => il.LoadAddress(local);
        public static Action<ILEmitter> Store(LocalBuilder local) => il => il.Store(local);
        public static Action<ILEmitter> SetField(Action<ILEmitter> loadObject, Action<ILEmitter> loadValue, FieldInfo field) => il => il.SetField(loadObject, loadValue, field);
        public static Action<ILEmitter> LoadField(FieldInfo field) => il => il.LoadField(field);
        public static Action<ILEmitter> LoadFieldAddress(FieldInfo field) => il => il.LoadFieldAddress(field);
        public static Action<ILEmitter> New(ConstructorInfo constructor) => il => il.New(constructor);
        public static Action<ILEmitter> Call(ConstructorInfo constructor) => il => il.Call(constructor);
        public static Action<ILEmitter> AreSame(Action<ILEmitter> a, Action<ILEmitter> b) => il => il.AreSame(a, b);
        public static Action<ILEmitter> ShiftLeft(Action<ILEmitter> value, Action<ILEmitter> numberOfBits) => il => il.ShiftLeft(value, numberOfBits);
        public static Action<ILEmitter> Or(Action<ILEmitter> a, Action<ILEmitter> b) => il => il.Or(a, b);
        public static Action<ILEmitter> Xor(Action<ILEmitter> a, Action<ILEmitter> b) => il => il.Xor(a, b);
        public static Action<ILEmitter> Sub(Action<ILEmitter> a, Action<ILEmitter> b) => il => il.Sub(a, b);
        public static Action<ILEmitter> Add(Action<ILEmitter> a, Action<ILEmitter> b) => il => il.Add(a, b);
        public static Action<ILEmitter> GoTo(Label label) => il => il.GoTo(label);
        public static Action<ILEmitter> Greater(Action<ILEmitter> a, Action<ILEmitter> b, Label label) => il => il.Greater(a, b, label);
        public static Action<ILEmitter> LessOrEqual(Action<ILEmitter> a, Action<ILEmitter> b, Label label) => il => il.LessOrEqual(a, b, label);
        public static Action<ILEmitter> IfTrue(Label label) => il => il.IfTrue(label);
        public static Action<ILEmitter> IfFalse_S(Label label) => il => il.IfFalse_S(label);
        public static Action<ILEmitter> IfFalse(Label label) => il => il.IfFalse(label);
    }
}
