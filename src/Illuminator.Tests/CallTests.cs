using System;
using System.Reflection.Emit;
using Illuminator.Exceptions;
using Xunit;

namespace Illuminator.Tests
{
    public class CallTests
    {
        [Fact]
        public void Call_base_virtual_method_uses_base_implementation()
        {
            var target = new DynamicMethod("test", typeof(bool), new[] { typeof(BaseClass) })
                .GetILGenerator()
                .UseIlluminator()
                .Ldarg_0()
                .Call(BaseClass.WooMethodInfo)
                .Ret()
                .CreateDelegate<Func<BaseClass, bool>>();

            var actual = target(new TestClass());

            Assert.False(actual);
        }

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
            Assert.Throws<IlluminatorException>(() => new DynamicMethod("test", typeof(double), null)
                .GetILGenerator()
                .UseIlluminator()
                .Ldc_R8(1.0)
                .Callvirt(TestClass.DoubleFooMethodInfo)
                .Ret()
                .CreateDelegate<Func<double>>());
        }

        [Fact]
        public void Callvirt_uses_overridden_method()
        {
            var target = new DynamicMethod("test", typeof(bool), new[] { typeof(BaseClass) })
                .GetILGenerator()
                .UseIlluminator()
                .Ldarg_0()
                .Callvirt(BaseClass.WooMethodInfo)
                .Ret()
                .CreateDelegate<Func<BaseClass, bool>>();

            var actual = target(new TestClass());

            Assert.True(actual);
        }
    }
}
