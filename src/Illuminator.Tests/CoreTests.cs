using System;
using System.Linq;
using System.Reflection.Emit;
using Xunit;

namespace Illuminator.Tests
{
    public class CoreTests
    {
        [Fact]
        public void Newobj_creates_object()
        {
            var type = typeof(TestClass);
            var method = new DynamicMethod("test", type, Type.EmptyTypes);

            using var il = method
                .GetILGenerator()
                .UseIlluminator()
                .DeclareLocal(typeof(int), out var local)
                .Ldc_I4_0()
                .Ldloca_S((byte) local.LocalIndex)
                .Newobj(type.GetConstructors().Single())
                .Ret();

            var ctor = method.CreateDelegate<Func<TestClass>>();
            var actual = ctor();
            var result = actual.Foo(1, out var b);

            Assert.Equal(2, b);
            Assert.Equal(3, result);
        }
    }
}