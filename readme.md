# Illuminator

[![Build status](https://ci.appveyor.com/api/projects/status/w69t5tc1ai8y1a6v?svg=true)](https://ci.appveyor.com/project/sgaliamov/illuminator)
[![NuGet Badge](https://buildstats.info/nuget/illuminator)](https://www.nuget.org/packages/illuminator)

Illuminator is yet another wrapper around [`ILGenerator`](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.emit.ilgenerator), but with some interesting features:

1. [Fluent, convenient API](#fluent-api) with functional programming flavor.
1. [Extensibility](#custom-extensions).
1. [Tracing generated code](#tracing).
1. [Scopes](#scopes) to optimize local variables usage.
1. Based on `.netstandard2.0`.

## Fluent API

Let imagine we need to generate the following code:

``` c#
int Foo(int value) {
    if (value == 2) {
        return 1;
    }

    return value + 3;
}
```

Using vanilla `ILGenerator` you may write something like this:

``` c#
...
var method = new DynamicMethod("Foo", typeof(int), new[] { typeof(int) });
var generator = method.GetILGenerator();
var label = generator.DefineLabel();

generator.Emit(OpCodes.Ldarg_0);
generator.Emit(OpCodes.Ldc_I4_2);
generator.Emit(OpCodes.Ceq);
generator.Emit(OpCodes.Brfalse_S, label); // if (value == 2)
generator.Emit(OpCodes.Ldc_I4_1);
generator.Emit(OpCodes.Ret);              // return 1
generator.MarkLabel(label);
generator.Emit(OpCodes.Ldarg_0);
generator.Emit(OpCodes.Ldc_I4_3);
generator.Emit(OpCodes.Add);
generator.Emit(OpCodes.Ret);              // return value + 3

var foo = method.CreateDelegate<Func<int, int>>();
...
```

So much code for such simple function! When you need to write a more complex thing, it becomes not possible to maintain and understand it.

There are few problems with this code:

1. It's very verbose and hard to read. All this `Emit` and `ObCodes` are just unnecessary noise.
1. It's very hard to write such code. You need to remember specification for each instruction and keep in mind the state of the stack. You need to know exactly how much parameters each instruction needs.
1. It's error prone. It's very easy to make a mistake, and exceptions, that you get in runtime, are not really informative.

The simplest thing that we can do to improve the situation is to introduce "fluent" API:

``` c#
...
var method = new DynamicMethod("Foo", typeof(int), new[] { typeof(int) });
var generator = method.GetILGenerator();
var label = generator.DefineLabel();
var il = generator.UseIlluminator(); // Creates wrapper

il.Ldarg_0()
  .Ldc_I4_2()
  .Ceq()
  .Brfalse_S(label) // if (value == 2)
  .Ldc_I4_1()
  .Ret()            // return 1
  .MarkLabel(label)
  .Ldarg_0()
  .Ldc_I4_3()
  .Add()
  .Ret();           // return value + 3

var foo = method.CreateDelegate<Func<int, int>>();
...
```

Much better this time:

1. We don't have to memorise all `OpCodes` and write those endless `Emit`. Intellisense helps us.
1. It less verbose and much easier to read.

But still this does not solve all problems.
It still possible to have an invalid stack or misuse the short versions for branching instructions (`Brfalse_S`).

Lets try one more time with some functional helpers:

``` c#
using static Illuminator.Functions;
...
new DynamicMethod("Foo", typeof(int), new[] { typeof(int) })
    .GetILGenerator()
    .UseIlluminator()
    .Brfalse_S(                      // if (value == 2)
        Ceq(Ldarg_0(), Ldc_I4_2()),
        out var label)
    .Ret(Ldc_I4_1())                 // return 1
    .MarkLabel(label)
    .Ret(Add(Ldarg_0(), Ldc_I4_3())) // return value + 3
    .CreateDelegate<Func<int, int>>();
...
```

You may think: What?! Wait, try to read it again: it checks (`Brfalse_S`) the result of the comparison (`Ceq`) of the first argument (`Ldarg_0`) and the constant two (`Ldc_I4_2`); if they are equal, return 1 (`Ret(Ldc_I4_1())`), else return the sum of the argument and three (`Ret(Add(Ldarg_0(), Ldc_I4_3()))`).

The code now is much shorter and close to the target c# version.
It's nicer to write such code, because all methods have exact amount of parameters that they need, and with output parameters we don't have to break "fluent flow" to create labels and locals.

## Hot does it work

Lets look at this line:

``` c#
Add(Ldarg_0(), Ldc_I4_3())
```

`Add` is the static function from the `Functions` class:

``` c#
public static ILEmitterFunc Add(ILEmitterFunc func1, ILEmitterFunc func2) =>
    (in ILEmitter il) => il.Add(func1, func2);
```

We can use it directly thanks to [using static directive](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-static) feature. That why we need to include `using static Illuminator.Functions;` at the beginning.

This function uses the extension for `ILEmitter` class which calls `ILEmitterFunc` functions before it calls the actual `Add` methods:

``` c#
public static ILEmitter Add(this ILEmitter self, in ILEmitterFunc func1, in ILEmitterFunc func2)
{
    func1(self);
    func2(self);

    return self.Add(); // and this finally does the real generator.Emit(OpCodes.Add);
}
```

`ILEmitterFunc` functions are responsible for preparing values in the stack. And as you may guess, it can be much complex constructions than simple `Ldc_I4`.

As the result we get the fluent, convenient API with functional programming flavor:

1. It uses the original naming of `MSIL` instructions, so you don't need to guess what `Ldc_I4_2` for example does. \
   It does exactly `generator.Emit(OpCodes.Ldc_I4_2);`.
1. All methods have helpers with exact amount of `ILEmitterFunc` parameters that they need to execute.
1. We can use output parameters to not break the fluent flow.
1. A flow of instructions can be reused many times as it is a first class function now.

## Custom extensions

We can improve the readability of our code by creating our own extensions. Lets look at this one:

``` c#
namespace CustomExtensions
{
    public static class Functions
    {
        public static ILEmitterFunc If(
            ILEmitterFunc condition,
            ILEmitterFunc then,
            ILEmitterFunc @else) => (in ILEmitter il) =>
            il.Brfalse(condition, out var otherwise)
              .Emit(then)
              .Br(out var end)
              .MarkLabel(otherwise)
              .Emit(@else)
              .MarkLabel(end);
    }
}
```

This extension emits the following code:

``` c#
if (condition()) {
    then();
} else {
    otherwise();
}
```

Using this extension we can rewrite our previous attempt like this:

``` c#
var foo = new DynamicMethod("Foo", typeof(int), new[] { typeof(int) })
    .GetILGenerator()
    .UseIlluminator(
        enableTraceLogger: true,             // enable tracing
        Ret(If(Ceq(Ldarg_0(), Ldc_I4_2()),   // condition
               Ldc_I4_1(),                   // then
               Add(Ldarg_0(), Ldc_I4_3())))) // else
    .CreateDelegate<Func<int, int>>();
```

At this time, the code is now even easier and more convenient for reading!

Of course, it can take a while for you to adapt to the functional style, but it doesn't have to.
You can still use fluent syntax.
In my code I usually mix fluent and functional approaches depending on a situation.

## Tracing

In complex cases you will want to see the list of instructions that your code generates.
To do it you can use `enableTraceLogger` parameter, you may notice it in the last example.

It uses `System.Diagnostics.Trace` and outputs such result:

``` vb
Int32 Foo(Int32)
          1: .ldarg.0         | 1 # we can see resulting the stack size
          2: .ldc.i4.2        | 2
          4: .ceq             | 1
          9: .brfalse Label_0 | 0 # we can see where the branching instruction is pointing
         10: .ldc.i4.1        | 1
         15: .br Label_1      | 0
    Label_0:                      # named label
         16: .ldarg.0         | 1
         17: .ldc.i4.3        | 2
         18: .add             | 1
    Label_1:
         19: .ret             | 0
```

## Scopes for local variables

TBD

I implemented another big [project](https://github.com/sgaliamov/il-lighten-comparer) using `illuminator`, so it passed the battle test.
