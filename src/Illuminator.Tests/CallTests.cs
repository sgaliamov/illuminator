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
        public void Call_void_instance_method()
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

        [Fact]
        public void Callvirt_on_static_method_should_not_work()
        {
            Assert.Throws<ILEmitterException>(() => new DynamicMethod("test", typeof(double), null)
                .GetILGenerator()
                .UseIlluminator()
                .Ldc_R8(1.0)
                .Callvirt(TestClass.DoubleFooMethodInfo)
                .Ret()
                .CreateDelegate<Func<double>>());
        }

        [Fact]
        public void Callvirt_instance_method()
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