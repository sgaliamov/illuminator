using System;
using System.Reflection.Emit;
using Xunit;

namespace Illuminator.Tests
{
    public class CallTests
    {
        [Fact]
        public void Call_method()
        {
            var method = new DynamicMethod("test", typeof(float), null);

            var target = method
                .GetILGenerator()
                .UseIlluminator()
                .Ldc_R4(1.0f)
                .Call(TestClass.FloatFooMethodInfo)
                .Ret()
                .CreateDelegate<Func<float>>();

            var actual = target();

            Assert.Equal(TestClass.Foo(1.0f), actual);
        }
    }
}