using System;
using System.Reflection.Emit;
using FluentAssertions;
using Illuminator.Exceptions;
using Illuminator.Extensions;
using Xunit;
using static Illuminator.Functions;

namespace Illuminator.Tests
{
    public class BranchesTests
    {
        [Fact]
        public void Should_detect_long_jump_back_on_short_branching()
        {
            using var il = new DynamicMethod("test", typeof(bool), null)
                           .GetILGenerator()
                           .UseIlluminator();

            il.MarkLabel(out var begin);

            for (var i = 0; i < 127; i++) {
                il.Nop();
            }

            Assert.Throws<IlluminatorJumpException>(() => il.Br_S(begin));
        }

        [Fact]
        public void Should_jump_back_on_short_branching()
        {
            using var il = new DynamicMethod("test", typeof(bool), null)
                           .GetILGenerator()
                           .UseIlluminator();

            il.DeclareLocal<int>(out var state)
              .Stloc(Ldc_I4_0(), state)
              .MarkLabel(out var begin);
              //.Brfalse_S(Ceq(Ldc_I4_1(), 
              //               Ldloc(state)), );

            for (var i = 0; i < 127; i++) {
                il.Nop();
            }

            Assert.Throws<IlluminatorJumpException>(() => il.Br_S(begin));
        }

        [Fact]
        public void Should_jump_on_short_branching()
        {
            using var il = new DynamicMethod("test", typeof(bool), null)
                           .GetILGenerator()
                           .UseIlluminator();

            il.DeclareLocal<int>(out var index)
              .DefineLabel(out var exit)
              .Stloc(Ldc_I4_0(), index)
              .MarkLabel(out var begin)
              .Bge_S(Ldloc(index), Ldc_I4(10), exit);

            for (var i = 0; i < 30; i++) {
                il.Add(Ldloc(index), Ldc_I4_1())
                  .Stloc(index);
            }

            il.Nop();

            var target =
                il.Br_S(begin)
                  .MarkLabel(exit)
                  .Ret(Ldc_I4_1())
                  .CreateDelegate<Func<bool>>();

            target().Should().BeTrue();
        }
    }
}
