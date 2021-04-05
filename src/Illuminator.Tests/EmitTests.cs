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
        public void CreateDelegate_detects_extra_stack() =>
            Assert.Throws<IlluminatorStackException>(
                () => new DynamicMethod("test", typeof(double), null)
                      .GetILGenerator()
                      .UseIlluminator()
                      .Ldc_I4_0()
                      .Ldc_R8(1.0)
                      .Ret()
                      .CreateDelegate<Func<double>>());

        [Fact]
        public void Ret_detects_not_empty_stack_on_void_method() =>
            Assert.Throws<IlluminatorStackException>(
                () => new DynamicMethod("test", null, null)
                      .GetILGenerator()
                      .UseIlluminator()
                      .Ldc_I4_0()
                      .Ret());

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

        [Fact]
        public void Verify_locals_scopes()
        {
           using var il = new DynamicMethod("test", typeof(int), null)
                     .GetILGenerator()
                     .UseIlluminator(true);

           il.DeclareLocal<int>(out var result);

           for (int i = 0; i < 3; i++) {
               using (il.LocalsScope()) {
                   il.DeclareLocal<int>(out var value)
                     .Stloc(Ldc_I4_1(), value)
                     .Add(Ldloc(value), Ldloc(result))
                     .Stloc(result);
               }    
           }

           il.Ldloc(result)
             .Ret();

           var target = il.CreateDelegate<Func<int>>();

           target().Should().Be(3);
        }
    }
}
