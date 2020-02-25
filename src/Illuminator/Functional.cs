using System;
using System.Reflection;

namespace Illuminator
{
    // todo: generate all methods
    public static class Functional
    {
        public static ILEmitterAction Or(Action<ILEmitter> a, Action<ILEmitter> b) => new ILEmitterAction((ILEmitter il) => il.Or(a, b));

        public static ILEmitterAction AreSame(Action<ILEmitter> a, Action<ILEmitter> b) => new ILEmitterAction((ILEmitter il) => il.AreSame(a, b));

        public static ILEmitterAction LoadInteger(int value) => new ILEmitterAction((ILEmitter il) => il.LoadInteger(value));

        public static ILEmitterAction LoadArgument(ushort argumentIndex) => new ILEmitterAction((ILEmitter il) => il.LoadArgument(argumentIndex));

        public static ILEmitterAction Call(MethodInfo methodInfo) => new ILEmitterAction((ILEmitter il) => il.Call(methodInfo));
    }
}
