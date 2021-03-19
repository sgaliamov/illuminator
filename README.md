# Illuminator

The library is for personal projects to work with `Reflection.Emit` API.

Basically, it's yet another wrapper around [`ILGenerator`](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.emit.ilgenerator).

## Features

1. Fluent and convenient API.
2. Tracing generated code.
3. Validation for stack size.
4. Scopes to optimize local variables usage.
5. Automatic usage of short versions of instructions.
6. Optimization on `Callvirt` and `Call` usage.
7. Set of useful helpers.
8. Functional programming style.

## Why create another wrapper?

1. Learning purposes.
2. Full control on code emission.
3. Just for fun.

## How to use?

``` sh
git submodule add https://github.com/sgaliamov/illuminator.git external/illuminator
```

No package for now because **it's not production ready**.

### Plan

1. The EmitCall method is provided for varargs calls. Use the Emit method for normal calls.
1. Branch optimizations. Can calculate distance.
1. Try/catch.
1. Bacis overloads with ILEmitterFunc depending on input parameters.
1. Fuctional versions on all named functions.
1. Verifications for types of arguments.
1. Logger.