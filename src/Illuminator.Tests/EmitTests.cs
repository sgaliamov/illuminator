using System;
using System.Reflection.Emit;
using Illuminator.Exceptions;
using Xunit;

namespace Illuminator.Tests
{
    public class EmitTests
    {
        [Fact]
        public void CreateDelegate_detects_extra_stack()
        {
            Assert.Throws<IlluminatorStackException>(() =>
                new DynamicMethod("test", typeof(double), null)
                    .GetILGenerator()
                    .UseIlluminator()
                    .Ldc_I4_0()
                    .Ldc_R8(1.0)
                    .Ret()
                    .CreateDelegate<Func<double>>());
        }

        [Fact]
        public void Newobj_creates_object()
        {
            var type = typeof(TestClass);
            var method = new DynamicMethod("test", type, Type.EmptyTypes);

            using var il = method
                .GetILGenerator()
                .UseIlluminator()
                .DeclareLocal(typeof(int), out var local)
                .Ldc_I4_0()
                .Ldloca_S((byte)local.LocalIndex)
                .Newobj(TestClass.ParameterizedCtor)
                .Ret();

            var ctor = method.CreateDelegate<Func<TestClass>>();
            var actual = ctor();
            var result = actual.Foo(1, out var b);

            Assert.Equal(2, b);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Ret_detects_not_empty_stack_on_void_method()
        {
            Assert.Throws<IlluminatorStackException>(() =>
                new DynamicMethod("test", null, null)
                    .GetILGenerator()
                    .UseIlluminator()
                    .Ldc_I4_0()
                    .Ret());
        }
    }
}