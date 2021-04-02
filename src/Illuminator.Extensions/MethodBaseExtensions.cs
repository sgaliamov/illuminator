using System;
using System.Linq;
using System.Reflection;

namespace Illuminator.Extensions
{
    public static class MethodBaseExtensions
    {
        public static Type[] GetParameterTypes(this MethodBase self) =>
            self.GetParameters().Select(x => x.ParameterType).ToArray();
    }
}
