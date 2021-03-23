/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Illuminator.Functional
{
    public static class FunExtensions
    {
        /// <summary>
        ///     Adds two values and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter Add(this ILEmitter self)
        {
            return self.Add();
        }

        /// <summary>
        ///     Adds two integers, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter Add_Ovf(this ILEmitter self)
        {
            return self.Add_Ovf();
        }

        /// <summary>
        ///     Adds two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter Add_Ovf_Un(this ILEmitter self)
        {
            return self.Add_Ovf_Un();
        }

        /// <summary>
        ///     Computes the bitwise AND of two values and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter And(this ILEmitter self)
        {
            return self.And();
        }

        /// <summary>
        ///     Returns an unmanaged pointer to the argument list of the current method.
        /// </summary>
        public static ILEmitter Arglist(this ILEmitter self)
        {
            return self.Arglist();
        }

        /// <summary>
        ///     Transfers control to a target instruction if two values are equal.
        /// </summary>
        public static ILEmitter Beq(this ILEmitter self, Label label)
        {
            return self.Beq(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction (short form) if two values are equal.
        /// </summary>
        public static ILEmitter Beq_S(this ILEmitter self, Label label)
        {
            return self.Beq_S(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than or equal to the second value.
        /// </summary>
        public static ILEmitter Bge(this ILEmitter self, Label label)
        {
            return self.Bge(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than or equal to the second value.
        /// </summary>
        public static ILEmitter Bge_S(this ILEmitter self, Label label)
        {
            return self.Bge_S(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Bge_Un(this ILEmitter self, Label label)
        {
            return self.Bge_Un(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Bge_Un_S(this ILEmitter self, Label label)
        {
            return self.Bge_Un_S(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than the second value.
        /// </summary>
        public static ILEmitter Bgt(this ILEmitter self, Label label)
        {
            return self.Bgt(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than the second value.
        /// </summary>
        public static ILEmitter Bgt_S(this ILEmitter self, Label label)
        {
            return self.Bgt_S(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Bgt_Un(this ILEmitter self, Label label)
        {
            return self.Bgt_Un(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Bgt_Un_S(this ILEmitter self, Label label)
        {
            return self.Bgt_Un_S(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than or equal to the second value.
        /// </summary>
        public static ILEmitter Ble(this ILEmitter self, Label label)
        {
            return self.Ble(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than or equal to the second value.
        /// </summary>
        public static ILEmitter Ble_S(this ILEmitter self, Label label)
        {
            return self.Ble_S(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Ble_Un(this ILEmitter self, Label label)
        {
            return self.Ble_Un(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Ble_Un_S(this ILEmitter self, Label label)
        {
            return self.Ble_Un_S(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than the second value.
        /// </summary>
        public static ILEmitter Blt(this ILEmitter self, Label label)
        {
            return self.Blt(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than the second value.
        /// </summary>
        public static ILEmitter Blt_S(this ILEmitter self, Label label)
        {
            return self.Blt_S(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Blt_Un(this ILEmitter self, Label label)
        {
            return self.Blt_Un(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Blt_Un_S(this ILEmitter self, Label label)
        {
            return self.Blt_Un_S(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction when two unsigned integer values or unordered float values are not equal.
        /// </summary>
        public static ILEmitter Bne_Un(this ILEmitter self, Label label)
        {
            return self.Bne_Un(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction (short form) when two unsigned integer values or unordered float values are not equal.
        /// </summary>
        public static ILEmitter Bne_Un_S(this ILEmitter self, Label label)
        {
            return self.Bne_Un_S(label);
        }

        /// <summary>
        ///     Converts a value type to an object reference (type O).
        /// </summary>
        public static ILEmitter Box(this ILEmitter self, Type type)
        {
            return self.Box(type);
        }

        /// <summary>
        ///     Unconditionally transfers control to a target instruction.
        /// </summary>
        public static ILEmitter Br(this ILEmitter self, Label label)
        {
            return self.Br(label);
        }

        /// <summary>
        ///     Unconditionally transfers control to a target instruction (short form).
        /// </summary>
        public static ILEmitter Br_S(this ILEmitter self, Label label)
        {
            return self.Br_S(label);
        }

        /// <summary>
        ///     Signals the Common Language Infrastructure (CLI) to inform the debugger that a break point has been tripped.
        /// </summary>
        public static ILEmitter Break(this ILEmitter self)
        {
            return self.Break();
        }

        /// <summary>
        ///     Transfers control to a target instruction if value is false, a null reference (Nothing in Visual Basic), or zero.
        /// </summary>
        public static ILEmitter Brfalse(this ILEmitter self, Label label)
        {
            return self.Brfalse(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction if value is false, a null reference, or zero.
        /// </summary>
        public static ILEmitter Brfalse_S(this ILEmitter self, Label label)
        {
            return self.Brfalse_S(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction if value is true, not null, or non-zero.
        /// </summary>
        public static ILEmitter Brtrue(this ILEmitter self, Label label)
        {
            return self.Brtrue(label);
        }

        /// <summary>
        ///     Transfers control to a target instruction (short form) if value is true, not null, or non-zero.
        /// </summary>
        public static ILEmitter Brtrue_S(this ILEmitter self, Label label)
        {
            return self.Brtrue_S(label);
        }

        /// <summary>
        ///     Attempts to cast an object passed by reference to the specified class.
        /// </summary>
        public static ILEmitter Castclass(this ILEmitter self, Type type)
        {
            return self.Castclass(type);
        }

        /// <summary>
        ///     Compares two values. If they are equal, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ceq(this ILEmitter self)
        {
            return self.Ceq();
        }

        /// <summary>
        ///     Compares two values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitter Cgt(this ILEmitter self)
        {
            return self.Cgt();
        }

        /// <summary>
        ///     Compares two unsigned or unordered values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitter Cgt_Un(this ILEmitter self)
        {
            return self.Cgt_Un();
        }

        /// <summary>
        ///     Throws ArithmeticException if value is not a finite number.
        /// </summary>
        public static ILEmitter Ckfinite(this ILEmitter self)
        {
            return self.Ckfinite();
        }

        /// <summary>
        ///     Compares two values. If the first value is less than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitter Clt(this ILEmitter self)
        {
            return self.Clt();
        }

        /// <summary>
        ///     Compares the unsigned or unordered values value1 and value2. If value1 is less than value2, then the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
        /// </summary>
        public static ILEmitter Clt_Un(this ILEmitter self)
        {
            return self.Clt_Un();
        }

        /// <summary>
        ///     Constrains the type on which a virtual method call is made.
        /// </summary>
        public static ILEmitter Constrained(this ILEmitter self, Type type)
        {
            return self.Constrained(type);
        }

        /// <summary>
        ///     Converts the value on top of the evaluation stack to native int.
        /// </summary>
        public static ILEmitter Conv_I(this ILEmitter self)
        {
            return self.Conv_I();
        }

        /// <summary>
        ///     Converts the value on top of the evaluation stack to int8, then extends (pads) it to int32.
        /// </summary>
        public static ILEmitter Conv_I1(this ILEmitter self)
        {
            return self.Conv_I1();
        }

        /// <summary>
        ///     Converts the value on top of the evaluation stack to int16, then extends (pads) it to int32.
        /// </summary>
        public static ILEmitter Conv_I2(this ILEmitter self)
        {
            return self.Conv_I2();
        }

        /// <summary>
        ///     Converts the value on top of the evaluation stack to int32.
        /// </summary>
        public static ILEmitter Conv_I4(this ILEmitter self)
        {
            return self.Conv_I4();
        }

        /// <summary>
        ///     Converts the value on top of the evaluation stack to int64.
        /// </summary>
        public static ILEmitter Conv_I8(this ILEmitter self)
        {
            return self.Conv_I8();
        }

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed native int, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_I(this ILEmitter self)
        {
            return self.Conv_Ovf_I();
        }

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed int8 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_I1(this ILEmitter self)
        {
            return self.Conv_Ovf_I1();
        }

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed int8 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_I1_Un(this ILEmitter self)
        {
            return self.Conv_Ovf_I1_Un();
        }

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed int16 and extending it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_I2(this ILEmitter self)
        {
            return self.Conv_Ovf_I2();
        }

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed int16 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_I2_Un(this ILEmitter self)
        {
            return self.Conv_Ovf_I2_Un();
        }

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_I4(this ILEmitter self)
        {
            return self.Conv_Ovf_I4();
        }

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_I4_Un(this ILEmitter self)
        {
            return self.Conv_Ovf_I4_Un();
        }

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to signed int64, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_I8(this ILEmitter self)
        {
            return self.Conv_Ovf_I8();
        }

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed int64, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_I8_Un(this ILEmitter self)
        {
            return self.Conv_Ovf_I8_Un();
        }

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to signed native int, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_I_Un(this ILEmitter self)
        {
            return self.Conv_Ovf_I_Un();
        }

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned native int, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_U(this ILEmitter self)
        {
            return self.Conv_Ovf_U();
        }

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_U1(this ILEmitter self)
        {
            return self.Conv_Ovf_U1();
        }

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_U1_Un(this ILEmitter self)
        {
            return self.Conv_Ovf_U1_Un();
        }

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_U2(this ILEmitter self)
        {
            return self.Conv_Ovf_U2();
        }

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_U2_Un(this ILEmitter self)
        {
            return self.Conv_Ovf_U2_Un();
        }

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_U4(this ILEmitter self)
        {
            return self.Conv_Ovf_U4();
        }

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to unsigned int32, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_U4_Un(this ILEmitter self)
        {
            return self.Conv_Ovf_U4_Un();
        }

        /// <summary>
        ///     Converts the signed value on top of the evaluation stack to unsigned int64, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_U8(this ILEmitter self)
        {
            return self.Conv_Ovf_U8();
        }

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to unsigned int64, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_U8_Un(this ILEmitter self)
        {
            return self.Conv_Ovf_U8_Un();
        }

        /// <summary>
        ///     Converts the unsigned value on top of the evaluation stack to unsigned native int, throwing OverflowException on overflow.
        /// </summary>
        public static ILEmitter Conv_Ovf_U_Un(this ILEmitter self)
        {
            return self.Conv_Ovf_U_Un();
        }

        /// <summary>
        ///     Converts the value on top of the evaluation stack to float32.
        /// </summary>
        public static ILEmitter Conv_R4(this ILEmitter self)
        {
            return self.Conv_R4();
        }

        /// <summary>
        ///     Converts the value on top of the evaluation stack to float32.
        /// </summary>
        public static ILEmitter Conv_R8(this ILEmitter self)
        {
            return self.Conv_R8();
        }

        /// <summary>
        ///     Converts the unsigned integer value on top of the evaluation stack to float32.
        /// </summary>
        public static ILEmitter Conv_R_Un(this ILEmitter self)
        {
            return self.Conv_R_Un();
        }

        /// <summary>
        ///     Converts the value on top of the evaluation stack to float32.
        /// </summary>
        public static ILEmitter Conv_U(this ILEmitter self)
        {
            return self.Conv_U();
        }

        /// <summary>
        ///     Converts the value on top of the evaluation stack to unsigned int8, and extends it to int32.
        /// </summary>
        public static ILEmitter Conv_U1(this ILEmitter self)
        {
            return self.Conv_U1();
        }

        /// <summary>
        ///     Converts the value on top of the evaluation stack to unsigned int16, and extends it to int32.
        /// </summary>
        public static ILEmitter Conv_U2(this ILEmitter self)
        {
            return self.Conv_U2();
        }

        /// <summary>
        ///     Converts the value on top of the evaluation stack to unsigned int32, and extends it to int32.
        /// </summary>
        public static ILEmitter Conv_U4(this ILEmitter self)
        {
            return self.Conv_U4();
        }

        /// <summary>
        ///     Converts the value on top of the evaluation stack to unsigned int64, and extends it to int64.
        /// </summary>
        public static ILEmitter Conv_U8(this ILEmitter self)
        {
            return self.Conv_U8();
        }

        /// <summary>
        ///     Copies a specified number bytes from a source address to a destination address.
        /// </summary>
        public static ILEmitter Cpblk(this ILEmitter self)
        {
            return self.Cpblk();
        }

        /// <summary>
        ///     Copies the value type located at the address of an object (type &, or native int) to the address of the destination object (type &, or native int).
        /// </summary>
        public static ILEmitter Cpobj(this ILEmitter self, Type type)
        {
            return self.Cpobj(type);
        }

        /// <summary>
        ///     Divides two values and pushes the result as a floating-point (type F) or quotient (type int32) onto the evaluation stack.
        /// </summary>
        public static ILEmitter Div(this ILEmitter self)
        {
            return self.Div();
        }

        /// <summary>
        ///     Divides two unsigned integer values and pushes the result (int32) onto the evaluation stack.
        /// </summary>
        public static ILEmitter Div_Un(this ILEmitter self)
        {
            return self.Div_Un();
        }

        /// <summary>
        ///     Copies the current topmost value on the evaluation stack, and then pushes the copy onto the evaluation stack.
        /// </summary>
        public static ILEmitter Dup(this ILEmitter self)
        {
            return self.Dup();
        }

        /// <summary>
        ///     Transfers control from the filter clause of an exception back to the Common Language Infrastructure (CLI) exception handler.
        /// </summary>
        public static ILEmitter Endfilter(this ILEmitter self)
        {
            return self.Endfilter();
        }

        /// <summary>
        ///     Transfers control from the fault or finally clause of an exception block back to the Common Language Infrastructure (CLI) exception handler.
        /// </summary>
        public static ILEmitter Endfinally(this ILEmitter self)
        {
            return self.Endfinally();
        }

        /// <summary>
        ///     Initializes a specified block of memory at a specific address to a given size and initial value.
        /// </summary>
        public static ILEmitter Initblk(this ILEmitter self)
        {
            return self.Initblk();
        }

        /// <summary>
        ///     Initializes each field of the value type at a specified address to a null reference or a 0 of the appropriate primitive type.
        /// </summary>
        public static ILEmitter Initobj(this ILEmitter self, Type type)
        {
            return self.Initobj(type);
        }

        /// <summary>
        ///     Tests whether an object reference (type O) is an instance of a particular class.
        /// </summary>
        public static ILEmitter Isinst(this ILEmitter self, Type type)
        {
            return self.Isinst(type);
        }

        /// <summary>
        ///     Exits current method and jumps to specified method.
        /// </summary>
        public static ILEmitter Jmp(this ILEmitter self, MethodInfo methodInfo)
        {
            return self.Jmp(methodInfo);
        }

        /// <summary>
        ///     Loads an argument (referenced by a specified index value) onto the stack.
        /// </summary>
        public static ILEmitter Ldarg(this ILEmitter self, short value)
        {
            return self.Ldarg(value);
        }

        /// <summary>
        ///     Loads the argument at index 0 onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldarg_0(this ILEmitter self)
        {
            return self.Ldarg_0();
        }

        /// <summary>
        ///     Loads the argument at index 1 onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldarg_1(this ILEmitter self)
        {
            return self.Ldarg_1();
        }

        /// <summary>
        ///     Loads the argument at index 2 onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldarg_2(this ILEmitter self)
        {
            return self.Ldarg_2();
        }

        /// <summary>
        ///     Loads the argument at index 3 onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldarg_3(this ILEmitter self)
        {
            return self.Ldarg_3();
        }

        /// <summary>
        ///     Loads the argument (referenced by a specified short form index) onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldarg_S(this ILEmitter self, byte value)
        {
            return self.Ldarg_S(value);
        }

        /// <summary>
        ///     Load an argument address onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldarga(this ILEmitter self, short value)
        {
            return self.Ldarga(value);
        }

        /// <summary>
        ///     Load an argument address, in short form, onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldarga_S(this ILEmitter self, byte value)
        {
            return self.Ldarga_S(value);
        }

        /// <summary>
        ///     Pushes a supplied value of type int32 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldc_I4(this ILEmitter self, int value)
        {
            return self.Ldc_I4(value);
        }

        /// <summary>
        ///     Pushes the integer value of 0 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldc_I4_0(this ILEmitter self)
        {
            return self.Ldc_I4_0();
        }

        /// <summary>
        ///     Pushes the integer value of 1 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldc_I4_1(this ILEmitter self)
        {
            return self.Ldc_I4_1();
        }

        /// <summary>
        ///     Pushes the integer value of 2 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldc_I4_2(this ILEmitter self)
        {
            return self.Ldc_I4_2();
        }

        /// <summary>
        ///     Pushes the integer value of 3 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldc_I4_3(this ILEmitter self)
        {
            return self.Ldc_I4_3();
        }

        /// <summary>
        ///     Pushes the integer value of 4 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldc_I4_4(this ILEmitter self)
        {
            return self.Ldc_I4_4();
        }

        /// <summary>
        ///     Pushes the integer value of 5 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldc_I4_5(this ILEmitter self)
        {
            return self.Ldc_I4_5();
        }

        /// <summary>
        ///     Pushes the integer value of 6 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldc_I4_6(this ILEmitter self)
        {
            return self.Ldc_I4_6();
        }

        /// <summary>
        ///     Pushes the integer value of 7 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldc_I4_7(this ILEmitter self)
        {
            return self.Ldc_I4_7();
        }

        /// <summary>
        ///     Pushes the integer value of 8 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldc_I4_8(this ILEmitter self)
        {
            return self.Ldc_I4_8();
        }

        /// <summary>
        ///     Pushes the integer value of -1 onto the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldc_I4_M1(this ILEmitter self)
        {
            return self.Ldc_I4_M1();
        }

        /// <summary>
        ///     Pushes the supplied int8 value onto the evaluation stack as an int32, short form.
        /// </summary>
        public static ILEmitter Ldc_I4_S(this ILEmitter self, byte value)
        {
            return self.Ldc_I4_S(value);
        }

        /// <summary>
        ///     Pushes the supplied int8 value onto the evaluation stack as an int32, short form.
        /// </summary>
        public static ILEmitter Ldc_I4_S(this ILEmitter self, sbyte value)
        {
            return self.Ldc_I4_S(value);
        }

        /// <summary>
        ///     Pushes a supplied value of type int64 onto the evaluation stack as an int64.
        /// </summary>
        public static ILEmitter Ldc_I8(this ILEmitter self, long value)
        {
            return self.Ldc_I8(value);
        }

        /// <summary>
        ///     Pushes a supplied value of type float32 onto the evaluation stack as type F (float).
        /// </summary>
        public static ILEmitter Ldc_R4(this ILEmitter self, float value)
        {
            return self.Ldc_R4(value);
        }

        /// <summary>
        ///     Pushes a supplied value of type float64 onto the evaluation stack as type F (float).
        /// </summary>
        public static ILEmitter Ldc_R8(this ILEmitter self, double value)
        {
            return self.Ldc_R8(value);
        }

        /// <summary>
        ///     Loads the element at a specified array index onto the top of the evaluation stack as the type specified in the instruction.
        /// </summary>
        public static ILEmitter Ldelem(this ILEmitter self, Type type)
        {
            return self.Ldelem(type);
        }

        /// <summary>
        ///     Loads the element with type native int at a specified array index onto the top of the evaluation stack as a native int.
        /// </summary>
        public static ILEmitter Ldelem_I(this ILEmitter self)
        {
            return self.Ldelem_I();
        }

        /// <summary>
        ///     Loads the element with type int8 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldelem_I1(this ILEmitter self)
        {
            return self.Ldelem_I1();
        }

        /// <summary>
        ///     Loads the element with type int16 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldelem_I2(this ILEmitter self)
        {
            return self.Ldelem_I2();
        }

        /// <summary>
        ///     Loads the element with type int32 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldelem_I4(this ILEmitter self)
        {
            return self.Ldelem_I4();
        }

        /// <summary>
        ///     Loads the element with type int64 at a specified array index onto the top of the evaluation stack as an int64.
        /// </summary>
        public static ILEmitter Ldelem_I8(this ILEmitter self)
        {
            return self.Ldelem_I8();
        }

        /// <summary>
        ///     Loads the element with type float32 at a specified array index onto the top of the evaluation stack as type F (float).
        /// </summary>
        public static ILEmitter Ldelem_R4(this ILEmitter self)
        {
            return self.Ldelem_R4();
        }

        /// <summary>
        ///     Loads the element with type float64 at a specified array index onto the top of the evaluation stack as type F (float).
        /// </summary>
        public static ILEmitter Ldelem_R8(this ILEmitter self)
        {
            return self.Ldelem_R8();
        }

        /// <summary>
        ///     Loads the element containing an object reference at a specified array index onto the top of the evaluation stack as type O (object reference).
        /// </summary>
        public static ILEmitter Ldelem_Ref(this ILEmitter self)
        {
            return self.Ldelem_Ref();
        }

        /// <summary>
        ///     Loads the element with type unsigned int8 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldelem_U1(this ILEmitter self)
        {
            return self.Ldelem_U1();
        }

        /// <summary>
        ///     Loads the element with type unsigned int16 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldelem_U2(this ILEmitter self)
        {
            return self.Ldelem_U2();
        }

        /// <summary>
        ///     Loads the element with type unsigned int32 at a specified array index onto the top of the evaluation stack as an int32.
        /// </summary>
        public static ILEmitter Ldelem_U4(this ILEmitter self)
        {
            return self.Ldelem_U4();
        }

        /// <summary>
        ///     Loads the address of the array element at a specified array index onto the top of the evaluation stack as type & (managed pointer).
        /// </summary>
        public static ILEmitter Ldelema(this ILEmitter self, Type type)
        {
            return self.Ldelema(type);
        }

        /// <summary>
        ///     Finds the value of a field in the object whose reference is currently on the evaluation stack.
        /// </summary>
        public static ILEmitter Ldfld(this ILEmitter self, FieldInfo fieldInfo)
        {
            return self.Ldfld(fieldInfo);
        }

        /// <summary>
        ///     Finds the address of a field in the object whose reference is currently on the evaluation stack.
        /// </summary>
        public static ILEmitter Ldflda(this ILEmitter self, FieldInfo fieldInfo)
        {
            return self.Ldflda(fieldInfo);
        }

        /// <summary>
        ///     Pushes an unmanaged pointer (type native int) to the native code implementing a specific method onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldftn(this ILEmitter self, MethodInfo methodInfo)
        {
            return self.Ldftn(methodInfo);
        }

        /// <summary>
        ///     Loads a value of type native int as a native int onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitter Ldind_I(this ILEmitter self)
        {
            return self.Ldind_I();
        }

        /// <summary>
        ///     Loads a value of type int8 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitter Ldind_I1(this ILEmitter self)
        {
            return self.Ldind_I1();
        }

        /// <summary>
        ///     Loads a value of type int16 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitter Ldind_I2(this ILEmitter self)
        {
            return self.Ldind_I2();
        }

        /// <summary>
        ///     Loads a value of type int32 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitter Ldind_I4(this ILEmitter self)
        {
            return self.Ldind_I4();
        }

        /// <summary>
        ///     Loads a value of type int64 as an int64 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitter Ldind_I8(this ILEmitter self)
        {
            return self.Ldind_I8();
        }

        /// <summary>
        ///     Loads a value of type float32 as a type F (float) onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitter Ldind_R4(this ILEmitter self)
        {
            return self.Ldind_R4();
        }

        /// <summary>
        ///     Loads a value of type float64 as a type F (float) onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitter Ldind_R8(this ILEmitter self)
        {
            return self.Ldind_R8();
        }

        /// <summary>
        ///     Loads an object reference as a type O (object reference) onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitter Ldind_Ref(this ILEmitter self)
        {
            return self.Ldind_Ref();
        }

        /// <summary>
        ///     Loads a value of type unsigned int8 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitter Ldind_U1(this ILEmitter self)
        {
            return self.Ldind_U1();
        }

        /// <summary>
        ///     Loads a value of type unsigned int16 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitter Ldind_U2(this ILEmitter self)
        {
            return self.Ldind_U2();
        }

        /// <summary>
        ///     Loads a value of type unsigned int32 as an int32 onto the evaluation stack indirectly.
        /// </summary>
        public static ILEmitter Ldind_U4(this ILEmitter self)
        {
            return self.Ldind_U4();
        }

        /// <summary>
        ///     Pushes the number of elements of a zero-based, one-dimensional array onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldlen(this ILEmitter self)
        {
            return self.Ldlen();
        }

        /// <summary>
        ///     Loads the local variable at a specific index onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldloc(this ILEmitter self, LocalBuilder localBuilder)
        {
            return self.Ldloc(localBuilder);
        }

        /// <summary>
        ///     Loads the local variable at a specific index onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldloc(this ILEmitter self, short value)
        {
            return self.Ldloc(value);
        }

        /// <summary>
        ///     Loads the local variable at index 0 onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldloc_0(this ILEmitter self)
        {
            return self.Ldloc_0();
        }

        /// <summary>
        ///     Loads the local variable at index 1 onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldloc_1(this ILEmitter self)
        {
            return self.Ldloc_1();
        }

        /// <summary>
        ///     Loads the local variable at index 2 onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldloc_2(this ILEmitter self)
        {
            return self.Ldloc_2();
        }

        /// <summary>
        ///     Loads the local variable at index 3 onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldloc_3(this ILEmitter self)
        {
            return self.Ldloc_3();
        }

        /// <summary>
        ///     Loads the local variable at a specific index onto the evaluation stack, short form.
        /// </summary>
        public static ILEmitter Ldloc_S(this ILEmitter self, LocalBuilder localBuilder)
        {
            return self.Ldloc_S(localBuilder);
        }

        /// <summary>
        ///     Loads the local variable at a specific index onto the evaluation stack, short form.
        /// </summary>
        public static ILEmitter Ldloc_S(this ILEmitter self, short value)
        {
            return self.Ldloc_S(value);
        }

        /// <summary>
        ///     Loads the address of the local variable at a specific index onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldloca(this ILEmitter self, short value)
        {
            return self.Ldloca(value);
        }

        /// <summary>
        ///     Loads the address of the local variable at a specific index onto the evaluation stack, short form.
        /// </summary>
        public static ILEmitter Ldloca_S(this ILEmitter self, byte value)
        {
            return self.Ldloca_S(value);
        }

        /// <summary>
        ///     Pushes a null reference (type O) onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldnull(this ILEmitter self)
        {
            return self.Ldnull();
        }

        /// <summary>
        ///     Copies the value type object pointed to by an address to the top of the evaluation stack.
        /// </summary>
        public static ILEmitter Ldobj(this ILEmitter self, Type type)
        {
            return self.Ldobj(type);
        }

        /// <summary>
        ///     Pushes the value of a static field onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldsfld(this ILEmitter self, FieldInfo fieldInfo)
        {
            return self.Ldsfld(fieldInfo);
        }

        /// <summary>
        ///     Pushes the address of a static field onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldsflda(this ILEmitter self, FieldInfo fieldInfo)
        {
            return self.Ldsflda(fieldInfo);
        }

        /// <summary>
        ///     Pushes a new object reference to a string literal stored in the metadata.
        /// </summary>
        public static ILEmitter Ldstr(this ILEmitter self, string value)
        {
            return self.Ldstr(value);
        }

        /// <summary>
        ///     Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldtoken(this ILEmitter self, MethodInfo methodInfo)
        {
            return self.Ldtoken(methodInfo);
        }

        /// <summary>
        ///     Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldtoken(this ILEmitter self, FieldInfo fieldInfo)
        {
            return self.Ldtoken(fieldInfo);
        }

        /// <summary>
        ///     Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldtoken(this ILEmitter self, Type type)
        {
            return self.Ldtoken(type);
        }

        /// <summary>
        ///     Pushes an unmanaged pointer (type native int) to the native code implementing a particular virtual method associated with a specified object onto the evaluation stack.
        /// </summary>
        public static ILEmitter Ldvirtftn(this ILEmitter self, MethodInfo methodInfo)
        {
            return self.Ldvirtftn(methodInfo);
        }

        /// <summary>
        ///     Exits a protected region of code, unconditionally transferring control to a specific target instruction.
        /// </summary>
        public static ILEmitter Leave(this ILEmitter self, Label label)
        {
            return self.Leave(label);
        }

        /// <summary>
        ///     Exits a protected region of code, unconditionally transferring control to a target instruction (short form).
        /// </summary>
        public static ILEmitter Leave_S(this ILEmitter self, Label label)
        {
            return self.Leave_S(label);
        }

        /// <summary>
        ///     Allocates a certain number of bytes from the local dynamic memory pool and pushes the address (a transient pointer, type *) of the first allocated byte onto the evaluation stack.
        /// </summary>
        public static ILEmitter Localloc(this ILEmitter self)
        {
            return self.Localloc();
        }

        /// <summary>
        ///     Pushes a typed reference to an instance of a specific type onto the evaluation stack.
        /// </summary>
        public static ILEmitter Mkrefany(this ILEmitter self, Type type)
        {
            return self.Mkrefany(type);
        }

        /// <summary>
        ///     Multiplies two values and pushes the result on the evaluation stack.
        /// </summary>
        public static ILEmitter Mul(this ILEmitter self)
        {
            return self.Mul();
        }

        /// <summary>
        ///     Multiplies two integer values, performs an overflow check, and pushes the result onto the evaluation stack
        /// </summary>
        public static ILEmitter Mul_Ovf(this ILEmitter self)
        {
            return self.Mul_Ovf();
        }

        /// <summary>
        ///     Multiplies two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter Mul_Ovf_Un(this ILEmitter self)
        {
            return self.Mul_Ovf_Un();
        }

        /// <summary>
        ///     Negates a value and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter Neg(this ILEmitter self)
        {
            return self.Neg();
        }

        /// <summary>
        ///     Pushes an object reference to a new zero-based, one-dimensional array whose elements are of a specific type onto the evaluation stack.
        /// </summary>
        public static ILEmitter Newarr(this ILEmitter self, Type type)
        {
            return self.Newarr(type);
        }

        /// <summary>
        ///     Fills space if opcodes are patched. No meaningful operation is performed although a processing cycle can be consumed.
        /// </summary>
        public static ILEmitter Nop(this ILEmitter self)
        {
            return self.Nop();
        }

        /// <summary>
        ///     Computes the bitwise complement of the integer value on top of the stack and pushes the result onto the evaluation stack as the same type.
        /// </summary>
        public static ILEmitter Not(this ILEmitter self)
        {
            return self.Not();
        }

        /// <summary>
        ///     Compute the bitwise complement of the two integer values on top of the stack and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter Or(this ILEmitter self)
        {
            return self.Or();
        }

        /// <summary>
        ///     Removes the value currently on top of the evaluation stack.
        /// </summary>
        public static ILEmitter Pop(this ILEmitter self)
        {
            return self.Pop();
        }

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitter Prefix1(this ILEmitter self)
        {
            return self.Prefix1();
        }

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitter Prefix2(this ILEmitter self)
        {
            return self.Prefix2();
        }

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitter Prefix3(this ILEmitter self)
        {
            return self.Prefix3();
        }

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitter Prefix4(this ILEmitter self)
        {
            return self.Prefix4();
        }

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitter Prefix5(this ILEmitter self)
        {
            return self.Prefix5();
        }

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitter Prefix6(this ILEmitter self)
        {
            return self.Prefix6();
        }

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitter Prefix7(this ILEmitter self)
        {
            return self.Prefix7();
        }

        /// <summary>
        ///     This is a reserved instruction.
        /// </summary>
        public static ILEmitter Prefixref(this ILEmitter self)
        {
            return self.Prefixref();
        }

        /// <summary>
        ///     Specifies that the subsequent array address operation performs no type check at run time, and that it returns a managed pointer whose mutability is restricted.
        /// </summary>
        public static ILEmitter Readonly(this ILEmitter self)
        {
            return self.Readonly();
        }

        /// <summary>
        ///     Retrieves the type token embedded in a typed reference.
        /// </summary>
        public static ILEmitter Refanytype(this ILEmitter self)
        {
            return self.Refanytype();
        }

        /// <summary>
        ///     Retrieves the address (type &) embedded in a typed reference.
        /// </summary>
        public static ILEmitter Refanyval(this ILEmitter self, Type type)
        {
            return self.Refanyval(type);
        }

        /// <summary>
        ///     Divides two values and pushes the remainder onto the evaluation stack.
        /// </summary>
        public static ILEmitter Rem(this ILEmitter self)
        {
            return self.Rem();
        }

        /// <summary>
        ///     Divides two unsigned values and pushes the remainder onto the evaluation stack.
        /// </summary>
        public static ILEmitter Rem_Un(this ILEmitter self)
        {
            return self.Rem_Un();
        }

        /// <summary>
        ///     Rethrows the current exception.
        /// </summary>
        public static ILEmitter Rethrow(this ILEmitter self)
        {
            return self.Rethrow();
        }

        /// <summary>
        ///     Shifts an integer value to the left (in zeroes) by a specified number of bits, pushing the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter Shl(this ILEmitter self)
        {
            return self.Shl();
        }

        /// <summary>
        ///     Shifts an integer value (in sign) to the right by a specified number of bits, pushing the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter Shr(this ILEmitter self)
        {
            return self.Shr();
        }

        /// <summary>
        ///     Shifts an unsigned integer value (in zeroes) to the right by a specified number of bits, pushing the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter Shr_Un(this ILEmitter self)
        {
            return self.Shr_Un();
        }

        /// <summary>
        ///     Pushes the size, in bytes, of a supplied value type onto the evaluation stack.
        /// </summary>
        public static ILEmitter Sizeof(this ILEmitter self, Type type)
        {
            return self.Sizeof(type);
        }

        /// <summary>
        ///     Stores the value on top of the evaluation stack in the argument slot at a specified index.
        /// </summary>
        public static ILEmitter Starg(this ILEmitter self, short value)
        {
            return self.Starg(value);
        }

        /// <summary>
        ///     Stores the value on top of the evaluation stack in the argument slot at a specified index, short form.
        /// </summary>
        public static ILEmitter Starg_S(this ILEmitter self, byte value)
        {
            return self.Starg_S(value);
        }

        /// <summary>
        ///     Replaces the array element at a given index with the value on the evaluation stack, whose type is specified in the instruction.
        /// </summary>
        public static ILEmitter Stelem(this ILEmitter self, Type type)
        {
            return self.Stelem(type);
        }

        /// <summary>
        ///     Replaces the array element at a given index with the native int value on the evaluation stack.
        /// </summary>
        public static ILEmitter Stelem_I(this ILEmitter self)
        {
            return self.Stelem_I();
        }

        /// <summary>
        ///     Replaces the array element at a given index with the int8 value on the evaluation stack.
        /// </summary>
        public static ILEmitter Stelem_I1(this ILEmitter self)
        {
            return self.Stelem_I1();
        }

        /// <summary>
        ///     Replaces the array element at a given index with the int16 value on the evaluation stack.
        /// </summary>
        public static ILEmitter Stelem_I2(this ILEmitter self)
        {
            return self.Stelem_I2();
        }

        /// <summary>
        ///     Replaces the array element at a given index with the int32 value on the evaluation stack.
        /// </summary>
        public static ILEmitter Stelem_I4(this ILEmitter self)
        {
            return self.Stelem_I4();
        }

        /// <summary>
        ///     Replaces the array element at a given index with the int64 value on the evaluation stack.
        /// </summary>
        public static ILEmitter Stelem_I8(this ILEmitter self)
        {
            return self.Stelem_I8();
        }

        /// <summary>
        ///     Replaces the array element at a given index with the float32 value on the evaluation stack.
        /// </summary>
        public static ILEmitter Stelem_R4(this ILEmitter self)
        {
            return self.Stelem_R4();
        }

        /// <summary>
        ///     Replaces the array element at a given index with the float64 value on the evaluation stack.
        /// </summary>
        public static ILEmitter Stelem_R8(this ILEmitter self)
        {
            return self.Stelem_R8();
        }

        /// <summary>
        ///     Replaces the array element at a given index with the object ref value (type O) on the evaluation stack.
        /// </summary>
        public static ILEmitter Stelem_Ref(this ILEmitter self)
        {
            return self.Stelem_Ref();
        }

        /// <summary>
        ///     Replaces the value stored in the field of an object reference or pointer with a new value.
        /// </summary>
        public static ILEmitter Stfld(this ILEmitter self, FieldInfo fieldInfo)
        {
            return self.Stfld(fieldInfo);
        }

        /// <summary>
        ///     Stores a value of type native int at a supplied address.
        /// </summary>
        public static ILEmitter Stind_I(this ILEmitter self)
        {
            return self.Stind_I();
        }

        /// <summary>
        ///     Stores a value of type int8 at a supplied address.
        /// </summary>
        public static ILEmitter Stind_I1(this ILEmitter self)
        {
            return self.Stind_I1();
        }

        /// <summary>
        ///     Stores a value of type int16 at a supplied address.
        /// </summary>
        public static ILEmitter Stind_I2(this ILEmitter self)
        {
            return self.Stind_I2();
        }

        /// <summary>
        ///     Stores a value of type int32 at a supplied address.
        /// </summary>
        public static ILEmitter Stind_I4(this ILEmitter self)
        {
            return self.Stind_I4();
        }

        /// <summary>
        ///     Stores a value of type int64 at a supplied address.
        /// </summary>
        public static ILEmitter Stind_I8(this ILEmitter self)
        {
            return self.Stind_I8();
        }

        /// <summary>
        ///     Stores a value of type float32 at a supplied address.
        /// </summary>
        public static ILEmitter Stind_R4(this ILEmitter self)
        {
            return self.Stind_R4();
        }

        /// <summary>
        ///     Stores a value of type float64 at a supplied address.
        /// </summary>
        public static ILEmitter Stind_R8(this ILEmitter self)
        {
            return self.Stind_R8();
        }

        /// <summary>
        ///     Stores a object reference value at a supplied address.
        /// </summary>
        public static ILEmitter Stind_Ref(this ILEmitter self)
        {
            return self.Stind_Ref();
        }

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.
        /// </summary>
        public static ILEmitter Stloc(this ILEmitter self, LocalBuilder localBuilder)
        {
            return self.Stloc(localBuilder);
        }

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.
        /// </summary>
        public static ILEmitter Stloc(this ILEmitter self, short value)
        {
            return self.Stloc(value);
        }

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 0.
        /// </summary>
        public static ILEmitter Stloc_0(this ILEmitter self)
        {
            return self.Stloc_0();
        }

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 1.
        /// </summary>
        public static ILEmitter Stloc_1(this ILEmitter self)
        {
            return self.Stloc_1();
        }

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 2.
        /// </summary>
        public static ILEmitter Stloc_2(this ILEmitter self)
        {
            return self.Stloc_2();
        }

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 3.
        /// </summary>
        public static ILEmitter Stloc_3(this ILEmitter self)
        {
            return self.Stloc_3();
        }

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index (short form).
        /// </summary>
        public static ILEmitter Stloc_S(this ILEmitter self, LocalBuilder localBuilder)
        {
            return self.Stloc_S(localBuilder);
        }

        /// <summary>
        ///     Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index (short form).
        /// </summary>
        public static ILEmitter Stloc_S(this ILEmitter self, byte value)
        {
            return self.Stloc_S(value);
        }

        /// <summary>
        ///     Copies a value of a specified type from the evaluation stack into a supplied memory address.
        /// </summary>
        public static ILEmitter Stobj(this ILEmitter self, Type type)
        {
            return self.Stobj(type);
        }

        /// <summary>
        ///     Replaces the value of a static field with a value from the evaluation stack.
        /// </summary>
        public static ILEmitter Stsfld(this ILEmitter self, FieldInfo fieldInfo)
        {
            return self.Stsfld(fieldInfo);
        }

        /// <summary>
        ///     Subtracts one value from another and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter Sub(this ILEmitter self)
        {
            return self.Sub();
        }

        /// <summary>
        ///     Subtracts one integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter Sub_Ovf(this ILEmitter self)
        {
            return self.Sub_Ovf();
        }

        /// <summary>
        ///     Subtracts one unsigned integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter Sub_Ovf_Un(this ILEmitter self)
        {
            return self.Sub_Ovf_Un();
        }

        /// <summary>
        ///     Implements a jump table.
        /// </summary>
        public static ILEmitter Switch(this ILEmitter self, Label[] label)
        {
            return self.Switch(label);
        }

        /// <summary>
        ///     Performs a postfixed method call instruction such that the current method's stack frame is removed before the actual call instruction is executed.
        /// </summary>
        public static ILEmitter Tailcall(this ILEmitter self)
        {
            return self.Tailcall();
        }

        /// <summary>
        ///     Throws the exception object currently on the evaluation stack.
        /// </summary>
        public static ILEmitter Throw(this ILEmitter self)
        {
            return self.Throw();
        }

        /// <summary>
        ///     Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.
        /// </summary>
        public static ILEmitter Unaligned(this ILEmitter self, byte value)
        {
            return self.Unaligned(value);
        }

        /// <summary>
        ///     Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.
        /// </summary>
        public static ILEmitter Unaligned(this ILEmitter self, Label label)
        {
            return self.Unaligned(label);
        }

        /// <summary>
        ///     Converts the boxed representation of a value type to its unboxed form.
        /// </summary>
        public static ILEmitter Unbox(this ILEmitter self, Type type)
        {
            return self.Unbox(type);
        }

        /// <summary>
        ///     Converts the boxed representation of a type specified in the instruction to its unboxed form.
        /// </summary>
        public static ILEmitter Unbox_Any(this ILEmitter self, Type type)
        {
            return self.Unbox_Any(type);
        }

        /// <summary>
        ///     Specifies that an address currently atop the evaluation stack might be volatile, and the results of reading that location cannot be cached or that multiple stores to that location cannot be suppressed.
        /// </summary>
        public static ILEmitter Volatile(this ILEmitter self)
        {
            return self.Volatile();
        }

        /// <summary>
        ///     Computes the bitwise XOR of the top two values on the evaluation stack, pushing the result onto the evaluation stack.
        /// </summary>
        public static ILEmitter Xor(this ILEmitter self)
        {
            return self.Xor();
        }
    }
}
