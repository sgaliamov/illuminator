using System;
using System.Reflection.Emit;
using Xunit;

namespace Illuminator.Tests
{
    public class CallTests
    {
        [Fact]
        public void Call_static_float_method()
        {
            var method = new DynamicMethod("test", typeof(float), null);

            var target = method
                .GetILGenerator()
                .UseIlluminator()
                .Ldc_R4(1.0f)
                .Call(TestClass.FloatFooMethodInfo)
                .Ret()
                .CreateDelegate<Func<float>>();

            var actual = target();

            Assert.Equal(TestClass.Foo(1.0f), actual);
        }

        [Fact]
        public void Call_void_instace_method()
        {
            var target = new DynamicMethod("test", null, new[] { typeof(TestClass) })
                .GetILGenerator()
                .UseIlluminator()
                .Ldarg_0()
                .Call(TestClass.VoidFooMethodInfo)
                .Ret()
                .CreateDelegate<Action<TestClass>>();

            var arg = new TestClass();

            target(arg);

            Assert.Equal(1, arg.A);
        }
    }
}