using System.Reflection.Emit;
using Illuminator.Extensions;
using Xunit;

namespace Illuminator.Tests
{
    public class BranchesTests
    {
        [Fact]
        public void MyMethod()
        {
            using var il = new DynamicMethod("test", typeof(bool), null)
                           .GetILGenerator()
                           .UseIlluminator();

            il.MarkLabel(out var begin)
              .DeclareLocal<int>(out var index)
              .Ldloc(index)
              .Ldc_I4(100)
              .Ceq();
            //.Brfalse()
        }
    }
}
