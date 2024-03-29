/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator
{
    // Generated functions for op code methods.
    public static partial class Functions
    {
        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginCatchBlock(Type)"/>.
        /// </summary>
        public static ILEmitterFunc BeginCatchBlock(Type exceptionType) => (in ILEmitter il) => il.BeginCatchBlock(exceptionType);

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginExceptFilterBlock()"/>.
        /// </summary>
        public static ILEmitterFunc BeginExceptFilterBlock() => (in ILEmitter il) => il.BeginExceptFilterBlock();

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginFaultBlock()"/>.
        /// </summary>
        public static ILEmitterFunc BeginFaultBlock() => (in ILEmitter il) => il.BeginFaultBlock();

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginFinallyBlock()"/>.
        /// </summary>
        public static ILEmitterFunc BeginFinallyBlock() => (in ILEmitter il) => il.BeginFinallyBlock();

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginScope()"/>.
        /// </summary>
        public static ILEmitterFunc BeginScope() => (in ILEmitter il) => il.BeginScope();

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EmitWriteLine(String)"/>.
        /// </summary>
        public static ILEmitterFunc EmitWriteLine(String value) => (in ILEmitter il) => il.EmitWriteLine(value);

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EmitWriteLine(LocalBuilder)"/>.
        /// </summary>
        public static ILEmitterFunc EmitWriteLine(LocalBuilder localBuilder) => (in ILEmitter il) => il.EmitWriteLine(localBuilder);

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EmitWriteLine(FieldInfo)"/>.
        /// </summary>
        public static ILEmitterFunc EmitWriteLine(FieldInfo fld) => (in ILEmitter il) => il.EmitWriteLine(fld);

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EndExceptionBlock()"/>.
        /// </summary>
        public static ILEmitterFunc EndExceptionBlock() => (in ILEmitter il) => il.EndExceptionBlock();

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EndScope()"/>.
        /// </summary>
        public static ILEmitterFunc EndScope() => (in ILEmitter il) => il.EndScope();

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.ThrowException(Type)"/>.
        /// </summary>
        public static ILEmitterFunc ThrowException(Type excType) => (in ILEmitter il) => il.ThrowException(excType);

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.UsingNamespace(String)"/>.
        /// </summary>
        public static ILEmitterFunc UsingNamespace(String usingNamespace) => (in ILEmitter il) => il.UsingNamespace(usingNamespace);

        /// <summary>
        ///     Adds two values and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Add(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Add(func1, func2);

        /// <summary>
        ///     Adds two integers, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Add_Ovf(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Add_Ovf(func1, func2);

        /// <summary>
        ///     Adds two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Add_Ovf_Un(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Add_Ovf_Un(func1, func2);

        /// <summary>
        ///     Computes the bitwise AND of two values and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc And(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.And(func1, func2);

        /// <summary>
        ///     Returns an unmanaged pointer to the argument list of the current method.
        /// </summary>
        public static ILEmitterFunc Arglist() => (in ILEmitter il) => il.Arglist();

        /// <summary>
        ///     Transfers control to a target instruction if two values are equal.
        /// </summary>
        public static ILEmitterFunc Beq(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Beq(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if two values are equal.
        /// </summary>
        public static ILEmitterFunc Beq_S(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Beq_S(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than or equal to the second value.
        /// </summary>
        public static ILEmitterFunc Bge(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Bge(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than or equal to the second value.
        /// </summary>
        public static ILEmitterFunc Bge_S(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Bge_S(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Bge_Un(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Bge_Un(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Bge_Un_S(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Bge_Un_S(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than the second value.
        /// </summary>
        public static ILEmitterFunc Bgt(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Bgt(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than the second value.
        /// </summary>
        public static ILEmitterFunc Bgt_S(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Bgt_S(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Bgt_Un(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Bgt_Un(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Bgt_Un_S(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Bgt_Un_S(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than or equal to the second value.
        /// </summary>
        public static ILEmitterFunc Ble(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Ble(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than or equal to the second value.
        /// </summary>
        public static ILEmitterFunc Ble_S(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Ble_S(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Ble_Un(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Ble_Un(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Ble_Un_S(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Ble_Un_S(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than the second value.
        /// </summary>
        public static ILEmitterFunc Blt(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Blt(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than the second value.
        /// </summary>
        public static ILEmitterFunc Blt_S(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Blt_S(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Blt_Un(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Blt_Un(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Blt_Un_S(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Blt_Un_S(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction when two unsigned integer values or unordered float values are not equal.
        /// </summary>
        public static ILEmitterFunc Bne_Un(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Bne_Un(func1, func2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) when two unsigned integer values or unordered float values are not equal.
        /// </summary>
        public static ILEmitterFunc Bne_Un_S(ILEmitterFunc func1, ILEmitterFunc func2, Label label) => (in ILEmitter il) => il.Bne_Un_S(func1, func2, label);

        /// <summary>
        ///     Converts a value type to an object reference (type O).
        /// </summary>
        public static ILEmitterFunc Box(ILEmitterFunc func1, Type type) => (in ILEmitter il) => il.Box(func1, type);

        /// <summary>
        ///     Unconditionally transfers control to a target instruction.
        /// </summary>
        public static ILEmitterFunc Br(Label label) => (in ILEmitter il) => il.Br(label);

        /// <summary>
        ///     Unconditionally transfers control to a target instruction (short form).
        /// </summary>
        public static ILEmitterFunc Br_S(Label label) => (in ILEmitter il) => il.Br_S(label);

        /// <summary>
        ///     Signals the Common Language Infrastructure (CLI) to inform the debugger that a break point has been tripped.
        /// </summary>
        public static ILEmitterFunc Break() => (in ILEmitter il) => il.Break();

        /// <summary>
        ///     Transfers control to a target instruction if value is false, a null reference (Nothing in Visual Basic), or zero.
        /// </summary>
        public static ILEmitterFunc Brfalse(ILEmitterFunc func1, Label label) => (in ILEmitter il) => il.Brfalse(func1, label);

        /// <summary>
        ///     Transfers control to a target instruction if value is false, a null reference, or zero.
        /// </summary>
        public static ILEmitterFunc Brfalse_S(ILEmitterFunc func1, Label label) => (in ILEmitter il) => il.Brfalse_S(func1, label);

        /// <summary>
        ///     Transfers control to a target instruction if value is true, not null, or non-zero.
        /// </summary>
        public static ILEmitterFunc Brtrue(ILEmitterFunc func1, Label label) => (in ILEmitter il) => il.Brtrue(func1, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if value is true, not null, or non-zero.
        /// </summary>
        public static ILEmitterFunc Brtrue_S(ILEmitterFunc func1, Label label) => (in ILEmitter il) => il.Brtrue_S(func1, label);

        /// <summary>
        ///     Calls the method indicated by the passed method descriptor.
        /// </summary>
        public static ILEmitterFunc Call(MethodInfo methodInfo) => (in ILEmitter il) => il.Call(methodInfo);

        /// <summary>
        ///     Calls the method indicated by the passed method descriptor.
        /// </summary>
        public static ILEmitterFunc Call(ConstructorInfo constructorInfo) => (in ILEmitter il) => il.Call(constructorInfo);

        /// <summary>
        ///     Calls a late-bound method on an object, pushing the return value onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Callvirt(MethodInfo methodInfo) => (in ILEmitter il) => il.Callvirt(methodInfo);

        /// <summary>
        ///     Attempts to cast an object passed by reference to the specified class.
        /// </summary>
        public static ILEmitterFunc Castclass(ILEmitterFunc func1, Type type) => (in ILEmitter il) => il.Castclass(func1, type);

        /// <summary>
        ///     Compares two values. If they are equal, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ceq(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Ceq(func1, func2);

        /// <summary>
        ///     Compares two values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Cgt(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Cgt(func1, func2);

        /// <summary>
        ///     Compares two unsigned or unordered values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Cgt_Un(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Cgt_Un(func1, func2);

        /// <summary>
        ///     Throws ArithmeticException if value is not a finite number.
        /// </summary>
        public static ILEmitterFunc Ckfinite(ILEmitterFunc func1) => (in ILEmitter il) => il.Ckfinite(func1);

        /// <summary>
        ///     Compares two values. If the first value is less than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Clt(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Clt(func1, func2);

        /// <summary>
        ///     Compares the unsigned or unordered values value1 and value2. If value1 is less than value2, then the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Clt_Un(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Clt_Un(func1, func2);

        /// <summary>
        ///     Constrains the type on which a virtual method call is made.
        /// </summary>
        public static ILEmitterFunc Constrained(Type type) => (in ILEmitter il) => il.Constrained(type);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to native int.
        /// </summary>
        public static ILEmitterFunc Conv_I(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_I(func1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to int8, then extends (pads) it to int32.
        /// </summary>
        public static ILEmitterFunc Conv_I1(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_I1(func1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to int16, then extends (pads) it to int32.
        /// </summary>
        public static ILEmitterFunc Conv_I2(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_I2(func1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to int32.
        /// </summary>
        public static ILEmitterFunc Conv_I4(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_I4(func1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to int64.
        /// </summary>
        public static ILEmitterFunc Conv_I8(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_I8(func1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed native int, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_I(func1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed int8 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I1(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_I1(func1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed int8 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I1_Un(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_I1_Un(func1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed int16 and extending it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I2(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_I2(func1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed int16 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I2_Un(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_I2_Un(func1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I4(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_I4(func1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I4_Un(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_I4_Un(func1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed int64, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I8(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_I8(func1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed int64, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I8_Un(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_I8_Un(func1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed native int, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I_Un(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_I_Un(func1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned native int, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_U(func1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U1(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_U1(func1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U1_Un(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_U1_Un(func1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U2(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_U2(func1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U2_Un(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_U2_Un(func1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U4(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_U4(func1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to unsigned int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U4_Un(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_U4_Un(func1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int64, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U8(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_U8(func1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to unsigned int64, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U8_Un(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_U8_Un(func1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to unsigned native int, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U_Un(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_Ovf_U_Un(func1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to float32.
        /// </summary>
        public static ILEmitterFunc Conv_R4(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_R4(func1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to float32.
        /// </summary>
        public static ILEmitterFunc Conv_R8(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_R8(func1);

        /// <summary>
        ///     Converts the unsigned integer value on top of the evaluation stack to float32.
        /// </summary>
        public static ILEmitterFunc Conv_R_Un(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_R_Un(func1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to float32.
        /// </summary>
        public static ILEmitterFunc Conv_U(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_U(func1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to unsigned int8, and extends it to int32.
        /// </summary>
        public static ILEmitterFunc Conv_U1(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_U1(func1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to unsigned int16, and extends it to int32.
        /// </summary>
        public static ILEmitterFunc Conv_U2(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_U2(func1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to unsigned int32, and extends it to int32.
        /// </summary>
        public static ILEmitterFunc Conv_U4(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_U4(func1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to unsigned int64, and extends it to int64.
        /// </summary>
        public static ILEmitterFunc Conv_U8(ILEmitterFunc func1) => (in ILEmitter il) => il.Conv_U8(func1);

        /// <summary>
        ///     Copies a specified number bytes from a source address to a destination address.
        /// </summary>
        public static ILEmitterFunc Cpblk(ILEmitterFunc func1, ILEmitterFunc func2, ILEmitterFunc func3) => (in ILEmitter il) => il.Cpblk(func1, func2, func3);

        /// <summary>
        ///     Copies the value type located at the address of an object (type &, or native int) to the address of the destination object (type &, or native int).
        /// </summary>
        public static ILEmitterFunc Cpobj(ILEmitterFunc func1, ILEmitterFunc func2, Type type) => (in ILEmitter il) => il.Cpobj(func1, func2, type);

        /// <summary>
        ///     Divides two values and pushes the result as a floating-point (type F) or quotient (type int32) onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Div(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Div(func1, func2);

        /// <summary>
        ///     Divides two unsigned integer values and pushes the result (int32) onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Div_Un(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Div_Un(func1, func2);

        /// <summary>
        ///     Copies the current topmost value on the evaluation stack, and then pushes the copy onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Dup(ILEmitterFunc func1) => (in ILEmitter il) => il.Dup(func1);

        /// <summary>
        ///     Transfers control from the filter clause of an exception back to the Common Language Infrastructure (CLI) exception handler.
        /// </summary>
        public static ILEmitterFunc Endfilter(ILEmitterFunc func1) => (in ILEmitter il) => il.Endfilter(func1);

        /// <summary>
        ///     Transfers control from the fault or finally clause of an exception block back to the Common Language Infrastructure (CLI) exception handler.
        /// </summary>
        public static ILEmitterFunc Endfinally() => (in ILEmitter il) => il.Endfinally();

        /// <summary>
        ///     Initializes a specified block of memory at a specific address to a given size and initial value.
        /// </summary>
        public static ILEmitterFunc Initblk(ILEmitterFunc func1, ILEmitterFunc func2, ILEmitterFunc func3) => (in ILEmitter il) => il.Initblk(func1, func2, func3);

        /// <summary>
        ///     Initializes each field of the value type at a specified address to a null reference or a 0 of the appropriate primitive type.
        /// </summary>
        public static ILEmitterFunc Initobj(ILEmitterFunc func1, Type type) => (in ILEmitter il) => il.Initobj(func1, type);

        /// <summary>
        ///     Tests whether an object reference (type O) is an instance of a particular class.
        /// </summary>
        public static ILEmitterFunc Isinst(ILEmitterFunc func1, Type type) => (in ILEmitter il) => il.Isinst(func1, type);

        /// <summary>
        ///     Exits current method and jumps to specified method.
        /// </summary>
        public static ILEmitterFunc Jmp(MethodInfo methodInfo) => (in ILEmitter il) => il.Jmp(methodInfo);

        /// <summary>
        ///     Loads an argument (referenced by a specified index value) onto the stack.
        /// </summary>
        public static ILEmitterFunc Ldarg(short value) => (in ILEmitter il) => il.Ldarg(value);

        /// <summary>
        ///     Loads the argument at index 0 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarg_0() => (in ILEmitter il) => il.Ldarg_0();

        /// <summary>
        ///     Loads the argument at index 1 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarg_1() => (in ILEmitter il) => il.Ldarg_1();

        /// <summary>
        ///     Loads the argument at index 2 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarg_2() => (in ILEmitter il) => il.Ldarg_2();

        /// <summary>
        ///     Loads the argument at index 3 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarg_3() => (in ILEmitter il) => il.Ldarg_3();

        /// <summary>
        ///     Loads the argument (referenced by a specified short form index) onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarg_S(byte value) => (in ILEmitter il) => il.Ldarg_S(value);

        /// <summary>
        ///     Load an argument address onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarga(short value) => (in ILEmitter il) => il.Ldarga(value);

        /// <summary>
        ///     Load an argument address, in short form, onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarga_S(byte value) => (in ILEmitter il) => il.Ldarga_S(value);

        /// <summary>
        ///     Pushes a supplied value of type int32 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4(int value) => (in ILEmitter il) => il.Ldc_I4(value);

        /// <summary>
        ///     Pushes the integer value of 0 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_0() => (in ILEmitter il) => il.Ldc_I4_0();

        /// <summary>
        ///     Pushes the integer value of 1 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_1() => (in ILEmitter il) => il.Ldc_I4_1();

        /// <summary>
        ///     Pushes the integer value of 2 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_2() => (in ILEmitter il) => il.Ldc_I4_2();

        /// <summary>
        ///     Pushes the integer value of 3 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_3() => (in ILEmitter il) => il.Ldc_I4_3();

        /// <summary>
        ///     Pushes the integer value of 4 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_4() => (in ILEmitter il) => il.Ldc_I4_4();

        /// <summary>
        ///     Pushes the integer value of 5 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_5() => (in ILEmitter il) => il.Ldc_I4_5();

        /// <summary>
        ///     Pushes the integer value of 6 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_6() => (in ILEmitter il) => il.Ldc_I4_6();

        /// <summary>
        ///     Pushes the integer value of 7 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_7() => (in ILEmitter il) => il.Ldc_I4_7();

        /// <summary>
        ///     Pushes the integer value of 8 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_8() => (in ILEmitter il) => il.Ldc_I4_8();

        /// <summary>
        ///     Pushes the integer value of -1 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_M1() => (in ILEmitter il) => il.Ldc_I4_M1();

        /// <summary>
        ///     Pushes the supplied int8 value onto the evaluation stack as an int32, short form.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_S(byte value) => (in ILEmitter il) => il.Ldc_I4_S(value);

        /// <summary>
        ///     Pushes the supplied int8 value onto the evaluation stack as an int32, short form.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_S(sbyte value) => (in ILEmitter il) => il.Ldc_I4_S(value);

        /// <summary>
        ///     Pushes a supplied value of type int64 onto the evaluation stack as an int64.
        /// </summary>
        public static ILEmitterFunc Ldc_I8(long value) => (in ILEmitter il) => il.Ldc_I8(value);

        /// <summary>
        ///     Pushes a supplied value of type float32 onto the evaluation stack as type F (float).
        /// </summary>
        public static ILEmitterFunc Ldc_R4(float value) => (in ILEmitter il) => il.Ldc_R4(value);

        /// <summary>
        ///     Pushes a supplied value of type float64 onto the evaluation stack as type F (float).
        /// </summary>
        public static ILEmitterFunc Ldc_R8(double value) => (in ILEmitter il) => il.Ldc_R8(value);

        /// <summary>
        ///     Loads the element at a specified array index onto the top of the evaluation stack as the type specified in the instruction.
        /// </summary>
        public static ILEmitterFunc Ldelem(ILEmitterFunc func1, ILEmitterFunc func2, Type type) => (in ILEmitter il) => il.Ldelem(func1, func2, type);

        /// <summary>
        ///     Loads the element with type native int at a specified array index onto the top of the evaluation stack as a native int.
        /// </summary>
        public static ILEmitterFunc Ldelem_I(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Ldelem_I(func1, func2);

        /// <summary>
        ///     Loads the element with type int8 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldelem_I1(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Ldelem_I1(func1, func2);

        /// <summary>
        ///     Loads the element with type int16 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldelem_I2(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Ldelem_I2(func1, func2);

        /// <summary>
        ///     Loads the element with type int32 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldelem_I4(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Ldelem_I4(func1, func2);

        /// <summary>
        ///     Loads the element with type int64 at a specified array index onto the top of the evaluation stack as an int64.
        /// </summary>
        public static ILEmitterFunc Ldelem_I8(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Ldelem_I8(func1, func2);

        /// <summary>
        ///     Loads the element with type float32 at a specified array index onto the top of the evaluation stack as type F (float).
        /// </summary>
        public static ILEmitterFunc Ldelem_R4(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Ldelem_R4(func1, func2);

        /// <summary>
        ///     Loads the element with type float64 at a specified array index onto the top of the evaluation stack as type F (float).
        /// </summary>
        public static ILEmitterFunc Ldelem_R8(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Ldelem_R8(func1, func2);

        /// <summary>
        ///     Loads the element containing an object reference at a specified array index onto the top of the evaluation stack as type O (object reference).
        /// </summary>
        public static ILEmitterFunc Ldelem_Ref(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Ldelem_Ref(func1, func2);

        /// <summary>
        ///     Loads the element with type unsigned int8 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldelem_U1(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Ldelem_U1(func1, func2);

        /// <summary>
        ///     Loads the element with type unsigned int16 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldelem_U2(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Ldelem_U2(func1, func2);

        /// <summary>
        ///     Loads the element with type unsigned int32 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldelem_U4(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Ldelem_U4(func1, func2);

        /// <summary>
        ///     Loads the address of the array element at a specified array index onto the top of the evaluation stack as type & (managed pointer).
        /// </summary>
        public static ILEmitterFunc Ldelema(ILEmitterFunc func1, ILEmitterFunc func2, Type type) => (in ILEmitter il) => il.Ldelema(func1, func2, type);

        /// <summary>
        ///     Finds the value of a field in the object whose reference is currently on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldfld(ILEmitterFunc func1, FieldInfo fieldInfo) => (in ILEmitter il) => il.Ldfld(func1, fieldInfo);

        /// <summary>
        ///     Finds the address of a field in the object whose reference is currently on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldflda(ILEmitterFunc func1, FieldInfo fieldInfo) => (in ILEmitter il) => il.Ldflda(func1, fieldInfo);

        /// <summary>
        ///     Pushes an unmanaged pointer (type native int) to the native code implementing a specific method onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldftn(MethodInfo methodInfo) => (in ILEmitter il) => il.Ldftn(methodInfo);

        /// <summary>
        ///     Loads a value of type native int as a native int onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_I(ILEmitterFunc func1) => (in ILEmitter il) => il.Ldind_I(func1);

        /// <summary>
        ///     Loads a value of type int8 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_I1(ILEmitterFunc func1) => (in ILEmitter il) => il.Ldind_I1(func1);

        /// <summary>
        ///     Loads a value of type int16 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_I2(ILEmitterFunc func1) => (in ILEmitter il) => il.Ldind_I2(func1);

        /// <summary>
        ///     Loads a value of type int32 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_I4(ILEmitterFunc func1) => (in ILEmitter il) => il.Ldind_I4(func1);

        /// <summary>
        ///     Loads a value of type int64 as an int64 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_I8(ILEmitterFunc func1) => (in ILEmitter il) => il.Ldind_I8(func1);

        /// <summary>
        ///     Loads a value of type float32 as a type F (float) onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_R4(ILEmitterFunc func1) => (in ILEmitter il) => il.Ldind_R4(func1);

        /// <summary>
        ///     Loads a value of type float64 as a type F (float) onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_R8(ILEmitterFunc func1) => (in ILEmitter il) => il.Ldind_R8(func1);

        /// <summary>
        ///     Loads an object reference as a type O (object reference) onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_Ref(ILEmitterFunc func1) => (in ILEmitter il) => il.Ldind_Ref(func1);

        /// <summary>
        ///     Loads a value of type unsigned int8 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_U1(ILEmitterFunc func1) => (in ILEmitter il) => il.Ldind_U1(func1);

        /// <summary>
        ///     Loads a value of type unsigned int16 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_U2(ILEmitterFunc func1) => (in ILEmitter il) => il.Ldind_U2(func1);

        /// <summary>
        ///     Loads a value of type unsigned int32 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_U4(ILEmitterFunc func1) => (in ILEmitter il) => il.Ldind_U4(func1);

        /// <summary>
        ///     Pushes the number of elements of a zero-based, one-dimensional array onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldlen(ILEmitterFunc func1) => (in ILEmitter il) => il.Ldlen(func1);

        /// <summary>
        ///     Loads the local variable at a specific index onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloc(LocalBuilder localBuilder) => (in ILEmitter il) => il.Ldloc(localBuilder);

        /// <summary>
        ///     Loads the local variable at a specific index onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloc(short value) => (in ILEmitter il) => il.Ldloc(value);

        /// <summary>
        ///     Loads the local variable at index 0 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloc_0() => (in ILEmitter il) => il.Ldloc_0();

        /// <summary>
        ///     Loads the local variable at index 1 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloc_1() => (in ILEmitter il) => il.Ldloc_1();

        /// <summary>
        ///     Loads the local variable at index 2 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloc_2() => (in ILEmitter il) => il.Ldloc_2();

        /// <summary>
        ///     Loads the local variable at index 3 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloc_3() => (in ILEmitter il) => il.Ldloc_3();

        /// <summary>
        ///     Loads the local variable at a specific index onto the evaluation stack, short form.
        /// </summary>
        public static ILEmitterFunc Ldloc_S(LocalBuilder localBuilder) => (in ILEmitter il) => il.Ldloc_S(localBuilder);

        /// <summary>
        ///     Loads the local variable at a specific index onto the evaluation stack, short form.
        /// </summary>
        public static ILEmitterFunc Ldloc_S(short value) => (in ILEmitter il) => il.Ldloc_S(value);

        /// <summary>
        ///     Loads the address of the local variable at a specific index onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloca(short value) => (in ILEmitter il) => il.Ldloca(value);

        /// <summary>
        ///     Loads the address of the local variable at a specific index onto the evaluation stack, short form.
        /// </summary>
        public static ILEmitterFunc Ldloca_S(byte value) => (in ILEmitter il) => il.Ldloca_S(value);

        /// <summary>
        ///     Pushes a null reference (type O) onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldnull() => (in ILEmitter il) => il.Ldnull();

        /// <summary>
        ///     Copies the value type object pointed to by an address to the top of the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldobj(ILEmitterFunc func1, Type type) => (in ILEmitter il) => il.Ldobj(func1, type);

        /// <summary>
        ///     Pushes the value of a static field onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldsfld(FieldInfo fieldInfo) => (in ILEmitter il) => il.Ldsfld(fieldInfo);

        /// <summary>
        ///     Pushes the address of a static field onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldsflda(FieldInfo fieldInfo) => (in ILEmitter il) => il.Ldsflda(fieldInfo);

        /// <summary>
        ///     Pushes a new object reference to a string literal stored in the metadata.
        /// </summary>
        public static ILEmitterFunc Ldstr(string value) => (in ILEmitter il) => il.Ldstr(value);

        /// <summary>
        ///     Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldtoken(MethodInfo methodInfo) => (in ILEmitter il) => il.Ldtoken(methodInfo);

        /// <summary>
        ///     Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldtoken(FieldInfo fieldInfo) => (in ILEmitter il) => il.Ldtoken(fieldInfo);

        /// <summary>
        ///     Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldtoken(Type type) => (in ILEmitter il) => il.Ldtoken(type);

        /// <summary>
        ///     Pushes an unmanaged pointer (type native int) to the native code implementing a particular virtual method associated with a specified object onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldvirtftn(ILEmitterFunc func1, MethodInfo methodInfo) => (in ILEmitter il) => il.Ldvirtftn(func1, methodInfo);

        /// <summary>
        ///     Exits a protected region of code, unconditionally transferring control to a specific target instruction.
        /// </summary>
        public static ILEmitterFunc Leave(Label label) => (in ILEmitter il) => il.Leave(label);

        /// <summary>
        ///     Exits a protected region of code, unconditionally transferring control to a target instruction (short form).
        /// </summary>
        public static ILEmitterFunc Leave_S(Label label) => (in ILEmitter il) => il.Leave_S(label);

        /// <summary>
        ///     Allocates a certain number of bytes from the local dynamic memory pool and pushes the address (a transient pointer, type *) of the first allocated byte onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Localloc(ILEmitterFunc func1) => (in ILEmitter il) => il.Localloc(func1);

        /// <summary>
        ///     Pushes a typed reference to an instance of a specific type onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Mkrefany(ILEmitterFunc func1, Type type) => (in ILEmitter il) => il.Mkrefany(func1, type);

        /// <summary>
        ///     Multiplies two values and pushes the result on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Mul(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Mul(func1, func2);

        /// <summary>
        ///     Multiplies two integer values, performs an overflow check, and pushes the result onto the evaluation stack
        /// </summary>
        public static ILEmitterFunc Mul_Ovf(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Mul_Ovf(func1, func2);

        /// <summary>
        ///     Multiplies two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Mul_Ovf_Un(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Mul_Ovf_Un(func1, func2);

        /// <summary>
        ///     Negates a value and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Neg(ILEmitterFunc func1) => (in ILEmitter il) => il.Neg(func1);

        /// <summary>
        ///     Pushes an object reference to a new zero-based, one-dimensional array whose elements are of a specific type onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Newarr(ILEmitterFunc func1, Type type) => (in ILEmitter il) => il.Newarr(func1, type);

        /// <summary>
        ///     Creates a new object or a new instance of a value type, pushing an object reference (type O) onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Newobj(ConstructorInfo constructorInfo) => (in ILEmitter il) => il.Newobj(constructorInfo);

        /// <summary>
        ///     Fills space if opcodes are patched. No meaningful operation is performed although a processing cycle can be consumed.
        /// </summary>
        public static ILEmitterFunc Nop() => (in ILEmitter il) => il.Nop();

        /// <summary>
        ///     Computes the bitwise complement of the integer value on top of the stack and pushes the result onto the evaluation stack as the same type.
        /// </summary>
        public static ILEmitterFunc Not(ILEmitterFunc func1) => (in ILEmitter il) => il.Not(func1);

        /// <summary>
        ///     Compute the bitwise complement of the two integer values on top of the stack and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Or(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Or(func1, func2);

        /// <summary>
        ///     Removes the value currently on top of the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Pop(ILEmitterFunc func1) => (in ILEmitter il) => il.Pop(func1);

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix1() => (in ILEmitter il) => il.Prefix1();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix2() => (in ILEmitter il) => il.Prefix2();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix3() => (in ILEmitter il) => il.Prefix3();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix4() => (in ILEmitter il) => il.Prefix4();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix5() => (in ILEmitter il) => il.Prefix5();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix6() => (in ILEmitter il) => il.Prefix6();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix7() => (in ILEmitter il) => il.Prefix7();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefixref() => (in ILEmitter il) => il.Prefixref();

        /// <summary>
        ///     Specifies that the subsequent array address operation performs no type check at run time, and that it returns a managed pointer whose mutability is restricted.
        /// </summary>
        public static ILEmitterFunc Readonly() => (in ILEmitter il) => il.Readonly();

        /// <summary>
        ///     Retrieves the type token embedded in a typed reference.
        /// </summary>
        public static ILEmitterFunc Refanytype(ILEmitterFunc func1) => (in ILEmitter il) => il.Refanytype(func1);

        /// <summary>
        ///     Retrieves the address (type &) embedded in a typed reference.
        /// </summary>
        public static ILEmitterFunc Refanyval(ILEmitterFunc func1, Type type) => (in ILEmitter il) => il.Refanyval(func1, type);

        /// <summary>
        ///     Divides two values and pushes the remainder onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Rem(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Rem(func1, func2);

        /// <summary>
        ///     Divides two unsigned values and pushes the remainder onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Rem_Un(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Rem_Un(func1, func2);

        /// <summary>
        ///     Returns from the current method, pushing a return value (if present) from the callee's evaluation stack onto the caller's evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ret() => (in ILEmitter il) => il.Ret();

        /// <summary>
        ///     Rethrows the current exception.
        /// </summary>
        public static ILEmitterFunc Rethrow() => (in ILEmitter il) => il.Rethrow();

        /// <summary>
        ///     Shifts an integer value to the left (in zeroes) by a specified number of bits, pushing the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Shl(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Shl(func1, func2);

        /// <summary>
        ///     Shifts an integer value (in sign) to the right by a specified number of bits, pushing the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Shr(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Shr(func1, func2);

        /// <summary>
        ///     Shifts an unsigned integer value (in zeroes) to the right by a specified number of bits, pushing the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Shr_Un(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Shr_Un(func1, func2);

        /// <summary>
        ///     Pushes the size, in bytes, of a supplied value type onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Sizeof(Type type) => (in ILEmitter il) => il.Sizeof(type);

        /// <summary>
        ///     Stores the value on top of the evaluation stack in the argument slot at a specified index.
        /// </summary>
        public static ILEmitterFunc Starg(ILEmitterFunc func1, short value) => (in ILEmitter il) => il.Starg(func1, value);

        /// <summary>
        ///     Stores the value on top of the evaluation stack in the argument slot at a specified index, short form.
        /// </summary>
        public static ILEmitterFunc Starg_S(ILEmitterFunc func1, byte value) => (in ILEmitter il) => il.Starg_S(func1, value);

        /// <summary>
        ///     Replaces the array element at a given index with the value on the evaluation stack, whose type is specified in the instruction.
        /// </summary>
        public static ILEmitterFunc Stelem(ILEmitterFunc func1, ILEmitterFunc func2, ILEmitterFunc func3, Type type) => (in ILEmitter il) => il.Stelem(func1, func2, func3, type);

        /// <summary>
        ///     Replaces the array element at a given index with the native int value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_I(ILEmitterFunc func1, ILEmitterFunc func2, ILEmitterFunc func3) => (in ILEmitter il) => il.Stelem_I(func1, func2, func3);

        /// <summary>
        ///     Replaces the array element at a given index with the int8 value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_I1(ILEmitterFunc func1, ILEmitterFunc func2, ILEmitterFunc func3) => (in ILEmitter il) => il.Stelem_I1(func1, func2, func3);

        /// <summary>
        ///     Replaces the array element at a given index with the int16 value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_I2(ILEmitterFunc func1, ILEmitterFunc func2, ILEmitterFunc func3) => (in ILEmitter il) => il.Stelem_I2(func1, func2, func3);

        /// <summary>
        ///     Replaces the array element at a given index with the int32 value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_I4(ILEmitterFunc func1, ILEmitterFunc func2, ILEmitterFunc func3) => (in ILEmitter il) => il.Stelem_I4(func1, func2, func3);

        /// <summary>
        ///     Replaces the array element at a given index with the int64 value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_I8(ILEmitterFunc func1, ILEmitterFunc func2, ILEmitterFunc func3) => (in ILEmitter il) => il.Stelem_I8(func1, func2, func3);

        /// <summary>
        ///     Replaces the array element at a given index with the float32 value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_R4(ILEmitterFunc func1, ILEmitterFunc func2, ILEmitterFunc func3) => (in ILEmitter il) => il.Stelem_R4(func1, func2, func3);

        /// <summary>
        ///     Replaces the array element at a given index with the float64 value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_R8(ILEmitterFunc func1, ILEmitterFunc func2, ILEmitterFunc func3) => (in ILEmitter il) => il.Stelem_R8(func1, func2, func3);

        /// <summary>
        ///     Replaces the array element at a given index with the object ref value (type O) on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_Ref(ILEmitterFunc func1, ILEmitterFunc func2, ILEmitterFunc func3) => (in ILEmitter il) => il.Stelem_Ref(func1, func2, func3);

        /// <summary>
        ///     Replaces the value stored in the field of an object reference or pointer with a new value.
        /// </summary>
        public static ILEmitterFunc Stfld(ILEmitterFunc func1, ILEmitterFunc func2, FieldInfo fieldInfo) => (in ILEmitter il) => il.Stfld(func1, func2, fieldInfo);

        /// <summary>
        ///     Stores a value of type native int at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_I(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Stind_I(func1, func2);

        /// <summary>
        ///     Stores a value of type int8 at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_I1(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Stind_I1(func1, func2);

        /// <summary>
        ///     Stores a value of type int16 at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_I2(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Stind_I2(func1, func2);

        /// <summary>
        ///     Stores a value of type int32 at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_I4(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Stind_I4(func1, func2);

        /// <summary>
        ///     Stores a value of type int64 at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_I8(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Stind_I8(func1, func2);

        /// <summary>
        ///     Stores a value of type float32 at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_R4(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Stind_R4(func1, func2);

        /// <summary>
        ///     Stores a value of type float64 at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_R8(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Stind_R8(func1, func2);

        /// <summary>
        ///     Stores a object reference value at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_Ref(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Stind_Ref(func1, func2);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.
        /// </summary>
        public static ILEmitterFunc Stloc(ILEmitterFunc func1, LocalBuilder localBuilder) => (in ILEmitter il) => il.Stloc(func1, localBuilder);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.
        /// </summary>
        public static ILEmitterFunc Stloc(ILEmitterFunc func1, short value) => (in ILEmitter il) => il.Stloc(func1, value);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 0.
        /// </summary>
        public static ILEmitterFunc Stloc_0(ILEmitterFunc func1) => (in ILEmitter il) => il.Stloc_0(func1);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 1.
        /// </summary>
        public static ILEmitterFunc Stloc_1(ILEmitterFunc func1) => (in ILEmitter il) => il.Stloc_1(func1);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 2.
        /// </summary>
        public static ILEmitterFunc Stloc_2(ILEmitterFunc func1) => (in ILEmitter il) => il.Stloc_2(func1);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 3.
        /// </summary>
        public static ILEmitterFunc Stloc_3(ILEmitterFunc func1) => (in ILEmitter il) => il.Stloc_3(func1);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index (short form).
        /// </summary>
        public static ILEmitterFunc Stloc_S(ILEmitterFunc func1, LocalBuilder localBuilder) => (in ILEmitter il) => il.Stloc_S(func1, localBuilder);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index (short form).
        /// </summary>
        public static ILEmitterFunc Stloc_S(ILEmitterFunc func1, byte value) => (in ILEmitter il) => il.Stloc_S(func1, value);

        /// <summary>
        ///     Copies a value of a specified type from the evaluation stack into a supplied memory address.
        /// </summary>
        public static ILEmitterFunc Stobj(ILEmitterFunc func1, ILEmitterFunc func2, Type type) => (in ILEmitter il) => il.Stobj(func1, func2, type);

        /// <summary>
        ///     Replaces the value of a static field with a value from the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stsfld(ILEmitterFunc func1, FieldInfo fieldInfo) => (in ILEmitter il) => il.Stsfld(func1, fieldInfo);

        /// <summary>
        ///     Subtracts one value from another and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Sub(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Sub(func1, func2);

        /// <summary>
        ///     Subtracts one integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Sub_Ovf(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Sub_Ovf(func1, func2);

        /// <summary>
        ///     Subtracts one unsigned integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Sub_Ovf_Un(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Sub_Ovf_Un(func1, func2);

        /// <summary>
        ///     Implements a jump table.
        /// </summary>
        public static ILEmitterFunc Switch(ILEmitterFunc func1, Label[] label) => (in ILEmitter il) => il.Switch(func1, label);

        /// <summary>
        ///     Performs a postfixed method call instruction such that the current method's stack frame is removed before the actual call instruction is executed.
        /// </summary>
        public static ILEmitterFunc Tailcall() => (in ILEmitter il) => il.Tailcall();

        /// <summary>
        ///     Throws the exception object currently on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Throw(ILEmitterFunc func1) => (in ILEmitter il) => il.Throw(func1);

        /// <summary>
        ///     Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.
        /// </summary>
        public static ILEmitterFunc Unaligned(byte value) => (in ILEmitter il) => il.Unaligned(value);

        /// <summary>
        ///     Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.
        /// </summary>
        public static ILEmitterFunc Unaligned(Label label) => (in ILEmitter il) => il.Unaligned(label);

        /// <summary>
        ///     Converts the boxed representation of a value type to its unboxed form.
        /// </summary>
        public static ILEmitterFunc Unbox(ILEmitterFunc func1, Type type) => (in ILEmitter il) => il.Unbox(func1, type);

        /// <summary>
        ///     Converts the boxed representation of a type specified in the instruction to its unboxed form.
        /// </summary>
        public static ILEmitterFunc Unbox_Any(ILEmitterFunc func1, Type type) => (in ILEmitter il) => il.Unbox_Any(func1, type);

        /// <summary>
        ///     Specifies that an address currently atop the evaluation stack might be volatile, and the results of reading that location cannot be cached or that multiple stores to that location cannot be suppressed.
        /// </summary>
        public static ILEmitterFunc Volatile() => (in ILEmitter il) => il.Volatile();

        /// <summary>
        ///     Computes the bitwise XOR of the top two values on the evaluation stack, pushing the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Xor(ILEmitterFunc func1, ILEmitterFunc func2) => (in ILEmitter il) => il.Xor(func1, func2);
    }
}
