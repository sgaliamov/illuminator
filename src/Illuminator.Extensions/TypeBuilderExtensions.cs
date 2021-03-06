using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator.Extensions
{
    // todo: 3. return wrapper with parameters instead of MethodBuilder
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
    }
}
