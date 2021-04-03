using System;
using System.Reflection.Emit;
using FluentAssertions;
using Illuminator.Extensions;
using Xunit;
using static Illuminator.Functions;

namespace Illuminator.Tests
{
    public class BranchesTests
    {
        [Fact]
        public void Should_detect_long_jump_on_short_branch()
        {
            using var il = new DynamicMethod("test", typeof(bool), null)
                           .GetILGenerator()
                           .UseIlluminator();

            il.DeclareLocal<int>(out var index)
              .DefineLabel(out var exit)
              .Stloc(Ldc_I4_0(), index)
              .MarkLabel(out var begin)
              .Bge(Ldloc(index), Ldc_I4(10), exit);

            for (var i = 0; i < 29; i++) {
                il.Add(Ldloc(index), Ldc_I4_1())
                  .Stloc(index);
            }

            il.Nop().Nop().Nop();

            il.Br_S(begin)
              .MarkLabel(exit)
              .Ret(Ldc_I4_1());

            var target = il.CreateDelegate<Func<bool>>();

            target().Should().BeTrue();
        }
    }
}
