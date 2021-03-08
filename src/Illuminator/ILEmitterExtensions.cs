﻿using System.Reflection.Emit;

namespace Illuminator
{
    public static class ILEmitterExtensions
    {
        public static ILEmitter UseIlluminator(this ILGenerator il) => new ILEmitter(il);
    }
}