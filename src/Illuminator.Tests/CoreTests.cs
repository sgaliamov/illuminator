using System;
using System.Linq;
using System.Reflection.Emit;
using Xunit;

namespace Illuminator.Tests
{
    public class CoreTests
    {
        public TestClass test()
        {
           return new TestClass(0, out var _);
        }

        [Fact]
        public void Newobj_creates_object()
        {
            test();
            var type = typeof(TestClass);

            var method = new DynamicMethod("test", type, Type.EmptyTypes);

            using var il = method
                .GetILGenerator()
                .CreateILEmitter()
                .Stloc_0()
                .Newobj(type.GetConstructors().Single());

            var ctor = method.CreateDelegate<Func<TestClass>>();

            var actual = ctor();

            var result = actual.Foo(1, out var b);

            Assert.Equal(2, b);
            Assert.Equal(3, result);
        }
    }
}