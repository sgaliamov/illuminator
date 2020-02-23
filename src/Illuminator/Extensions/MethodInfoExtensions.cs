using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator.Extensions
{
    public static class MethodInfoExtensions
    {
        public static TDelegate CreateDelegate<TDelegate>(this MethodInfo methodInfo)
            where TDelegate : Delegate =>
            (TDelegate)methodInfo.CreateDelegate(typeof(TDelegate));

        public static string GetMethodInfoName(this MethodInfo methodInfo)
        {
            var parameters = methodInfo is MethodBuilder
                ? "..."
                : string.Join(", ", methodInfo.GetParameters().Select(x => x.ParameterType.Name));

            return $"{methodInfo.DeclaringType?.Name}::{methodInfo.Name}({parameters}): {methodInfo.ReturnType.Name}";
        }
    }
}
