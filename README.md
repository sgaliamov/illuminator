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

## Why create another wrapper?

1. Learning purposes.
2. Full control on code emission.
3. Just for fun.

## How to use?

``` bash
git submodule add git@github.com:sgaliamov/illuminator.git external/illuminator
```

Not package for now because it's not production ready.