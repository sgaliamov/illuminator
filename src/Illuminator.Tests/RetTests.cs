using System;
using System.Reflection.Emit;
using Illuminator.Exceptions;
using Xunit;

namespace Illuminator.Tests
{
    public class RetTests
    {
        [Fact]
        public void Should_fail_with_stack_empty_exception_when_tries_to_return_no_type_when_a_method_that_has_result() =>
            Assert.Throws<IlluminatorStackException>(
                () => new DynamicMethod("test", typeof(int), null)
                      .GetILGenerator()
                      .UseIlluminator()
                      .Ret());

        [Fact]
        public void Try_to_exit_without_result() =>
            new DynamicMethod("test", null, null)
                .GetILGenerator()
                .UseIlluminator()
                .Nop()
                .Ret()
                .CreateDelegate<Action>();

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

        //[Fact]
        //public void Try_to_return_a_result_when_a_method_has_no_result() =>
        //    Assert.Throws<IlluminatorStackException>(
        //        () => new DynamicMethod("test", null, null)
        //              .GetILGenerator()
        //              .UseIlluminator()
        //              .Ldc_I4_0()
        //              .Ret());

        [Fact]
        public void Try_to_return_wrong_type_on_a_method_with_result()
        {
            var method = new DynamicMethod("test", typeof(int), null);

            Assert.Throws<IlluminatorStackException>(
                () => method
                      .GetILGenerator()
                      .UseIlluminator()
                      .Ldstr("wrong result")
                      .Ret());
        }
    }
}
