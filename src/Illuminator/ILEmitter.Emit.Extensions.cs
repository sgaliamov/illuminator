using System;
using System.Collections.Generic;
using System.Text;

namespace Illuminator
{
    public static partial class ILEmitterExtensions
    {
        public static ILEmitter Stloc<T>(this ILEmitter self) =>
            self.DeclareLocal<T>(out var local)
                .Stloc(value, local);
    }
}
