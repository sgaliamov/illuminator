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

        public static MethodInfo DoubleFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(Foo), new[] { typeof(double) })!;

        public static MethodInfo FloatFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(Foo), new[] { typeof(float) })!;

        public static MethodInfo LongFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(Foo), new[] { typeof(long) })!;

        //public static ConstructorInfo DefaultCtor =>
        //    typeof(TestClass).GetConstructor(Type.EmptyTypes)!;

        public static ConstructorInfo ParameterizedCtor =>
            typeof(TestClass).GetConstructor(new[] { typeof(int), typeof(int).MakeByRefType() })!;

        public static MethodInfo VarArgFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(Foo), new[] { typeof(object) })!;

        public static MethodInfo VoidFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(Foo), Type.EmptyTypes)!;

        public int A { get; private set; }

        public int Foo(int a, out int b)
        {
            A += a;
            b = A + 1;

            return A + b;
        }

        public string Foo(object val, __arglist)
        {
            var argumentIterator = new ArgIterator(__arglist);
            var sb = new StringBuilder(val.ToString());
            while (argumentIterator.GetRemainingCount() != 0) {
                var reference = argumentIterator.GetNextArg();
                var o = TypedReference.ToObject(reference);

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
