﻿using System;
using System.Reflection;
using System.Reflection.Emit;
using Illuminator.Exceptions;
using Xunit;
using static Illuminator.Functions;

namespace Illuminator.Tests
{
    public class CallTests
    {
        [Fact]
        public void Call_base_virtual_method_uses_base_implementation()
        {
            var target = new DynamicMethod("test", typeof(bool), new[] { typeof(BaseClass) })
                         .GetILGenerator()
                         .UseIlluminator()
                         .Ldarg_0()
                         .Call(BaseClass.WooMethodInfo)
                         .Ret()
                         .CreateDelegate<Func<BaseClass, bool>>();

            var actual = target(new TestClass());

            Assert.False(actual);
        }

        [Fact]
        public void Call_static_float_method()
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

        [Fact]
        public void Call_void_instance_method()
        {
            var target = new DynamicMethod("test", null, new[] { typeof(TestClass) })
                         .GetILGenerator()
                         .UseIlluminator()
                         .Ldarg_0()
                         .Call(TestClass.VoidFooMethodInfo)
                         .Ret()
                         .CreateDelegate<Action<TestClass>>();

            var arg = new TestClass();

            target(arg);

            Assert.Equal(1, arg.A);
        }

        [Fact]
        public void Callvirt_on_static_method_should_not_work()
        {
            Assert.Throws<IlluminatorException>(
                () => new DynamicMethod("test", typeof(double), null)
                      .GetILGenerator()
                      .UseIlluminator()
                      .Ldc_R8(1.0)
                      .Callvirt(TestClass.DoubleFooMethodInfo)
                      .Ret()
                      .CreateDelegate<Func<double>>());
        }

        [Fact]
        public void Callvirt_uses_overridden_method()
        {
            var target = new DynamicMethod("test", typeof(bool), new[] { typeof(BaseClass) })
                         .GetILGenerator()
                         .UseIlluminator()
                         .Ldarg_0()
                         .Callvirt(BaseClass.WooMethodInfo)
                         .Ret()
                         .CreateDelegate<Func<BaseClass, bool>>();

            var actual = target(new TestClass());

            Assert.True(actual);
        }

        [Fact]
        public void EmitCall_on_static_method()
        {
            var target = new DynamicMethod("test", typeof(long), new[] { typeof(TestClass) })
                         .GetILGenerator()
                         .UseIlluminator()
                         .Ldc_I8(1)
                         .EmitCall(OpCodes.Call, TestClass.LongFooMethodInfo)
                         .Ret()
                         .CreateDelegate<Func<TestClass, long>>();

            var arg = new TestClass();

            var actual = target(arg);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void EmitCall_with_var_args()
        {
            var target = new DynamicMethod("test", typeof(string), new[] { typeof(TestClass) })
                         .GetILGenerator()
                         .UseIlluminator()
                         .Ldarg_0()
                         .EmitCall(
                             OpCodes.Call,
                             TestClass.VarArgFooMethodInfo,
                             new[] { typeof(string), typeof(int), typeof(float) },
                             Box(Ldc_I8(2), typeof(long)),
                             Ldstr("test"),
                             Ldc_I4_1(),
                             Ldc_R4(3)
                         )
                         .Ret()
                         .CreateDelegate<Func<TestClass, string>>();

            var arg = new TestClass();

            var actual = target(arg);

            Assert.Equal("2test13", actual);
        }

        [Fact]
        public void EmitCalli_with_instance_vararg_method()
        {
            var target = new DynamicMethod("test", typeof(string), new[] { typeof(TestClass) })
                         .GetILGenerator()
                         .UseIlluminator()
                         .Ldftn(TestClass.VarArgFooMethodInfo)
                         .Ldarg_0()
                         .Ret(EmitCalli(
                                  CallingConventions.HasThis | CallingConventions.VarArgs | CallingConventions.ExplicitThis,
                                  typeof(string),
                                  new[] { typeof(long) },
                                  new[] { typeof(string), typeof(int), typeof(float) },
                                  Box(Ldc_I8(2), typeof(long)),
                                  Ldstr("test"),
                                  Ldc_I4_1(),
                                  Ldc_R4(3)
                              ))
                         .CreateDelegate<Func<TestClass, string>>();

            var actual = target(new TestClass());

            Assert.Equal("2test13", actual);
        }

        [Fact]
        public void EmitCalli_with_static_method()
        {
            var target = new DynamicMethod("test", typeof(long), null)
                         .GetILGenerator()
                         .UseIlluminator()
                         .Ldftn(TestClass.LongFooMethodInfo)
                         .Ret(EmitCalli(CallingConventions.Standard,
                                        typeof(long),
                                        new[] { typeof(long) },
                                        null,
                                        Ldc_I8(1)))
                         .CreateDelegate<Func<long>>();

            var actual = target();

            Assert.Equal(1, actual);
        }
    }
}
