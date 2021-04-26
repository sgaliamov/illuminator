using System;
using System.Reflection.Emit;
using FluentAssertions;
using Illuminator.Extensions;
using Xunit;
using static Illuminator.Functions;
using static Illuminator.Extensions.Functions;

namespace Illuminator.Tests
{
    /// <example>
    ///     <code>
    ///         int Foo(int value) {
    ///             if (value == 2) {
    ///                 return 1;
    ///             }
    /// 
    ///             return value + 2;
    ///         }
    ///         </code>
    /// </example>
    public class ReadmeTests
    {
        [Fact]
        public void Sample1()
        {
            var method = new DynamicMethod("Foo", typeof(int), new[] { typeof(int) });
            var generator = method.GetILGenerator();
            var label = generator.DefineLabel();

            generator.Emit(OpCodes.Ldarg_0);
            generator.Emit(OpCodes.Ldc_I4_2);
            generator.Emit(OpCodes.Ceq);
            generator.Emit(OpCodes.Brfalse_S, label); // if (value == 2)
            generator.Emit(OpCodes.Ldc_I4_1);
            generator.Emit(OpCodes.Ret); // return 1
            generator.MarkLabel(label);
            generator.Emit(OpCodes.Ldarg_0);
            generator.Emit(OpCodes.Ldc_I4_3);
            generator.Emit(OpCodes.Add);
            generator.Emit(OpCodes.Ret); // return value + 3

            var target = method.CreateDelegate<Func<int, int>>();

            target(2).Should().Be(1);
            target(1).Should().Be(4);
        }

        [Fact]
        public void Sample2()
        {
            var method = new DynamicMethod("Foo", typeof(int), new[] { typeof(int) });
            var generator = method.GetILGenerator();
            var label = generator.DefineLabel();
            var il = generator.UseIlluminator(); // Creates wrapper

            il.Ldarg_0()
              .Ldc_I4_2()
              .Ceq()
              .Brfalse_S(label) // if (value == 2)
              .Ldc_I4_1()
              .Ret() // return 1
              .MarkLabel(label)
              .Ldarg_0()
              .Ldc_I4_3()
              .Add()
              .Ret(); // return value + 3

            var target = method.CreateDelegate<Func<int, int>>();

            target(2).Should().Be(1);
            target(1).Should().Be(4);
        }

        [Fact]
        public void Sample3()
        {
            var target =
                new DynamicMethod("Foo", typeof(int), new[] { typeof(int) })
                    .GetILGenerator()
                    .UseIlluminator()
                    .Brfalse_S( // if (value == 2)
                        Ceq(Ldarg_0(), Ldc_I4_2()),
                        out var label)
                    .Ret(Ldc_I4_1()) // return 1
                    .MarkLabel(label)
                    .Ret(Add(Ldarg_0(), Ldc_I4_3())) // return value + 3
                    .CreateDelegate<Func<int, int>>();

            target(2).Should().Be(1);
            target(1).Should().Be(4);
        }

        [Fact]
        public void Sample4()
        {
            var target =
                new DynamicMethod("Foo", typeof(int), new[] { typeof(bool) })
                    .UseIlluminator(
                        Ret(If(Ldarg_0(), // return arg0 ? 1 : 0;
                               Ldc_I4_1(),
                               Ldc_I4_2())))
                    .CreateFunction<bool, int>();

            target(true).Should().Be(1);
            target(false).Should().Be(2);
        }
    }
}
