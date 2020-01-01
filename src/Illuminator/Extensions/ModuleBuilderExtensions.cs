using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator.Extensions
{
    internal static class ModuleBuilderExtensions
    {
        public static TypeBuilder DefineType(
            this ModuleBuilder moduleBuilder,
            string name,
            params Type[] interfaceTypes) {
            var type = moduleBuilder.DefineType(name, TypeAttributes.Sealed | TypeAttributes.Public);
            if (interfaceTypes == null) {
                return type;
            }

            foreach (var interfaceType in interfaceTypes) {
                type.AddInterfaceImplementation(interfaceType);
            }

            return type;
        }
    }
}
