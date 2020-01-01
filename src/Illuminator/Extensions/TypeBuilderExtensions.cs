using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator.Extensions
{
    public static class TypeBuilderExtensions
    {
        public static MethodBuilder DefineInterfaceMethod(
            this TypeBuilder typeBuilder,
            MethodInfo interfaceMethod)
        {
            var method = typeBuilder.DefineMethod(
                interfaceMethod.Name,
                MethodAttributes.Public | MethodAttributes.Virtual,
                CallingConventions.HasThis,
                interfaceMethod.ReturnType,
                interfaceMethod.GetParameters().Select(x => x.ParameterType).ToArray()
            );

            typeBuilder.DefineMethodOverride(method, interfaceMethod);

            return method;
        }

        public static MethodBuilder DefineStaticMethod(
            this TypeBuilder staticTypeBuilder,
            string name,
            Type returnType,
            Type[] parameterTypes) =>
            staticTypeBuilder.DefineMethod(
                name,
                MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.Final,
                CallingConventions.Standard,
                returnType,
                parameterTypes);
    }
}
