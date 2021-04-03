using System;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Illuminator.Tests
{
    public class CtorTestClass
    {
        static CtorTestClass() => Inner.AddInStaticCtor();

        public CtorTestClass() => Inner.AddInDefaultCtor();

        public static ConstructorInfo DefaultCtor => typeof(CtorTestClass).GetConstructor(Type.EmptyTypes)!;

        // ReSharper disable once ConvertToAutoProperty
        public static int DefaultCtorProp => Inner.DefaultCtorValue;

        public static ConstructorInfo StaticCtor => typeof(CtorTestClass).TypeInitializer!;

        // ReSharper disable once ConvertToAutoProperty
        public static int StaticCtorProp => Inner.StaticCtorValue;

        public static class Inner
        {
            // ReSharper disable once MemberInitializerValueIgnored
            internal static volatile int StaticCtorValue = 1;

            // ReSharper disable once MemberInitializerValueIgnored
            internal static volatile int DefaultCtorValue = 1;

            public static void AddInStaticCtor() => Interlocked.Increment(ref StaticCtorValue);

            public static void AddInDefaultCtor() => Interlocked.Increment(ref DefaultCtorValue);
        }
    }

    public sealed class TestClass : BaseClass
    {
        public TestClass() { }

        // ReSharper disable once UnusedMember.Global
        public TestClass(long a, string str, out int b)
        {
            A = (int)(a + str.Length);
            b = A + 1;
        }

        public static MethodInfo DoubleFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(DoubleFoo), new[] { typeof(double) })!;

        public static MethodInfo FloatFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(FloatFoo), new[] { typeof(float), typeof(string) })!;

        public static MethodInfo LongFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(LongFoo), new[] { typeof(long) })!;

        public static ConstructorInfo ParameterizedCtor =>
            typeof(TestClass).GetConstructor(new[] { typeof(int), typeof(string), typeof(int).MakeByRefType() })!;

        public static MethodInfo VarArgFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(VarArgFoo), new[] { typeof(object), typeof(string) })!;

        public static MethodInfo VoidFooMethodInfo =>
            typeof(TestClass).GetMethod(nameof(VoidFoo), Type.EmptyTypes)!;

        public int A { get; private set; }

        public int Foo(int a, string str, out int b, out long c)
        {
            A += a;
            b = A + 1;
            c = 3;

            return A + b + str.Length;
        }

        public string VarArgFoo(object a, string str, __arglist)
        {
            var argumentIterator = new ArgIterator(__arglist);
            var sb = new StringBuilder().Append(a).Append(str);
            while (argumentIterator.GetRemainingCount() != 0) {
                var reference = argumentIterator.GetNextArg();
                var o = TypedReference.ToObject(reference);

                sb.Append(o);
            }

            return sb.ToString();
        }

        public static float FloatFoo(float v, string str) => v + str.Length;

        public static double DoubleFoo(double v) => v;

        public static long LongFoo(long v) => v;

        public override bool Woo(int a, string b) => a == b.Length;

        public void VoidFoo() => A = 1;
    }

    public abstract class BaseClass
    {
        public static MethodInfo WooMethodInfo =>
            typeof(BaseClass).GetMethod(nameof(Woo), new[] { typeof(int), typeof(string) })!;

        public virtual bool Woo(int a, string b) => a != b.Length;
    }
}
