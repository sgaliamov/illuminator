using System;
using System.Reflection.Emit;
using Xunit;

namespace Illuminator.Tests
{
    public class RetTests
    {
        [Fact]
        public void Try_to_return_wrong_type_on_a_method_with_result()
        {
            var method = new DynamicMethod("test", typeof(int), null);

            Assert.Throws<ILEmitterException>(
                () => method
                    .GetILGenerator()
                    .UseIlluminator()
                    .Ldstr("wrong result")
                    .Ret());
        }

        [Fact]
        public void Should_fail_with_Stack_empty_exception_when_tries_to_return_no_type_when_a_method_that_has_result()
        {
            var method = new DynamicMethod("test", typeof(int), null);

            Assert.Throws<ILEmitterException>(
                () => method
                    .GetILGenerator()
                    .UseIlluminator()
                    .Ret());
        }

        [Fact]
        public void Try_to_return_a_result_when_a_method_has_no_result()
        {
            var method = new DynamicMethod("test", null, null);

            Assert.Throws<ILEmitterException>(
                () => method
                    .GetILGenerator()
                    .UseIlluminator()
                    .Ldc_I4_0()
                    .Ret());
        }

        [Fact]
        public void Try_to_return_a_correct_result()
        {
            var method = new DynamicMethod("test", typeof(int), null);

            method
                .GetILGenerator()
                .UseIlluminator()
                .Ldc_I4_1()
                .Ret();

            var actual = method.CreateDelegate<Func<int>>()();

            Assert.Equal(1, actual);
        }

        [Fact]
        public void Try_to_exit_without_result()
        {
            var method = new DynamicMethod("test", null, null);

            method
                .GetILGenerator()
                .UseIlluminator()
                .Nop()
                .Ret();

            method.CreateDelegate<Action>();
        }
    }
}