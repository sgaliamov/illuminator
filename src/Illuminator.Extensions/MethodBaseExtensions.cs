using System;
using System.Linq;
using System.Reflection;

namespace Illuminator.Extensions
{
    public static class MethodBaseExtensions
    {
        public static Type[] GetParameterTypes(this MethodBase self) =>
            self.GetParameters().Select(x => x.ParameterType).ToArray();
    }
}
        //public ILEmitter Block(Action<ILEmitter, Label> between)
        //{
        //    var blockEnd = _il.DefineLabel();

        //    AddDebugLabel(blockEnd);

        //    between(this, blockEnd);

        //    return MarkLabel(blockEnd);
        //}
