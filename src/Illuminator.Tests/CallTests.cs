using System;
using System.Reflection;
using System.Reflection.Emit;
using Illuminator.Exceptions;
using Illuminator.Extensions;
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
                         .Call(BaseClass.WooMethodInfo,
                               BaseClass.WooMethodInfo.GetParameterTypes(),
                               Ldarg_0(),
                               Ldc_I4_1(),
                               Ldstr("a"))
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
                         .Ldc_R4(1)
                         .Ldstr("test")
                         .Call(TestClass.FloatFooMethodInfo, TestClass.FloatFooMethodInfo.GetParameterTypes())
                         .Ret()
                         .CreateDelegate<Func<float>>();

            var actual = target();

            Assert.Equal(TestClass.FloatFoo(1, "test"), actual);
        }

        [Fact]
        public void Call_static_float_method_functional()
        {
            var method = new DynamicMethod("test", typeof(float), null);

            var target = method
                         .GetILGenerator()
                         .UseIlluminator(Ret(Call(TestClass.FloatFooMethodInfo,
                                                  TestClass.FloatFooMethodInfo.GetParameterTypes(),
                                                  Ldc_R4(1),
                                                  Ldstr("test"))))
                         .CreateDelegate<Func<float>>();

            var actual = target();

            Assert.Equal(TestClass.FloatFoo(1, "test"), actual);
        }

        [Fact]
        public void Call_void_instance_method()
        {
            var target = new DynamicMethod("test", null, new[] { typeof(TestClass) })
                         .GetILGenerator()
                         .UseIlluminator(
                             Ret(Call(TestClass.VoidFooMethodInfo,
                                      TestClass.VoidFooMethodInfo.GetParameterTypes(),
                                      Ldarg_0())))
                         .CreateDelegate<Action<TestClass>>();

            var arg = new TestClass();

            target(arg);

            Assert.Equal(1, arg.A);
        }

        [Fact]
        public void Callvirt_on_static_method_should_not_work() =>
            Assert.Throws<IlluminatorException>(
                () => new DynamicMethod("test", typeof(double), null)
                      .GetILGenerator()
                      .UseIlluminator()
                      .Ldc_R8(1.0)
                      .Callvirt(TestClass.DoubleFooMethodInfo, TestClass.DoubleFooMethodInfo.GetParameterTypes())
                      .Ret()
                      .CreateDelegate<Func<double>>());

        [Fact]
        public void Callvirt_uses_overridden_method()
        {
            var target = new DynamicMethod("test", typeof(bool), new[] { typeof(BaseClass) })
                         .GetILGenerator()
                         .UseIlluminator(
                             Ldarg_0(),
                             Ldc_I4_1(),
                             Ldstr("a"),
                             Callvirt(BaseClass.WooMethodInfo, BaseClass.WooMethodInfo.GetParameterTypes()),
                             Ret())
                         .CreateDelegate<Func<BaseClass, bool>>();

            var actual = target(new TestClass());

            Assert.True(actual);
        }

        [Fact]
        public void Create_method_with_AssemblyBuilder()
        {
            var typeBuilder =
                AssemblyBuilder
                    .DefineDynamicAssembly(new AssemblyName("test"), AssemblyBuilderAccess.RunAndCollect)
                    .DefineDynamicModule("module")
                    .DefineType("type");

            var add2Method = typeBuilder
                .DefineMethod(
                    "add2",
                    MethodAttributes.Static | MethodAttributes.Public,
                    typeof(int),
                    new[] { typeof(int) });

            using var _ =
                add2Method
                    .GetILGenerator()
                    .UseIlluminator(
                        Ret(Add(Ldc_I4_2(),
                                Ldarg_0())));

            using var __ =
                typeBuilder
                    .DefineMethod(
                        "test",
                        MethodAttributes.Static | MethodAttributes.Public,
                        typeof(int),
                        null)
                    .GetILGenerator()
                    .UseIlluminator(
                        Ret(Call(add2Method,
                                 new[] { typeof(int) },
                                 Ldc_I4_3())));

            var type = typeBuilder.CreateType()!;

            var target = type.GetMethod("test")!.CreateDelegate<Func<int>>();

            var actual = target();

            Assert.Equal(5, actual);
        }

        [Fact]
        public void EmitCall_on_static_method()
        {
            var target = new DynamicMethod("test", typeof(long), new[] { typeof(TestClass) })
                         .GetILGenerator()
                         .UseIlluminator()
                         .Ldc_I8(1)
                         .EmitCall(OpCodes.Call,
                                   TestClass.LongFooMethodInfo,
                                   TestClass.LongFooMethodInfo.GetParameterTypes())
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
                             TestClass.VarArgFooMethodInfo.GetParameterTypes(),
                             new[] { typeof(string), typeof(int), typeof(float) },
                             Box(Ldc_I8(2), typeof(long)),
                             Ldstr("_str_"),
                             Ldstr("test"),
                             Ldc_I4_1(),
                             Ldc_R4(3)
                         )
                         .Ret()
                         .CreateDelegate<Func<TestClass, string>>();

            var arg = new TestClass();

            var actual = target(arg);

            Assert.Equal("2_str_test13", actual);
        }

        [Fact]
        public void EmitCalli_with_instance_vararg_method()
        {
            var target = new DynamicMethod("test", typeof(string), new[] { typeof(TestClass) })
                         .GetILGenerator()
                         .UseIlluminator()
                         .Ret(EmitCalli(
                                  CallingConventions.HasThis | CallingConventions.VarArgs,
                                  typeof(string),
                                  TestClass.VarArgFooMethodInfo.GetParameterTypes(),
                                  new[] { typeof(string), typeof(int), typeof(float) },
                                  Ldftn(TestClass.VarArgFooMethodInfo), // method to call
                                  Ldarg_0(), // this
                                  Box(Ldc_I8(2), typeof(long)),
                                  Ldstr("_str"),
                                  Ldstr("_var"),
                                  Ldc_I4_1(),
                                  Ldc_R4(3)
                              ))
                         .CreateDelegate<Func<TestClass, string>>();

            var actual = target(new TestClass());

            Assert.Equal("2_str_var13", actual);
        }

        [Fact]
        public void EmitCalli_with_static_method()
        {
            var target = new DynamicMethod("test", typeof(long), null)
                         .GetILGenerator()
                         .UseIlluminator(
                             Ret(EmitCalli(
                                     CallingConventions.Standard,
                                     typeof(long),
                                     TestClass.LongFooMethodInfo.GetParameterTypes(),
                                     null,
                                     Ldftn(TestClass.LongFooMethodInfo),
                                     Ldc_I8(1))))
                         .CreateDelegate<Func<long>>();

            var actual = target();

            Assert.Equal(1, actual);
        }

        [Fact]
        public void Invoke_default_constructor()
        {
            var arg = new CtorTestClass();

            Assert.Equal(2, CtorTestClass.DefaultCtorProp);

            var target = new DynamicMethod("test", null, new[] { typeof(CtorTestClass) })
                         .GetILGenerator()
                         .UseIlluminator(
                             Ldarg_0(),
                             Call(CtorTestClass.DefaultCtor),
                             Ret())
                         .CreateDelegate<Action<CtorTestClass>>();

            target(arg);

            Assert.Equal(3, CtorTestClass.DefaultCtorProp);
        }

        [Fact]
        public void Invoke_static_constructor()
        {
            Assert.Equal(2, CtorTestClass.StaticCtorProp);

            var target = new DynamicMethod("test", null, Type.EmptyTypes)
                         .GetILGenerator()
                         .UseIlluminator(
                             Call(CtorTestClass.StaticCtor),
                             Ret())
                         .CreateDelegate<Action>();

            target();

            Assert.Equal(3, CtorTestClass.StaticCtorProp);
        }

        [Fact]
        public void Newobj_creates_object()
        {
            var type = typeof(TestClass);
            var method = new DynamicMethod("test", type, Type.EmptyTypes);

            using var il = method.GetILGenerator()
                                 .UseIlluminator()
                                 .DeclareLocal(typeof(int), out var local)
                                 .Emit(Ret(Newobj(TestClass.ParameterizedCtor,
                                                  TestClass.ParameterizedCtor.GetParameterTypes(),
                                                  Ldc_I8(1),
                                                  Ldstr("str"),
                                                  Ldloca_S((byte)local.LocalIndex))));

            var ctor = method.CreateDelegate<Func<TestClass>>();
            var actual = ctor();
            var result = actual.Foo(1, "test", out var b, out var c);

            Assert.Equal(6, b);
            Assert.Equal(3, c);
            Assert.Equal(15, result);
        }
    }
}