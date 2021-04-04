using System;
using System.Reflection.Emit;
using FluentAssertions;
using Illuminator.Exceptions;
using Xunit;
using static Illuminator.Functions;

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

        [Fact]
        public void Set_value_to_array()
        {
            var target = new DynamicMethod("test", typeof(float[]), null)
                         .GetILGenerator()
                         .UseIlluminator()
                         .DeclareLocal<float[]>(out var array)
                         .Stloc(Newarr(Ldc_I4_1(), typeof(float)), array)
                         .Stelem_R4(
                             Ldloc(array),
                             Ldc_I4_0(),
                             Ldc_R4(1.1f))
                         .Ret(Ldloc(array))
                         .CreateDelegate<Func<float[]>>();

            target().Should().BeEquivalentTo(1.1f);
        }
    }
}
