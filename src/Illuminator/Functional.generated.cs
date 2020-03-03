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
        public static ILEmitterAction MarkLabel(Label label) => new ILEmitterAction((ILEmitter il) => il.MarkLabel(label));
        public static ILEmitterAction BeginFinallyBlock() => new ILEmitterAction((ILEmitter il) => il.BeginFinallyBlock());
        public static ILEmitterAction BeginExceptionBlock() => new ILEmitterAction((ILEmitter il) => il.BeginExceptionBlock());
        public static ILEmitterAction EndExceptionBlock() => new ILEmitterAction((ILEmitter il) => il.EndExceptionBlock());
        public static ILEmitterAction Call(MethodInfo methodInfo) => new ILEmitterAction((ILEmitter il) => il.Call(methodInfo));
        public static ILEmitterAction Return() => new ILEmitterAction((ILEmitter il) => il.Return());
        public static ILEmitterAction Return(int value) => new ILEmitterAction((ILEmitter il) => il.Return(value));
        public static ILEmitterAction Cast(Type objectType) => new ILEmitterAction((ILEmitter il) => il.Cast(objectType));
        public static ILEmitterAction LoadArgument(ushort argumentIndex) => new ILEmitterAction((ILEmitter il) => il.LoadArgument(argumentIndex));
        public static ILEmitterAction LoadArgumentAddress(ushort argumentIndex) => new ILEmitterAction((ILEmitter il) => il.LoadArgumentAddress(argumentIndex));
        public static ILEmitterAction LoadInteger(int value) => new ILEmitterAction((ILEmitter il) => il.LoadInteger(value));
        public static ILEmitterAction LoadLocal(LocalVariableInfo local) => new ILEmitterAction((ILEmitter il) => il.LoadLocal(local));
        public static ILEmitterAction LoadLocal(int localIndex) => new ILEmitterAction((ILEmitter il) => il.LoadLocal(localIndex));
        public static ILEmitterAction LoadString(string value) => new ILEmitterAction((ILEmitter il) => il.LoadString(value));
        public static ILEmitterAction LoadAddress(LocalVariableInfo local) => new ILEmitterAction((ILEmitter il) => il.LoadAddress(local));
        public static ILEmitterAction Store(LocalBuilder local) => new ILEmitterAction((ILEmitter il) => il.Store(local));
        public static ILEmitterAction SetField(Action<ILEmitter> loadObject, Action<ILEmitter> loadValue, FieldInfo field) => new ILEmitterAction((ILEmitter il) => il.SetField(loadObject, loadValue, field));
        public static ILEmitterAction LoadField(FieldInfo field) => new ILEmitterAction((ILEmitter il) => il.LoadField(field));
        public static ILEmitterAction LoadFieldAddress(FieldInfo field) => new ILEmitterAction((ILEmitter il) => il.LoadFieldAddress(field));
        public static ILEmitterAction New(ConstructorInfo constructor) => new ILEmitterAction((ILEmitter il) => il.New(constructor));
        public static ILEmitterAction Call(ConstructorInfo constructor) => new ILEmitterAction((ILEmitter il) => il.Call(constructor));
        public static ILEmitterAction LoadNull() => new ILEmitterAction((ILEmitter il) => il.LoadNull());
        public static ILEmitterAction AreSame(Action<ILEmitter> a, Action<ILEmitter> b) => new ILEmitterAction((ILEmitter il) => il.AreSame(a, b));
        public static ILEmitterAction Or(Action<ILEmitter> a, Action<ILEmitter> b) => new ILEmitterAction((ILEmitter il) => il.Or(a, b));
        public static ILEmitterAction Sub(Action<ILEmitter> a, Action<ILEmitter> b) => new ILEmitterAction((ILEmitter il) => il.Sub(a, b));
        public static ILEmitterAction Add(Action<ILEmitter> a, Action<ILEmitter> b) => new ILEmitterAction((ILEmitter il) => il.Add(a, b));
        public static ILEmitterAction Throw() => new ILEmitterAction((ILEmitter il) => il.Throw());
        public static ILEmitterAction GoTo(Label label) => new ILEmitterAction((ILEmitter il) => il.GoTo(label));
        public static ILEmitterAction Greater(Action<ILEmitter> a, Action<ILEmitter> b, Label label) => new ILEmitterAction((ILEmitter il) => il.Greater(a, b, label));
        public static ILEmitterAction LessOrEqual(Action<ILEmitter> a, Action<ILEmitter> b, Label label) => new ILEmitterAction((ILEmitter il) => il.LessOrEqual(a, b, label));
        public static ILEmitterAction Branch(OpCode opCode, Label label) => new ILEmitterAction((ILEmitter il) => il.Branch(opCode, label));
    }
}
