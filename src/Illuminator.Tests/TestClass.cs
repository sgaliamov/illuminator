using System;
using System.Reflection;
using System.Text;

namespace Illuminator.Tests
{
    public sealed class TestClass : BaseClass
    {
        public TestClass() { }

        public TestClass(int a, out int b)
        {
            A = a;
            b = A + 1;
        }

        public static ConstructorInfo DefaultCtor =>
            typeof(TestClass).GetConstructor(Type.EmptyTypes)!;

        public static MethodInfo DoubleFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(Foo), new[] { typeof(double) })!;

        public static MethodInfo FloatFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(Foo), new[] { typeof(float) })!;

        public static MethodInfo LongFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(Foo), new[] { typeof(long) })!;

        public static ConstructorInfo ParameterizedCtor =>
            typeof(TestClass).GetConstructor(new[] { typeof(int), typeof(int).MakeByRefType() })!;

        public static MethodInfo VoidFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(Foo), Type.EmptyTypes)!;

        public int A { get; private set; }

        public int Foo(int a, out int b)
        {
            A += a;
            b = A + 1;

            return A + b;
        }

        public static string Foo(object val, __arglist)
        {
            var argumentIterator = new ArgIterator(__arglist);
            var sb = new StringBuilder(val.ToString());
            for (var i = 0; i < argumentIterator.GetRemainingCount(); i++) {
                var o = __refvalue(argumentIterator.GetNextArg(), object);
                sb.Append(o);
            }

            return sb.ToString();
        }

        public static float Foo(float v) => v;

        public static double Foo(double v) => v;

        public static long Foo(long v) => v;

        public override bool Woo() => true;

        public void Foo() => A = 1;
    }

    public abstract class BaseClass
    {
        public static MethodInfo WooMethodInfo =>
            typeof(BaseClass).GetMethod(nameof(Woo), Type.EmptyTypes)!;

        public virtual bool Woo() => false;
    }
}
