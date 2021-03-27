using System.Reflection;

namespace Illuminator
{
    // Extensions for call methods with ILEmitterFunc parameters.
    public static partial class FunExtensions
    {
        public static ILEmitter Call(this ILEmitter self, MethodInfo methodInfo, params ILEmitterFunc[] parameters)
        {
            // todo: think where to move it
            //if (!(methodInfo is MethodBuilder)) {
            //    var methodParametesLenght = methodInfo.GetParameters().Length;

            //    if ((methodInfo.IsStatic && methodParametesLenght != parameters.Length)
            //        || (!methodInfo.IsStatic && methodParametesLenght != parameters.Length - 1)) {
            //        throw new ArgumentException($"Amount of parameters does not match method {methodInfo} signature.");
            //    }
            //}

            foreach (var parameter in parameters) {
                parameter(self);
            }

            return self.Call(methodInfo);
        }

        public static ILEmitter Newobj(this ILEmitter self, ConstructorInfo constructorInfo, params ILEmitterFunc[] parameters)
        {
            foreach (var parameter in parameters) {
                parameter(self);
            }

            return self.Newobj(constructorInfo);
        }
    }
}
