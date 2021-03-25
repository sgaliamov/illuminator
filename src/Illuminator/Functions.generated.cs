/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System;
using System.Reflection;
using System.Reflection.Emit;
using Illuminator.Functional;

namespace Illuminator
{
    public static partial class Functions
    {
        /// <summary>
        ///     Adds two values and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Add(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Add(fun1, fun2);

        /// <summary>
        ///     Adds two integers, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Add_Ovf(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Add_Ovf(fun1, fun2);

        /// <summary>
        ///     Adds two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Add_Ovf_Un(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Add_Ovf_Un(fun1, fun2);

        /// <summary>
        ///     Computes the bitwise AND of two values and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc And(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.And(fun1, fun2);

        /// <summary>
        ///     Returns an unmanaged pointer to the argument list of the current method.
        /// </summary>
        public static ILEmitterFunc Arglist() => il => il.Arglist();

        /// <summary>
        ///     Transfers control to a target instruction if two values are equal.
        /// </summary>
        public static ILEmitterFunc Beq(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Beq(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if two values are equal.
        /// </summary>
        public static ILEmitterFunc Beq_S(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Beq_S(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than or equal to the second value.
        /// </summary>
        public static ILEmitterFunc Bge(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Bge(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than or equal to the second value.
        /// </summary>
        public static ILEmitterFunc Bge_S(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Bge_S(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Bge_Un(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Bge_Un(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Bge_Un_S(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Bge_Un_S(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than the second value.
        /// </summary>
        public static ILEmitterFunc Bgt(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Bgt(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than the second value.
        /// </summary>
        public static ILEmitterFunc Bgt_S(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Bgt_S(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Bgt_Un(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Bgt_Un(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Bgt_Un_S(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Bgt_Un_S(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than or equal to the second value.
        /// </summary>
        public static ILEmitterFunc Ble(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Ble(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than or equal to the second value.
        /// </summary>
        public static ILEmitterFunc Ble_S(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Ble_S(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Ble_Un(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Ble_Un(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Ble_Un_S(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Ble_Un_S(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than the second value.
        /// </summary>
        public static ILEmitterFunc Blt(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Blt(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than the second value.
        /// </summary>
        public static ILEmitterFunc Blt_S(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Blt_S(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Blt_Un(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Blt_Un(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitterFunc Blt_Un_S(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Blt_Un_S(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction when two unsigned integer values or unordered float values are not equal.
        /// </summary>
        public static ILEmitterFunc Bne_Un(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Bne_Un(fun1, fun2, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) when two unsigned integer values or unordered float values are not equal.
        /// </summary>
        public static ILEmitterFunc Bne_Un_S(ILEmitterFunc fun1, ILEmitterFunc fun2, Label label) => il => il.Bne_Un_S(fun1, fun2, label);

        /// <summary>
        ///     Converts a value type to an object reference (type O).
        /// </summary>
        public static ILEmitterFunc Box(ILEmitterFunc fun1, Type type) => il => il.Box(fun1, type);

        /// <summary>
        ///     Unconditionally transfers control to a target instruction.
        /// </summary>
        public static ILEmitterFunc Br(Label label) => il => il.Br(label);

        /// <summary>
        ///     Unconditionally transfers control to a target instruction (short form).
        /// </summary>
        public static ILEmitterFunc Br_S(Label label) => il => il.Br_S(label);

        /// <summary>
        ///     Signals the Common Language Infrastructure (CLI) to inform the debugger that a break point has been tripped.
        /// </summary>
        public static ILEmitterFunc Break() => il => il.Break();

        /// <summary>
        ///     Transfers control to a target instruction if value is false, a null reference (Nothing in Visual Basic), or zero.
        /// </summary>
        public static ILEmitterFunc Brfalse(ILEmitterFunc fun1, Label label) => il => il.Brfalse(fun1, label);

        /// <summary>
        ///     Transfers control to a target instruction if value is false, a null reference, or zero.
        /// </summary>
        public static ILEmitterFunc Brfalse_S(ILEmitterFunc fun1, Label label) => il => il.Brfalse_S(fun1, label);

        /// <summary>
        ///     Transfers control to a target instruction if value is true, not null, or non-zero.
        /// </summary>
        public static ILEmitterFunc Brtrue(ILEmitterFunc fun1, Label label) => il => il.Brtrue(fun1, label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if value is true, not null, or non-zero.
        /// </summary>
        public static ILEmitterFunc Brtrue_S(ILEmitterFunc fun1, Label label) => il => il.Brtrue_S(fun1, label);

        /// <summary>
        ///     Attempts to cast an object passed by reference to the specified class.
        /// </summary>
        public static ILEmitterFunc Castclass(ILEmitterFunc fun1, Type type) => il => il.Castclass(fun1, type);

        /// <summary>
        ///     Compares two values. If they are equal, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ceq(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Ceq(fun1, fun2);

        /// <summary>
        ///     Compares two values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Cgt(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Cgt(fun1, fun2);

        /// <summary>
        ///     Compares two unsigned or unordered values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Cgt_Un(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Cgt_Un(fun1, fun2);

        /// <summary>
        ///     Throws ArithmeticException if value is not a finite number.
        /// </summary>
        public static ILEmitterFunc Ckfinite(ILEmitterFunc fun1) => il => il.Ckfinite(fun1);

        /// <summary>
        ///     Compares two values. If the first value is less than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Clt(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Clt(fun1, fun2);

        /// <summary>
        ///     Compares the unsigned or unordered values value1 and value2. If value1 is less than value2, then the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Clt_Un(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Clt_Un(fun1, fun2);

        /// <summary>
        ///     Constrains the type on which a virtual method call is made.
        /// </summary>
        public static ILEmitterFunc Constrained(Type type) => il => il.Constrained(type);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to native int.
        /// </summary>
        public static ILEmitterFunc Conv_I(ILEmitterFunc fun1) => il => il.Conv_I(fun1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to int8, then extends (pads) it to int32.
        /// </summary>
        public static ILEmitterFunc Conv_I1(ILEmitterFunc fun1) => il => il.Conv_I1(fun1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to int16, then extends (pads) it to int32.
        /// </summary>
        public static ILEmitterFunc Conv_I2(ILEmitterFunc fun1) => il => il.Conv_I2(fun1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to int32.
        /// </summary>
        public static ILEmitterFunc Conv_I4(ILEmitterFunc fun1) => il => il.Conv_I4(fun1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to int64.
        /// </summary>
        public static ILEmitterFunc Conv_I8(ILEmitterFunc fun1) => il => il.Conv_I8(fun1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed native int, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I(ILEmitterFunc fun1) => il => il.Conv_Ovf_I(fun1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed int8 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I1(ILEmitterFunc fun1) => il => il.Conv_Ovf_I1(fun1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed int8 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I1_Un(ILEmitterFunc fun1) => il => il.Conv_Ovf_I1_Un(fun1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed int16 and extending it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I2(ILEmitterFunc fun1) => il => il.Conv_Ovf_I2(fun1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed int16 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I2_Un(ILEmitterFunc fun1) => il => il.Conv_Ovf_I2_Un(fun1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I4(ILEmitterFunc fun1) => il => il.Conv_Ovf_I4(fun1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I4_Un(ILEmitterFunc fun1) => il => il.Conv_Ovf_I4_Un(fun1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed int64, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I8(ILEmitterFunc fun1) => il => il.Conv_Ovf_I8(fun1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed int64, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I8_Un(ILEmitterFunc fun1) => il => il.Conv_Ovf_I8_Un(fun1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed native int, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_I_Un(ILEmitterFunc fun1) => il => il.Conv_Ovf_I_Un(fun1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned native int, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U(ILEmitterFunc fun1) => il => il.Conv_Ovf_U(fun1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U1(ILEmitterFunc fun1) => il => il.Conv_Ovf_U1(fun1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U1_Un(ILEmitterFunc fun1) => il => il.Conv_Ovf_U1_Un(fun1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U2(ILEmitterFunc fun1) => il => il.Conv_Ovf_U2(fun1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U2_Un(ILEmitterFunc fun1) => il => il.Conv_Ovf_U2_Un(fun1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U4(ILEmitterFunc fun1) => il => il.Conv_Ovf_U4(fun1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to unsigned int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U4_Un(ILEmitterFunc fun1) => il => il.Conv_Ovf_U4_Un(fun1);

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int64, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U8(ILEmitterFunc fun1) => il => il.Conv_Ovf_U8(fun1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to unsigned int64, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U8_Un(ILEmitterFunc fun1) => il => il.Conv_Ovf_U8_Un(fun1);

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to unsigned native int, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitterFunc Conv_Ovf_U_Un(ILEmitterFunc fun1) => il => il.Conv_Ovf_U_Un(fun1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to float32.
        /// </summary>
        public static ILEmitterFunc Conv_R4(ILEmitterFunc fun1) => il => il.Conv_R4(fun1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to float32.
        /// </summary>
        public static ILEmitterFunc Conv_R8(ILEmitterFunc fun1) => il => il.Conv_R8(fun1);

        /// <summary>
        ///     Converts the unsigned integer value on top of the evaluation stack to float32.
        /// </summary>
        public static ILEmitterFunc Conv_R_Un(ILEmitterFunc fun1) => il => il.Conv_R_Un(fun1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to float32.
        /// </summary>
        public static ILEmitterFunc Conv_U(ILEmitterFunc fun1) => il => il.Conv_U(fun1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to unsigned int8, and extends it to int32.
        /// </summary>
        public static ILEmitterFunc Conv_U1(ILEmitterFunc fun1) => il => il.Conv_U1(fun1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to unsigned int16, and extends it to int32.
        /// </summary>
        public static ILEmitterFunc Conv_U2(ILEmitterFunc fun1) => il => il.Conv_U2(fun1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to unsigned int32, and extends it to int32.
        /// </summary>
        public static ILEmitterFunc Conv_U4(ILEmitterFunc fun1) => il => il.Conv_U4(fun1);

        /// <summary>
        ///     Converts the value on top of the evaluation stack to unsigned int64, and extends it to int64.
        /// </summary>
        public static ILEmitterFunc Conv_U8(ILEmitterFunc fun1) => il => il.Conv_U8(fun1);

        /// <summary>
        ///     Copies a specified number bytes from a source address to a destination address.
        /// </summary>
        public static ILEmitterFunc Cpblk(ILEmitterFunc fun1, ILEmitterFunc fun2, ILEmitterFunc fun3) => il => il.Cpblk(fun1, fun2, fun3);

        /// <summary>
        ///     Copies the value type located at the address of an object (type &, or native int) to the address of the destination object (type &, or native int).
        /// </summary>
        public static ILEmitterFunc Cpobj(ILEmitterFunc fun1, ILEmitterFunc fun2, Type type) => il => il.Cpobj(fun1, fun2, type);

        /// <summary>
        ///     Divides two values and pushes the result as a floating-point (type F) or quotient (type int32) onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Div(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Div(fun1, fun2);

        /// <summary>
        ///     Divides two unsigned integer values and pushes the result (int32) onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Div_Un(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Div_Un(fun1, fun2);

        /// <summary>
        ///     Copies the current topmost value on the evaluation stack, and then pushes the copy onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Dup(ILEmitterFunc fun1) => il => il.Dup(fun1);

        /// <summary>
        ///     Transfers control from the filter clause of an exception back to the Common Language Infrastructure (CLI) exception handler.
        /// </summary>
        public static ILEmitterFunc Endfilter(ILEmitterFunc fun1) => il => il.Endfilter(fun1);

        /// <summary>
        ///     Transfers control from the fault or finally clause of an exception block back to the Common Language Infrastructure (CLI) exception handler.
        /// </summary>
        public static ILEmitterFunc Endfinally() => il => il.Endfinally();

        /// <summary>
        ///     Initializes a specified block of memory at a specific address to a given size and initial value.
        /// </summary>
        public static ILEmitterFunc Initblk(ILEmitterFunc fun1, ILEmitterFunc fun2, ILEmitterFunc fun3) => il => il.Initblk(fun1, fun2, fun3);

        /// <summary>
        ///     Initializes each field of the value type at a specified address to a null reference or a 0 of the appropriate primitive type.
        /// </summary>
        public static ILEmitterFunc Initobj(ILEmitterFunc fun1, Type type) => il => il.Initobj(fun1, type);

        /// <summary>
        ///     Tests whether an object reference (type O) is an instance of a particular class.
        /// </summary>
        public static ILEmitterFunc Isinst(ILEmitterFunc fun1, Type type) => il => il.Isinst(fun1, type);

        /// <summary>
        ///     Exits current method and jumps to specified method.
        /// </summary>
        public static ILEmitterFunc Jmp(MethodInfo methodInfo) => il => il.Jmp(methodInfo);

        /// <summary>
        ///     Loads an argument (referenced by a specified index value) onto the stack.
        /// </summary>
        public static ILEmitterFunc Ldarg(short value) => il => il.Ldarg(value);

        /// <summary>
        ///     Loads the argument at index 0 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarg_0() => il => il.Ldarg_0();

        /// <summary>
        ///     Loads the argument at index 1 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarg_1() => il => il.Ldarg_1();

        /// <summary>
        ///     Loads the argument at index 2 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarg_2() => il => il.Ldarg_2();

        /// <summary>
        ///     Loads the argument at index 3 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarg_3() => il => il.Ldarg_3();

        /// <summary>
        ///     Loads the argument (referenced by a specified short form index) onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarg_S(byte value) => il => il.Ldarg_S(value);

        /// <summary>
        ///     Load an argument address onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarga(short value) => il => il.Ldarga(value);

        /// <summary>
        ///     Load an argument address, in short form, onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldarga_S(byte value) => il => il.Ldarga_S(value);

        /// <summary>
        ///     Pushes a supplied value of type int32 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4(int value) => il => il.Ldc_I4(value);

        /// <summary>
        ///     Pushes the integer value of 0 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_0() => il => il.Ldc_I4_0();

        /// <summary>
        ///     Pushes the integer value of 1 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_1() => il => il.Ldc_I4_1();

        /// <summary>
        ///     Pushes the integer value of 2 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_2() => il => il.Ldc_I4_2();

        /// <summary>
        ///     Pushes the integer value of 3 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_3() => il => il.Ldc_I4_3();

        /// <summary>
        ///     Pushes the integer value of 4 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_4() => il => il.Ldc_I4_4();

        /// <summary>
        ///     Pushes the integer value of 5 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_5() => il => il.Ldc_I4_5();

        /// <summary>
        ///     Pushes the integer value of 6 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_6() => il => il.Ldc_I4_6();

        /// <summary>
        ///     Pushes the integer value of 7 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_7() => il => il.Ldc_I4_7();

        /// <summary>
        ///     Pushes the integer value of 8 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_8() => il => il.Ldc_I4_8();

        /// <summary>
        ///     Pushes the integer value of -1 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_M1() => il => il.Ldc_I4_M1();

        /// <summary>
        ///     Pushes the supplied int8 value onto the evaluation stack as an int32, short form.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_S(byte value) => il => il.Ldc_I4_S(value);

        /// <summary>
        ///     Pushes the supplied int8 value onto the evaluation stack as an int32, short form.
        /// </summary>
        public static ILEmitterFunc Ldc_I4_S(sbyte value) => il => il.Ldc_I4_S(value);

        /// <summary>
        ///     Pushes a supplied value of type int64 onto the evaluation stack as an int64.
        /// </summary>
        public static ILEmitterFunc Ldc_I8(long value) => il => il.Ldc_I8(value);

        /// <summary>
        ///     Pushes a supplied value of type float32 onto the evaluation stack as type F (float).
        /// </summary>
        public static ILEmitterFunc Ldc_R4(float value) => il => il.Ldc_R4(value);

        /// <summary>
        ///     Pushes a supplied value of type float64 onto the evaluation stack as type F (float).
        /// </summary>
        public static ILEmitterFunc Ldc_R8(double value) => il => il.Ldc_R8(value);

        /// <summary>
        ///     Loads the element at a specified array index onto the top of the evaluation stack as the type specified in the instruction.
        /// </summary>
        public static ILEmitterFunc Ldelem(ILEmitterFunc fun1, ILEmitterFunc fun2, Type type) => il => il.Ldelem(fun1, fun2, type);

        /// <summary>
        ///     Loads the element with type native int at a specified array index onto the top of the evaluation stack as a native int.
        /// </summary>
        public static ILEmitterFunc Ldelem_I(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Ldelem_I(fun1, fun2);

        /// <summary>
        ///     Loads the element with type int8 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldelem_I1(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Ldelem_I1(fun1, fun2);

        /// <summary>
        ///     Loads the element with type int16 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldelem_I2(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Ldelem_I2(fun1, fun2);

        /// <summary>
        ///     Loads the element with type int32 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldelem_I4(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Ldelem_I4(fun1, fun2);

        /// <summary>
        ///     Loads the element with type int64 at a specified array index onto the top of the evaluation stack as an int64.
        /// </summary>
        public static ILEmitterFunc Ldelem_I8(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Ldelem_I8(fun1, fun2);

        /// <summary>
        ///     Loads the element with type float32 at a specified array index onto the top of the evaluation stack as type F (float).
        /// </summary>
        public static ILEmitterFunc Ldelem_R4(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Ldelem_R4(fun1, fun2);

        /// <summary>
        ///     Loads the element with type float64 at a specified array index onto the top of the evaluation stack as type F (float).
        /// </summary>
        public static ILEmitterFunc Ldelem_R8(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Ldelem_R8(fun1, fun2);

        /// <summary>
        ///     Loads the element containing an object reference at a specified array index onto the top of the evaluation stack as type O (object reference).
        /// </summary>
        public static ILEmitterFunc Ldelem_Ref(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Ldelem_Ref(fun1, fun2);

        /// <summary>
        ///     Loads the element with type unsigned int8 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldelem_U1(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Ldelem_U1(fun1, fun2);

        /// <summary>
        ///     Loads the element with type unsigned int16 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldelem_U2(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Ldelem_U2(fun1, fun2);

        /// <summary>
        ///     Loads the element with type unsigned int32 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitterFunc Ldelem_U4(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Ldelem_U4(fun1, fun2);

        /// <summary>
        ///     Loads the address of the array element at a specified array index onto the top of the evaluation stack as type & (managed pointer).
        /// </summary>
        public static ILEmitterFunc Ldelema(ILEmitterFunc fun1, ILEmitterFunc fun2, Type type) => il => il.Ldelema(fun1, fun2, type);

        /// <summary>
        ///     Finds the value of a field in the object whose reference is currently on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldfld(ILEmitterFunc fun1, FieldInfo fieldInfo) => il => il.Ldfld(fun1, fieldInfo);

        /// <summary>
        ///     Finds the address of a field in the object whose reference is currently on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldflda(ILEmitterFunc fun1, FieldInfo fieldInfo) => il => il.Ldflda(fun1, fieldInfo);

        /// <summary>
        ///     Pushes an unmanaged pointer (type native int) to the native code implementing a specific method onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldftn(MethodInfo methodInfo) => il => il.Ldftn(methodInfo);

        /// <summary>
        ///     Loads a value of type native int as a native int onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_I(ILEmitterFunc fun1) => il => il.Ldind_I(fun1);

        /// <summary>
        ///     Loads a value of type int8 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_I1(ILEmitterFunc fun1) => il => il.Ldind_I1(fun1);

        /// <summary>
        ///     Loads a value of type int16 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_I2(ILEmitterFunc fun1) => il => il.Ldind_I2(fun1);

        /// <summary>
        ///     Loads a value of type int32 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_I4(ILEmitterFunc fun1) => il => il.Ldind_I4(fun1);

        /// <summary>
        ///     Loads a value of type int64 as an int64 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_I8(ILEmitterFunc fun1) => il => il.Ldind_I8(fun1);

        /// <summary>
        ///     Loads a value of type float32 as a type F (float) onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_R4(ILEmitterFunc fun1) => il => il.Ldind_R4(fun1);

        /// <summary>
        ///     Loads a value of type float64 as a type F (float) onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_R8(ILEmitterFunc fun1) => il => il.Ldind_R8(fun1);

        /// <summary>
        ///     Loads an object reference as a type O (object reference) onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_Ref(ILEmitterFunc fun1) => il => il.Ldind_Ref(fun1);

        /// <summary>
        ///     Loads a value of type unsigned int8 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_U1(ILEmitterFunc fun1) => il => il.Ldind_U1(fun1);

        /// <summary>
        ///     Loads a value of type unsigned int16 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_U2(ILEmitterFunc fun1) => il => il.Ldind_U2(fun1);

        /// <summary>
        ///     Loads a value of type unsigned int32 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitterFunc Ldind_U4(ILEmitterFunc fun1) => il => il.Ldind_U4(fun1);

        /// <summary>
        ///     Pushes the number of elements of a zero-based, one-dimensional array onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldlen(ILEmitterFunc fun1) => il => il.Ldlen(fun1);

        /// <summary>
        ///     Loads the local variable at a specific index onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloc(LocalBuilder localBuilder) => il => il.Ldloc(localBuilder);

        /// <summary>
        ///     Loads the local variable at a specific index onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloc(short value) => il => il.Ldloc(value);

        /// <summary>
        ///     Loads the local variable at index 0 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloc_0() => il => il.Ldloc_0();

        /// <summary>
        ///     Loads the local variable at index 1 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloc_1() => il => il.Ldloc_1();

        /// <summary>
        ///     Loads the local variable at index 2 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloc_2() => il => il.Ldloc_2();

        /// <summary>
        ///     Loads the local variable at index 3 onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloc_3() => il => il.Ldloc_3();

        /// <summary>
        ///     Loads the local variable at a specific index onto the evaluation stack, short form.
        /// </summary>
        public static ILEmitterFunc Ldloc_S(LocalBuilder localBuilder) => il => il.Ldloc_S(localBuilder);

        /// <summary>
        ///     Loads the local variable at a specific index onto the evaluation stack, short form.
        /// </summary>
        public static ILEmitterFunc Ldloc_S(short value) => il => il.Ldloc_S(value);

        /// <summary>
        ///     Loads the address of the local variable at a specific index onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldloca(short value) => il => il.Ldloca(value);

        /// <summary>
        ///     Loads the address of the local variable at a specific index onto the evaluation stack, short form.
        /// </summary>
        public static ILEmitterFunc Ldloca_S(byte value) => il => il.Ldloca_S(value);

        /// <summary>
        ///     Pushes a null reference (type O) onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldnull() => il => il.Ldnull();

        /// <summary>
        ///     Copies the value type object pointed to by an address to the top of the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldobj(ILEmitterFunc fun1, Type type) => il => il.Ldobj(fun1, type);

        /// <summary>
        ///     Pushes the value of a static field onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldsfld(FieldInfo fieldInfo) => il => il.Ldsfld(fieldInfo);

        /// <summary>
        ///     Pushes the address of a static field onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldsflda(FieldInfo fieldInfo) => il => il.Ldsflda(fieldInfo);

        /// <summary>
        ///     Pushes a new object reference to a string literal stored in the metadata.
        /// </summary>
        public static ILEmitterFunc Ldstr(string value) => il => il.Ldstr(value);

        /// <summary>
        ///     Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldtoken(MethodInfo methodInfo) => il => il.Ldtoken(methodInfo);

        /// <summary>
        ///     Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldtoken(FieldInfo fieldInfo) => il => il.Ldtoken(fieldInfo);

        /// <summary>
        ///     Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldtoken(Type type) => il => il.Ldtoken(type);

        /// <summary>
        ///     Pushes an unmanaged pointer (type native int) to the native code implementing a particular virtual method associated with a specified object onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Ldvirtftn(ILEmitterFunc fun1, MethodInfo methodInfo) => il => il.Ldvirtftn(fun1, methodInfo);

        /// <summary>
        ///     Exits a protected region of code, unconditionally transferring control to a specific target instruction.
        /// </summary>
        public static ILEmitterFunc Leave(Label label) => il => il.Leave(label);

        /// <summary>
        ///     Exits a protected region of code, unconditionally transferring control to a target instruction (short form).
        /// </summary>
        public static ILEmitterFunc Leave_S(Label label) => il => il.Leave_S(label);

        /// <summary>
        ///     Allocates a certain number of bytes from the local dynamic memory pool and pushes the address (a transient pointer, type *) of the first allocated byte onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Localloc(ILEmitterFunc fun1) => il => il.Localloc(fun1);

        /// <summary>
        ///     Pushes a typed reference to an instance of a specific type onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Mkrefany(ILEmitterFunc fun1, Type type) => il => il.Mkrefany(fun1, type);

        /// <summary>
        ///     Multiplies two values and pushes the result on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Mul(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Mul(fun1, fun2);

        /// <summary>
        ///     Multiplies two integer values, performs an overflow check, and pushes the result onto the evaluation stack
        /// </summary>
        public static ILEmitterFunc Mul_Ovf(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Mul_Ovf(fun1, fun2);

        /// <summary>
        ///     Multiplies two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Mul_Ovf_Un(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Mul_Ovf_Un(fun1, fun2);

        /// <summary>
        ///     Negates a value and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Neg(ILEmitterFunc fun1) => il => il.Neg(fun1);

        /// <summary>
        ///     Pushes an object reference to a new zero-based, one-dimensional array whose elements are of a specific type onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Newarr(ILEmitterFunc fun1, Type type) => il => il.Newarr(fun1, type);

        /// <summary>
        ///     Fills space if opcodes are patched. No meaningful operation is performed although a processing cycle can be consumed.
        /// </summary>
        public static ILEmitterFunc Nop() => il => il.Nop();

        /// <summary>
        ///     Computes the bitwise complement of the integer value on top of the stack and pushes the result onto the evaluation stack as the same type.
        /// </summary>
        public static ILEmitterFunc Not(ILEmitterFunc fun1) => il => il.Not(fun1);

        /// <summary>
        ///     Compute the bitwise complement of the two integer values on top of the stack and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Or(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Or(fun1, fun2);

        /// <summary>
        ///     Removes the value currently on top of the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Pop(ILEmitterFunc fun1) => il => il.Pop(fun1);

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix1() => il => il.Prefix1();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix2() => il => il.Prefix2();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix3() => il => il.Prefix3();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix4() => il => il.Prefix4();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix5() => il => il.Prefix5();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix6() => il => il.Prefix6();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefix7() => il => il.Prefix7();

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitterFunc Prefixref() => il => il.Prefixref();

        /// <summary>
        ///     Specifies that the subsequent array address operation performs no type check at run time, and that it returns a managed pointer whose mutability is restricted.
        /// </summary>
        public static ILEmitterFunc Readonly() => il => il.Readonly();

        /// <summary>
        ///     Retrieves the type token embedded in a typed reference.
        /// </summary>
        public static ILEmitterFunc Refanytype(ILEmitterFunc fun1) => il => il.Refanytype(fun1);

        /// <summary>
        ///     Retrieves the address (type &) embedded in a typed reference.
        /// </summary>
        public static ILEmitterFunc Refanyval(ILEmitterFunc fun1, Type type) => il => il.Refanyval(fun1, type);

        /// <summary>
        ///     Divides two values and pushes the remainder onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Rem(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Rem(fun1, fun2);

        /// <summary>
        ///     Divides two unsigned values and pushes the remainder onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Rem_Un(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Rem_Un(fun1, fun2);

        /// <summary>
        ///     Rethrows the current exception.
        /// </summary>
        public static ILEmitterFunc Rethrow() => il => il.Rethrow();

        /// <summary>
        ///     Shifts an integer value to the left (in zeroes) by a specified number of bits, pushing the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Shl(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Shl(fun1, fun2);

        /// <summary>
        ///     Shifts an integer value (in sign) to the right by a specified number of bits, pushing the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Shr(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Shr(fun1, fun2);

        /// <summary>
        ///     Shifts an unsigned integer value (in zeroes) to the right by a specified number of bits, pushing the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Shr_Un(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Shr_Un(fun1, fun2);

        /// <summary>
        ///     Pushes the size, in bytes, of a supplied value type onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Sizeof(Type type) => il => il.Sizeof(type);

        /// <summary>
        ///     Stores the value on top of the evaluation stack in the argument slot at a specified index.
        /// </summary>
        public static ILEmitterFunc Starg(ILEmitterFunc fun1, short value) => il => il.Starg(fun1, value);

        /// <summary>
        ///     Stores the value on top of the evaluation stack in the argument slot at a specified index, short form.
        /// </summary>
        public static ILEmitterFunc Starg_S(ILEmitterFunc fun1, byte value) => il => il.Starg_S(fun1, value);

        /// <summary>
        ///     Replaces the array element at a given index with the value on the evaluation stack, whose type is specified in the instruction.
        /// </summary>
        public static ILEmitterFunc Stelem(ILEmitterFunc fun1, ILEmitterFunc fun2, ILEmitterFunc fun3, Type type) => il => il.Stelem(fun1, fun2, fun3, type);

        /// <summary>
        ///     Replaces the array element at a given index with the native int value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_I(ILEmitterFunc fun1, ILEmitterFunc fun2, ILEmitterFunc fun3) => il => il.Stelem_I(fun1, fun2, fun3);

        /// <summary>
        ///     Replaces the array element at a given index with the int8 value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_I1(ILEmitterFunc fun1, ILEmitterFunc fun2, ILEmitterFunc fun3) => il => il.Stelem_I1(fun1, fun2, fun3);

        /// <summary>
        ///     Replaces the array element at a given index with the int16 value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_I2(ILEmitterFunc fun1, ILEmitterFunc fun2, ILEmitterFunc fun3) => il => il.Stelem_I2(fun1, fun2, fun3);

        /// <summary>
        ///     Replaces the array element at a given index with the int32 value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_I4(ILEmitterFunc fun1, ILEmitterFunc fun2, ILEmitterFunc fun3) => il => il.Stelem_I4(fun1, fun2, fun3);

        /// <summary>
        ///     Replaces the array element at a given index with the int64 value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_I8(ILEmitterFunc fun1, ILEmitterFunc fun2, ILEmitterFunc fun3) => il => il.Stelem_I8(fun1, fun2, fun3);

        /// <summary>
        ///     Replaces the array element at a given index with the float32 value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_R4(ILEmitterFunc fun1, ILEmitterFunc fun2, ILEmitterFunc fun3) => il => il.Stelem_R4(fun1, fun2, fun3);

        /// <summary>
        ///     Replaces the array element at a given index with the float64 value on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_R8(ILEmitterFunc fun1, ILEmitterFunc fun2, ILEmitterFunc fun3) => il => il.Stelem_R8(fun1, fun2, fun3);

        /// <summary>
        ///     Replaces the array element at a given index with the object ref value (type O) on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stelem_Ref(ILEmitterFunc fun1, ILEmitterFunc fun2, ILEmitterFunc fun3) => il => il.Stelem_Ref(fun1, fun2, fun3);

        /// <summary>
        ///     Replaces the value stored in the field of an object reference or pointer with a new value.
        /// </summary>
        public static ILEmitterFunc Stfld(ILEmitterFunc fun1, ILEmitterFunc fun2, FieldInfo fieldInfo) => il => il.Stfld(fun1, fun2, fieldInfo);

        /// <summary>
        ///     Stores a value of type native int at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_I(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Stind_I(fun1, fun2);

        /// <summary>
        ///     Stores a value of type int8 at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_I1(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Stind_I1(fun1, fun2);

        /// <summary>
        ///     Stores a value of type int16 at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_I2(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Stind_I2(fun1, fun2);

        /// <summary>
        ///     Stores a value of type int32 at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_I4(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Stind_I4(fun1, fun2);

        /// <summary>
        ///     Stores a value of type int64 at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_I8(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Stind_I8(fun1, fun2);

        /// <summary>
        ///     Stores a value of type float32 at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_R4(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Stind_R4(fun1, fun2);

        /// <summary>
        ///     Stores a value of type float64 at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_R8(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Stind_R8(fun1, fun2);

        /// <summary>
        ///     Stores a object reference value at a supplied address.
        /// </summary>
        public static ILEmitterFunc Stind_Ref(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Stind_Ref(fun1, fun2);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.
        /// </summary>
        public static ILEmitterFunc Stloc(ILEmitterFunc fun1, LocalBuilder localBuilder) => il => il.Stloc(fun1, localBuilder);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.
        /// </summary>
        public static ILEmitterFunc Stloc(ILEmitterFunc fun1, short value) => il => il.Stloc(fun1, value);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 0.
        /// </summary>
        public static ILEmitterFunc Stloc_0(ILEmitterFunc fun1) => il => il.Stloc_0(fun1);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 1.
        /// </summary>
        public static ILEmitterFunc Stloc_1(ILEmitterFunc fun1) => il => il.Stloc_1(fun1);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 2.
        /// </summary>
        public static ILEmitterFunc Stloc_2(ILEmitterFunc fun1) => il => il.Stloc_2(fun1);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 3.
        /// </summary>
        public static ILEmitterFunc Stloc_3(ILEmitterFunc fun1) => il => il.Stloc_3(fun1);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index (short form).
        /// </summary>
        public static ILEmitterFunc Stloc_S(ILEmitterFunc fun1, LocalBuilder localBuilder) => il => il.Stloc_S(fun1, localBuilder);

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index (short form).
        /// </summary>
        public static ILEmitterFunc Stloc_S(ILEmitterFunc fun1, byte value) => il => il.Stloc_S(fun1, value);

        /// <summary>
        ///     Copies a value of a specified type from the evaluation stack into a supplied memory address.
        /// </summary>
        public static ILEmitterFunc Stobj(ILEmitterFunc fun1, ILEmitterFunc fun2, Type type) => il => il.Stobj(fun1, fun2, type);

        /// <summary>
        ///     Replaces the value of a static field with a value from the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Stsfld(ILEmitterFunc fun1, FieldInfo fieldInfo) => il => il.Stsfld(fun1, fieldInfo);

        /// <summary>
        ///     Subtracts one value from another and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Sub(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Sub(fun1, fun2);

        /// <summary>
        ///     Subtracts one integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Sub_Ovf(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Sub_Ovf(fun1, fun2);

        /// <summary>
        ///     Subtracts one unsigned integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Sub_Ovf_Un(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Sub_Ovf_Un(fun1, fun2);

        /// <summary>
        ///     Implements a jump table.
        /// </summary>
        public static ILEmitterFunc Switch(ILEmitterFunc fun1, Label[] label) => il => il.Switch(fun1, label);

        /// <summary>
        ///     Performs a postfixed method call instruction such that the current method's stack frame is removed before the actual call instruction is executed.
        /// </summary>
        public static ILEmitterFunc Tailcall() => il => il.Tailcall();

        /// <summary>
        ///     Throws the exception object currently on the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Throw(ILEmitterFunc fun1) => il => il.Throw(fun1);

        /// <summary>
        ///     Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.
        /// </summary>
        public static ILEmitterFunc Unaligned(byte value) => il => il.Unaligned(value);

        /// <summary>
        ///     Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.
        /// </summary>
        public static ILEmitterFunc Unaligned(Label label) => il => il.Unaligned(label);

        /// <summary>
        ///     Converts the boxed representation of a value type to its unboxed form.
        /// </summary>
        public static ILEmitterFunc Unbox(ILEmitterFunc fun1, Type type) => il => il.Unbox(fun1, type);

        /// <summary>
        ///     Converts the boxed representation of a type specified in the instruction to its unboxed form.
        /// </summary>
        public static ILEmitterFunc Unbox_Any(ILEmitterFunc fun1, Type type) => il => il.Unbox_Any(fun1, type);

        /// <summary>
        ///     Specifies that an address currently atop the evaluation stack might be volatile, and the results of reading that location cannot be cached or that multiple stores to that location cannot be suppressed.
        /// </summary>
        public static ILEmitterFunc Volatile() => il => il.Volatile();

        /// <summary>
        ///     Computes the bitwise XOR of the top two values on the evaluation stack, pushing the result onto the evaluation stack.
        /// </summary>
        public static ILEmitterFunc Xor(ILEmitterFunc fun1, ILEmitterFunc fun2) => il => il.Xor(fun1, fun2);
    }
}
