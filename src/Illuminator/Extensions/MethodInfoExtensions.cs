using System;
using System.Linq;
using System.Reflection;

namespace Illuminator.Extensions
{
    public static class MethodInfoExtensions
    {
        public static TDelegate CreateDelegate<TDelegate>(this MethodInfo methodInfo)
            where TDelegate : Delegate =>
            (TDelegate)methodInfo.CreateDelegate(typeof(TDelegate));

        public static string GetMethodInfoName(this MethodInfo methodInfo)
        {
            var parameters = string.Join(", ", methodInfo.GetParameters().Select(x => x.ParameterType.Name));

            return $"{methodInfo.DeclaringType?.Name}::{methodInfo.Name}({parameters}): {methodInfo.ReturnType.Name}";
        }
    }
}
