using System;
using System.Reflection.Emit;
using FluentAssertions;
using Illuminator.Exceptions;
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
        public void Should_detect_long_jump_forward_on_short_branching()
        {
            using var il = new DynamicMethod("test", typeof(bool), null)
                           .GetILGenerator()
                           .UseIlluminator();

            il.DefineLabel(out var end).Br_S(end);

            for (var i = 0; i < 125; i++) {
                il.Nop();
            }

            Assert.Throws<IlluminatorJumpException>(() => il.MarkLabel(end));
        }

        [Fact]
        public void Should_jump_back_on_short_branching()
        {
            using var il = new DynamicMethod("test", typeof(bool), null)
                           .GetILGenerator()
                           .UseIlluminator();

            il.DeclareLocal<int>(out var state)
              .Stloc(Ldc_I4_0(), state)
              .MarkLabel(out var begin)
              .Brfalse_S(Ceq(Ldc_I4_1(),
                             Ldloc(state)),
                         out var start)
              .Ret(Ldc_I4_1())
              .MarkLabel(start);

            for (var i = 0; i < 116; i++) {
                il.Nop();
            }

            var target =
                il.Stloc(Ldc_I4_1(), state)
                  .Br_S(begin)
                  .CreateDelegate<Func<bool>>();

            target().Should().BeTrue();
        }

        [Fact]
        public void Should_jump_on_short_branching()
        {
            using var il = new DynamicMethod("test", typeof(bool), null)
                           .GetILGenerator()
                           .UseIlluminator(true);

            il.DeclareLocal<int>(out var index)
              .DefineLabel(out var exit)
              .Stloc(Ldc_I4_0(), index)
              .MarkLabel(out var begin)
              .Bge_S(Ldloc(index), Ldc_I4(10), exit);

            for (var i = 0; i < 29; i++) {
                il.Add(Ldloc(index), Ldc_I4_1())
                  .Stloc(index);
            }

            il.Nop().Nop();

            var target =
                il.Br_S(begin)
                  .MarkLabel(exit)
                  .Ret(Ldc_I4_1())
                  .CreateDelegate<Func<bool>>();

            target().Should().BeTrue();
        }

        [Fact]
        public void When_stack_is_not_linear()
        {
            using var il = new DynamicMethod("test", typeof(int), new[] { typeof(bool) })
                           .GetILGenerator()
                           .UseIlluminator(true);

            var target = il.Brtrue_S(Ldarg_0(), out var l)
                           .Ldc_I4_2()
                           .Br_S(out var exit)
                           .MarkLabel(l)
                           .Ldc_I4_3()
                           .MarkLabel(exit)
                           .Ret()
                           .CreateDelegate<Func<bool, int>>();

            target(true).Should().Be(3);
            target(false).Should().Be(2);
        }
    }
}
