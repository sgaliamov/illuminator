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
            Assert.Throws<IlluminatorStackException>(
                () => new DynamicMethod("test", typeof(double), null)
                      .GetILGenerator()
                      .UseIlluminator()
                      .Ldc_I4_0()
                      .Ldc_R8(1.0)
                      .Ret()
                      .CreateDelegate<Func<double>>());
        }

        [Fact]
        public void Ret_detects_not_empty_stack_on_void_method()
        {
            Assert.Throws<IlluminatorStackException>(
                () => new DynamicMethod("test", null, null)
                      .GetILGenerator()
                      .UseIlluminator()
                      .Ldc_I4_0()
                      .Ret());
        }
    }
}
