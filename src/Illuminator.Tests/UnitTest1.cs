using System.Reflection.Emit;
using Xunit;

namespace Illuminator.Tests
{
    public class UnitTest1
    {
        private int Method(TestData data, bool arg)
        {
            if (arg)
            {
                return data.Value.Length;
            }

            return 2 + 4;
        }

        [Fact]
        public void Test1()
        {
            var il = new DynamicMethod(
                    "test", 
                    typeof(int), 
                    new[] { typeof(TestData), typeof(bool) })
                .GetILGenerator();

            //il.If(LoadArg(0), Ret(x => x.Value.Length))
            //  .Ret(Add(LoadConstant(2), LoadConstant(4)));
        }
    }

    public class TestData
    {
        public string Value { get; set; }
    }
}