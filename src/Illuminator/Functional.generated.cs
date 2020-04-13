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
        public static Func<ILEmitter, ILEmitter> MarkLabel(Label label) => il => il.MarkLabel(label);
        public static Func<ILEmitter, ILEmitter> Call(MethodInfo methodInfo, params Func<ILEmitter, ILEmitter>[] parameters) => il => il.Call(methodInfo, parameters);
        public static Func<ILEmitter, ILEmitter> Call(MethodInfo methodInfo) => il => il.Call(methodInfo);
        public static Func<ILEmitter, ILEmitter> Return(Func<ILEmitter, ILEmitter> action) => il => il.Return(action);
        public static Func<ILEmitter, ILEmitter> Return(int value) => il => il.Return(value);
        public static Func<ILEmitter, ILEmitter> Cast(Type objectType) => il => il.Cast(objectType);
        public static Func<ILEmitter, ILEmitter> LoadArgument(ushort argumentIndex) => il => il.LoadArgument(argumentIndex);
        public static Func<ILEmitter, ILEmitter> LoadArgumentAddress(ushort argumentIndex) => il => il.LoadArgumentAddress(argumentIndex);
        public static Func<ILEmitter, ILEmitter> LoadLong(long value) => il => il.LoadLong(value);
        public static Func<ILEmitter, ILEmitter> LoadInteger(int value) => il => il.LoadInteger(value);
        public static Func<ILEmitter, ILEmitter> LoadLocal(LocalVariableInfo local) => il => il.LoadLocal(local);
        public static Func<ILEmitter, ILEmitter> LoadLocal(int localIndex) => il => il.LoadLocal(localIndex);
        public static Func<ILEmitter, ILEmitter> LoadString(string value) => il => il.LoadString(value);
        public static Func<ILEmitter, ILEmitter> LoadAddress(LocalVariableInfo local) => il => il.LoadAddress(local);
        public static Func<ILEmitter, ILEmitter> Store(LocalBuilder local) => il => il.Store(local);
        public static Func<ILEmitter, ILEmitter> SetField(Func<ILEmitter, ILEmitter> loadObject, Func<ILEmitter, ILEmitter> loadValue, FieldInfo field) => il => il.SetField(loadObject, loadValue, field);
        public static Func<ILEmitter, ILEmitter> LoadField(FieldInfo field) => il => il.LoadField(field);
        public static Func<ILEmitter, ILEmitter> LoadFieldAddress(FieldInfo field) => il => il.LoadFieldAddress(field);
        public static Func<ILEmitter, ILEmitter> New(ConstructorInfo constructor) => il => il.New(constructor);
        public static Func<ILEmitter, ILEmitter> Call(ConstructorInfo constructor) => il => il.Call(constructor);
        public static Func<ILEmitter, ILEmitter> AreSame(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b) => il => il.AreSame(a, b);
        public static Func<ILEmitter, ILEmitter> ShiftLeft(Func<ILEmitter, ILEmitter> value, Func<ILEmitter, ILEmitter> numberOfBits) => il => il.ShiftLeft(value, numberOfBits);
        public static Func<ILEmitter, ILEmitter> Or(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b) => il => il.Or(a, b);
        public static Func<ILEmitter, ILEmitter> Xor(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b) => il => il.Xor(a, b);
        public static Func<ILEmitter, ILEmitter> Sub(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b) => il => il.Sub(a, b);
        public static Func<ILEmitter, ILEmitter> Add(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b) => il => il.Add(a, b);
        public static Func<ILEmitter, ILEmitter> GoTo(Label label) => il => il.GoTo(label);
        public static Func<ILEmitter, ILEmitter> Greater(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b, Label label) => il => il.Greater(a, b, label);
        public static Func<ILEmitter, ILEmitter> LessOrEqual(Func<ILEmitter, ILEmitter> a, Func<ILEmitter, ILEmitter> b, Label label) => il => il.LessOrEqual(a, b, label);
        public static Func<ILEmitter, ILEmitter> IfTrue(Label label) => il => il.IfTrue(label);
        public static Func<ILEmitter, ILEmitter> IfFalse_S(Label label) => il => il.IfFalse_S(label);
        public static Func<ILEmitter, ILEmitter> IfFalse(Label label) => il => il.IfFalse(label);
        public static Func<ILEmitter, ILEmitter> Execute(Func<ILEmitter, ILEmitter> action) => il => il.Execute(action);
    }
}
