using System;
using System.Reflection;

namespace Illuminator.Tests
{
    internal static class NetCoreApp3
    {
        public static T CreateDelegate<T>(this MethodInfo self) where T : Delegate =>
            (T)self.CreateDelegate(typeof(T));
    }
}
