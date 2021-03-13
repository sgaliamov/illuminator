using System.Reflection;

namespace Illuminator.Tests
{
    public sealed class TestClass
    {
        private int _a;

        public TestClass(int a, out int b)
        {
            _a = a;
            b = _a + 1;
        }

        public int Foo(int a, out int b)
        {
            _a += a;
            b = _a + 1;

            return _a + b;
        }

        public static float Foo(float v) => v;

        public static double Foo(double v) => v;

        public static long Foo(long v) => v;

        public static MethodInfo FloatFooMethodInfo =>
            typeof(TestClass).GetMethod("Foo", new[] { typeof(float) })!;
    }
}