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
    public sealed partial class ILEmitter
    {
        /// <summary>
        ///     <para>Adds two values and pushes the result onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Add()
        {
            _logger?.Log(OpCodes.Add);
            _il.Emit(OpCodes.Add);

            return this;
        }

        /// <summary>
        ///     <para>Adds two integers, performs an overflow check, and pushes the result onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Add_Ovf()
        {
            _logger?.Log(OpCodes.Add_Ovf);
            _il.Emit(OpCodes.Add_Ovf);

            return this;
        }

        /// <summary>
        ///     <para>Adds two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Add_Ovf_Un()
        {
            _logger?.Log(OpCodes.Add_Ovf_Un);
            _il.Emit(OpCodes.Add_Ovf_Un);

            return this;
        }

        /// <summary>
        ///     <para>Computes the bitwise AND of two values and pushes the result onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter And()
        {
            _logger?.Log(OpCodes.And);
            _il.Emit(OpCodes.And);

            return this;
        }

        /// <summary>
        ///     <para>Returns an unmanaged pointer to the argument list of the current method.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Arglist()
        {
            _logger?.Log(OpCodes.Arglist);
            _il.Emit(OpCodes.Arglist);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if two values are equal.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Beq(in Label label)
        {
            _logger?.Log(OpCodes.Beq, label);
            _il.Emit(OpCodes.Beq, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if two values are equal.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Beq_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Beq_S, label);
            _il.Emit(OpCodes.Beq_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is greater than or equal to the second value.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Bge(in Label label)
        {
            _logger?.Log(OpCodes.Bge, label);
            _il.Emit(OpCodes.Bge, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is greater than or equal to the second value.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Bge_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Bge_S, label);
            _il.Emit(OpCodes.Bge_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Bge_Un(in Label label)
        {
            _logger?.Log(OpCodes.Bge_Un, label);
            _il.Emit(OpCodes.Bge_Un, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Bge_Un_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Bge_Un_S, label);
            _il.Emit(OpCodes.Bge_Un_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is greater than the second value.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Bgt(in Label label)
        {
            _logger?.Log(OpCodes.Bgt, label);
            _il.Emit(OpCodes.Bgt, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is greater than the second value.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Bgt_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Bgt_S, label);
            _il.Emit(OpCodes.Bgt_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Bgt_Un(in Label label)
        {
            _logger?.Log(OpCodes.Bgt_Un, label);
            _il.Emit(OpCodes.Bgt_Un, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Bgt_Un_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Bgt_Un_S, label);
            _il.Emit(OpCodes.Bgt_Un_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is less than or equal to the second value.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Ble(in Label label)
        {
            _logger?.Log(OpCodes.Ble, label);
            _il.Emit(OpCodes.Ble, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is less than or equal to the second value.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Ble_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Ble_S, label);
            _il.Emit(OpCodes.Ble_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Ble_Un(in Label label)
        {
            _logger?.Log(OpCodes.Ble_Un, label);
            _il.Emit(OpCodes.Ble_Un, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Ble_Un_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Ble_Un_S, label);
            _il.Emit(OpCodes.Ble_Un_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is less than the second value.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Blt(in Label label)
        {
            _logger?.Log(OpCodes.Blt, label);
            _il.Emit(OpCodes.Blt, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is less than the second value.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Blt_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Blt_S, label);
            _il.Emit(OpCodes.Blt_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is less than the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Blt_Un(in Label label)
        {
            _logger?.Log(OpCodes.Blt_Un, label);
            _il.Emit(OpCodes.Blt_Un, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is less than the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Blt_Un_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Blt_Un_S, label);
            _il.Emit(OpCodes.Blt_Un_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction when two unsigned integer values or unordered float values are not equal.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Bne_Un(in Label label)
        {
            _logger?.Log(OpCodes.Bne_Un, label);
            _il.Emit(OpCodes.Bne_Un, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) when two unsigned integer values or unordered float values are not equal.</para>
        ///     <para>Pop1_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Bne_Un_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Bne_Un_S, label);
            _il.Emit(OpCodes.Bne_Un_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Converts a value type to an object reference (type O).</para>
        ///     <para>Pop1, Pushref.</para>
        /// </summary>
        public ILEmitter Box(in Type type)
        {
            _logger?.Log(OpCodes.Box, type);
            _il.Emit(OpCodes.Box, type);

            return this;
        }

        /// <summary>
        ///     <para>Unconditionally transfers control to a target instruction.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Br(in Label label)
        {
            _logger?.Log(OpCodes.Br, label);
            _il.Emit(OpCodes.Br, label);

            return this;
        }

        /// <summary>
        ///     <para>Unconditionally transfers control to a target instruction (short form).</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Br_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Br_S, label);
            _il.Emit(OpCodes.Br_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Signals the Common Language Infrastructure (CLI) to inform the debugger that a break point has been tripped.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Break()
        {
            _logger?.Log(OpCodes.Break);
            _il.Emit(OpCodes.Break);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if value is false, a null reference (Nothing in Visual Basic), or zero.</para>
        ///     <para>Popi, Push0.</para>
        /// </summary>
        public ILEmitter Brfalse(in Label label)
        {
            _logger?.Log(OpCodes.Brfalse, label);
            _il.Emit(OpCodes.Brfalse, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if value is false, a null reference, or zero.</para>
        ///     <para>Popi, Push0.</para>
        /// </summary>
        public ILEmitter Brfalse_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Brfalse_S, label);
            _il.Emit(OpCodes.Brfalse_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if value is true, not null, or non-zero.</para>
        ///     <para>Popi, Push0.</para>
        /// </summary>
        public ILEmitter Brtrue(in Label label)
        {
            _logger?.Log(OpCodes.Brtrue, label);
            _il.Emit(OpCodes.Brtrue, label);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if value is true, not null, or non-zero.</para>
        ///     <para>Popi, Push0.</para>
        /// </summary>
        public ILEmitter Brtrue_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Brtrue_S, label);
            _il.Emit(OpCodes.Brtrue_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Calls the method indicated by the passed method descriptor.</para>
        ///     <para>Varpop, Varpush.</para>
        /// </summary>
        public ILEmitter Call(in MethodInfo methodInfo)
        {
            _logger?.Log(OpCodes.Call, methodInfo);
            _il.Emit(OpCodes.Call, methodInfo);

            return this;
        }

        /// <summary>
        ///     <para>Calls the method indicated by the passed method descriptor.</para>
        ///     <para>Varpop, Varpush.</para>
        /// </summary>
        public ILEmitter Call(in ConstructorInfo constructorInfo)
        {
            _logger?.Log(OpCodes.Call, constructorInfo);
            _il.Emit(OpCodes.Call, constructorInfo);

            return this;
        }

        /// <summary>
        ///     <para>Calls a late-bound method on an object, pushing the return value onto the evaluation stack.</para>
        ///     <para>Varpop, Varpush.</para>
        /// </summary>
        public ILEmitter Callvirt(in MethodInfo methodInfo)
        {
            _logger?.Log(OpCodes.Callvirt, methodInfo);
            _il.Emit(OpCodes.Callvirt, methodInfo);

            return this;
        }

        /// <summary>
        ///     <para>Attempts to cast an object passed by reference to the specified class.</para>
        ///     <para>Popref, Pushref.</para>
        /// </summary>
        public ILEmitter Castclass(in Type type)
        {
            _logger?.Log(OpCodes.Castclass, type);
            _il.Emit(OpCodes.Castclass, type);

            return this;
        }

        /// <summary>
        ///     <para>Compares two values. If they are equal, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Ceq()
        {
            _logger?.Log(OpCodes.Ceq);
            _il.Emit(OpCodes.Ceq);

            return this;
        }

        /// <summary>
        ///     <para>Compares two values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Cgt()
        {
            _logger?.Log(OpCodes.Cgt);
            _il.Emit(OpCodes.Cgt);

            return this;
        }

        /// <summary>
        ///     <para>Compares two unsigned or unordered values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Cgt_Un()
        {
            _logger?.Log(OpCodes.Cgt_Un);
            _il.Emit(OpCodes.Cgt_Un);

            return this;
        }

        /// <summary>
        ///     <para>Throws ArithmeticException if value is not a finite number.</para>
        ///     <para>Pop1, Pushr8.</para>
        /// </summary>
        public ILEmitter Ckfinite()
        {
            _logger?.Log(OpCodes.Ckfinite);
            _il.Emit(OpCodes.Ckfinite);

            return this;
        }

        /// <summary>
        ///     <para>Compares two values. If the first value is less than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Clt()
        {
            _logger?.Log(OpCodes.Clt);
            _il.Emit(OpCodes.Clt);

            return this;
        }

        /// <summary>
        ///     <para>Compares the unsigned or unordered values value1 and value2. If value1 is less than value2, then the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Clt_Un()
        {
            _logger?.Log(OpCodes.Clt_Un);
            _il.Emit(OpCodes.Clt_Un);

            return this;
        }

        /// <summary>
        ///     <para>Constrains the type on which a virtual method call is made.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Constrained(in Type type)
        {
            _logger?.Log(OpCodes.Constrained, type);
            _il.Emit(OpCodes.Constrained, type);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to native int.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I()
        {
            _logger?.Log(OpCodes.Conv_I);
            _il.Emit(OpCodes.Conv_I);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to int8, then extends (pads) it to int32.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I1()
        {
            _logger?.Log(OpCodes.Conv_I1);
            _il.Emit(OpCodes.Conv_I1);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to int16, then extends (pads) it to int32.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I2()
        {
            _logger?.Log(OpCodes.Conv_I2);
            _il.Emit(OpCodes.Conv_I2);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to int32.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I4()
        {
            _logger?.Log(OpCodes.Conv_I4);
            _il.Emit(OpCodes.Conv_I4);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to int64.</para>
        ///     <para>Pop1, Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_I8()
        {
            _logger?.Log(OpCodes.Conv_I8);
            _il.Emit(OpCodes.Conv_I8);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to signed native int, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I()
        {
            _logger?.Log(OpCodes.Conv_Ovf_I);
            _il.Emit(OpCodes.Conv_Ovf_I);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to signed int8 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I1()
        {
            _logger?.Log(OpCodes.Conv_Ovf_I1);
            _il.Emit(OpCodes.Conv_Ovf_I1);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to signed int8 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I1_Un()
        {
            _logger?.Log(OpCodes.Conv_Ovf_I1_Un);
            _il.Emit(OpCodes.Conv_Ovf_I1_Un);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to signed int16 and extending it to int32, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I2()
        {
            _logger?.Log(OpCodes.Conv_Ovf_I2);
            _il.Emit(OpCodes.Conv_Ovf_I2);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to signed int16 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I2_Un()
        {
            _logger?.Log(OpCodes.Conv_Ovf_I2_Un);
            _il.Emit(OpCodes.Conv_Ovf_I2_Un);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to signed int32, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I4()
        {
            _logger?.Log(OpCodes.Conv_Ovf_I4);
            _il.Emit(OpCodes.Conv_Ovf_I4);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to signed int32, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I4_Un()
        {
            _logger?.Log(OpCodes.Conv_Ovf_I4_Un);
            _il.Emit(OpCodes.Conv_Ovf_I4_Un);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to signed int64, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I8()
        {
            _logger?.Log(OpCodes.Conv_Ovf_I8);
            _il.Emit(OpCodes.Conv_Ovf_I8);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to signed int64, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I8_Un()
        {
            _logger?.Log(OpCodes.Conv_Ovf_I8_Un);
            _il.Emit(OpCodes.Conv_Ovf_I8_Un);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to signed native int, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I_Un()
        {
            _logger?.Log(OpCodes.Conv_Ovf_I_Un);
            _il.Emit(OpCodes.Conv_Ovf_I_Un);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to unsigned native int, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U()
        {
            _logger?.Log(OpCodes.Conv_Ovf_U);
            _il.Emit(OpCodes.Conv_Ovf_U);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U1()
        {
            _logger?.Log(OpCodes.Conv_Ovf_U1);
            _il.Emit(OpCodes.Conv_Ovf_U1);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U1_Un()
        {
            _logger?.Log(OpCodes.Conv_Ovf_U1_Un);
            _il.Emit(OpCodes.Conv_Ovf_U1_Un);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U2()
        {
            _logger?.Log(OpCodes.Conv_Ovf_U2);
            _il.Emit(OpCodes.Conv_Ovf_U2);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U2_Un()
        {
            _logger?.Log(OpCodes.Conv_Ovf_U2_Un);
            _il.Emit(OpCodes.Conv_Ovf_U2_Un);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to unsigned int32, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U4()
        {
            _logger?.Log(OpCodes.Conv_Ovf_U4);
            _il.Emit(OpCodes.Conv_Ovf_U4);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to unsigned int32, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U4_Un()
        {
            _logger?.Log(OpCodes.Conv_Ovf_U4_Un);
            _il.Emit(OpCodes.Conv_Ovf_U4_Un);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to unsigned int64, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U8()
        {
            _logger?.Log(OpCodes.Conv_Ovf_U8);
            _il.Emit(OpCodes.Conv_Ovf_U8);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to unsigned int64, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U8_Un()
        {
            _logger?.Log(OpCodes.Conv_Ovf_U8_Un);
            _il.Emit(OpCodes.Conv_Ovf_U8_Un);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to unsigned native int, throwing OverflowException on overflow.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U_Un()
        {
            _logger?.Log(OpCodes.Conv_Ovf_U_Un);
            _il.Emit(OpCodes.Conv_Ovf_U_Un);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to float32.</para>
        ///     <para>Pop1, Pushr4.</para>
        /// </summary>
        public ILEmitter Conv_R4()
        {
            _logger?.Log(OpCodes.Conv_R4);
            _il.Emit(OpCodes.Conv_R4);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to float32.</para>
        ///     <para>Pop1, Pushr8.</para>
        /// </summary>
        public ILEmitter Conv_R8()
        {
            _logger?.Log(OpCodes.Conv_R8);
            _il.Emit(OpCodes.Conv_R8);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned integer value on top of the evaluation stack to float32.</para>
        ///     <para>Pop1, Pushr8.</para>
        /// </summary>
        public ILEmitter Conv_R_Un()
        {
            _logger?.Log(OpCodes.Conv_R_Un);
            _il.Emit(OpCodes.Conv_R_Un);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to float32.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U()
        {
            _logger?.Log(OpCodes.Conv_U);
            _il.Emit(OpCodes.Conv_U);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to unsigned int8, and extends it to int32.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U1()
        {
            _logger?.Log(OpCodes.Conv_U1);
            _il.Emit(OpCodes.Conv_U1);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to unsigned int16, and extends it to int32.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U2()
        {
            _logger?.Log(OpCodes.Conv_U2);
            _il.Emit(OpCodes.Conv_U2);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to unsigned int32, and extends it to int32.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U4()
        {
            _logger?.Log(OpCodes.Conv_U4);
            _il.Emit(OpCodes.Conv_U4);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to unsigned int64, and extends it to int64.</para>
        ///     <para>Pop1, Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_U8()
        {
            _logger?.Log(OpCodes.Conv_U8);
            _il.Emit(OpCodes.Conv_U8);

            return this;
        }

        /// <summary>
        ///     <para>Copies a specified number bytes from a source address to a destination address.</para>
        ///     <para>Popi_popi_popi, Push0.</para>
        /// </summary>
        public ILEmitter Cpblk()
        {
            _logger?.Log(OpCodes.Cpblk);
            _il.Emit(OpCodes.Cpblk);

            return this;
        }

        /// <summary>
        ///     <para>Copies the value type located at the address of an object (type &, or native int) to the address of the destination object (type &, or native int).</para>
        ///     <para>Popi_popi, Push0.</para>
        /// </summary>
        public ILEmitter Cpobj(in Type type)
        {
            _logger?.Log(OpCodes.Cpobj, type);
            _il.Emit(OpCodes.Cpobj, type);

            return this;
        }

        /// <summary>
        ///     <para>Divides two values and pushes the result as a floating-point (type F) or quotient (type int32) onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Div()
        {
            _logger?.Log(OpCodes.Div);
            _il.Emit(OpCodes.Div);

            return this;
        }

        /// <summary>
        ///     <para>Divides two unsigned integer values and pushes the result (int32) onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Div_Un()
        {
            _logger?.Log(OpCodes.Div_Un);
            _il.Emit(OpCodes.Div_Un);

            return this;
        }

        /// <summary>
        ///     <para>Copies the current topmost value on the evaluation stack, and then pushes the copy onto the evaluation stack.</para>
        ///     <para>Pop1, Push1_push1.</para>
        /// </summary>
        public ILEmitter Dup()
        {
            _logger?.Log(OpCodes.Dup);
            _il.Emit(OpCodes.Dup);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control from the filter clause of an exception back to the Common Language Infrastructure (CLI) exception handler.</para>
        ///     <para>Popi, Push0.</para>
        /// </summary>
        public ILEmitter Endfilter()
        {
            _logger?.Log(OpCodes.Endfilter);
            _il.Emit(OpCodes.Endfilter);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control from the fault or finally clause of an exception block back to the Common Language Infrastructure (CLI) exception handler.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Endfinally()
        {
            _logger?.Log(OpCodes.Endfinally);
            _il.Emit(OpCodes.Endfinally);

            return this;
        }

        /// <summary>
        ///     <para>Initializes a specified block of memory at a specific address to a given size and initial value.</para>
        ///     <para>Popi_popi_popi, Push0.</para>
        /// </summary>
        public ILEmitter Initblk()
        {
            _logger?.Log(OpCodes.Initblk);
            _il.Emit(OpCodes.Initblk);

            return this;
        }

        /// <summary>
        ///     <para>Initializes each field of the value type at a specified address to a null reference or a 0 of the appropriate primitive type.</para>
        ///     <para>Popi, Push0.</para>
        /// </summary>
        public ILEmitter Initobj(in Type type)
        {
            _logger?.Log(OpCodes.Initobj, type);
            _il.Emit(OpCodes.Initobj, type);

            return this;
        }

        /// <summary>
        ///     <para>Tests whether an object reference (type O) is an instance of a particular class.</para>
        ///     <para>Popref, Pushi.</para>
        /// </summary>
        public ILEmitter Isinst(in Type type)
        {
            _logger?.Log(OpCodes.Isinst, type);
            _il.Emit(OpCodes.Isinst, type);

            return this;
        }

        /// <summary>
        ///     <para>Exits current method and jumps to specified method.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Jmp(in MethodInfo methodInfo)
        {
            _logger?.Log(OpCodes.Jmp, methodInfo);
            _il.Emit(OpCodes.Jmp, methodInfo);

            return this;
        }

        /// <summary>
        ///     <para>Loads an argument (referenced by a specified index value) onto the stack.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldarg(in short value)
        {
            _logger?.Log(OpCodes.Ldarg, value);
            _il.Emit(OpCodes.Ldarg, value);

            return this;
        }

        /// <summary>
        ///     <para>Loads the argument at index 0 onto the evaluation stack.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_0()
        {
            _logger?.Log(OpCodes.Ldarg_0);
            _il.Emit(OpCodes.Ldarg_0);

            return this;
        }

        /// <summary>
        ///     <para>Loads the argument at index 1 onto the evaluation stack.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_1()
        {
            _logger?.Log(OpCodes.Ldarg_1);
            _il.Emit(OpCodes.Ldarg_1);

            return this;
        }

        /// <summary>
        ///     <para>Loads the argument at index 2 onto the evaluation stack.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_2()
        {
            _logger?.Log(OpCodes.Ldarg_2);
            _il.Emit(OpCodes.Ldarg_2);

            return this;
        }

        /// <summary>
        ///     <para>Loads the argument at index 3 onto the evaluation stack.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_3()
        {
            _logger?.Log(OpCodes.Ldarg_3);
            _il.Emit(OpCodes.Ldarg_3);

            return this;
        }

        /// <summary>
        ///     <para>Loads the argument (referenced by a specified short form index) onto the evaluation stack.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_S(in byte value)
        {
            _logger?.Log(OpCodes.Ldarg_S, value);
            _il.Emit(OpCodes.Ldarg_S, value);

            return this;
        }

        /// <summary>
        ///     <para>Load an argument address onto the evaluation stack.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldarga(in short value)
        {
            _logger?.Log(OpCodes.Ldarga, value);
            _il.Emit(OpCodes.Ldarga, value);

            return this;
        }

        /// <summary>
        ///     <para>Load an argument address, in short form, onto the evaluation stack.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldarga_S(in byte value)
        {
            _logger?.Log(OpCodes.Ldarga_S, value);
            _il.Emit(OpCodes.Ldarga_S, value);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a supplied value of type int32 onto the evaluation stack as an int32.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4(in int value)
        {
            _logger?.Log(OpCodes.Ldc_I4, value);
            _il.Emit(OpCodes.Ldc_I4, value);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 0 onto the evaluation stack as an int32.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_0()
        {
            _logger?.Log(OpCodes.Ldc_I4_0);
            _il.Emit(OpCodes.Ldc_I4_0);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 1 onto the evaluation stack as an int32.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_1()
        {
            _logger?.Log(OpCodes.Ldc_I4_1);
            _il.Emit(OpCodes.Ldc_I4_1);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 2 onto the evaluation stack as an int32.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_2()
        {
            _logger?.Log(OpCodes.Ldc_I4_2);
            _il.Emit(OpCodes.Ldc_I4_2);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 3 onto the evaluation stack as an int32.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_3()
        {
            _logger?.Log(OpCodes.Ldc_I4_3);
            _il.Emit(OpCodes.Ldc_I4_3);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 4 onto the evaluation stack as an int32.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_4()
        {
            _logger?.Log(OpCodes.Ldc_I4_4);
            _il.Emit(OpCodes.Ldc_I4_4);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 5 onto the evaluation stack as an int32.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_5()
        {
            _logger?.Log(OpCodes.Ldc_I4_5);
            _il.Emit(OpCodes.Ldc_I4_5);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 6 onto the evaluation stack as an int32.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_6()
        {
            _logger?.Log(OpCodes.Ldc_I4_6);
            _il.Emit(OpCodes.Ldc_I4_6);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 7 onto the evaluation stack as an int32.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_7()
        {
            _logger?.Log(OpCodes.Ldc_I4_7);
            _il.Emit(OpCodes.Ldc_I4_7);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 8 onto the evaluation stack as an int32.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_8()
        {
            _logger?.Log(OpCodes.Ldc_I4_8);
            _il.Emit(OpCodes.Ldc_I4_8);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of -1 onto the evaluation stack as an int32.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_M1()
        {
            _logger?.Log(OpCodes.Ldc_I4_M1);
            _il.Emit(OpCodes.Ldc_I4_M1);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the supplied int8 value onto the evaluation stack as an int32, short form.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_S(in byte value)
        {
            _logger?.Log(OpCodes.Ldc_I4_S, value);
            _il.Emit(OpCodes.Ldc_I4_S, value);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the supplied int8 value onto the evaluation stack as an int32, short form.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_S(in sbyte value)
        {
            _logger?.Log(OpCodes.Ldc_I4_S, value);
            _il.Emit(OpCodes.Ldc_I4_S, value);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a supplied value of type int64 onto the evaluation stack as an int64.</para>
        ///     <para>Pop0, Pushi8.</para>
        /// </summary>
        public ILEmitter Ldc_I8(in long value)
        {
            _logger?.Log(OpCodes.Ldc_I8, value);
            _il.Emit(OpCodes.Ldc_I8, value);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a supplied value of type float32 onto the evaluation stack as type F (float).</para>
        ///     <para>Pop0, Pushr4.</para>
        /// </summary>
        public ILEmitter Ldc_R4(in float value)
        {
            _logger?.Log(OpCodes.Ldc_R4, value);
            _il.Emit(OpCodes.Ldc_R4, value);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a supplied value of type float64 onto the evaluation stack as type F (float).</para>
        ///     <para>Pop0, Pushr8.</para>
        /// </summary>
        public ILEmitter Ldc_R8(in double value)
        {
            _logger?.Log(OpCodes.Ldc_R8, value);
            _il.Emit(OpCodes.Ldc_R8, value);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element at a specified array index onto the top of the evaluation stack as the type specified in the instruction.</para>
        ///     <para>Popref_popi, Push1.</para>
        /// </summary>
        public ILEmitter Ldelem(in Type type)
        {
            _logger?.Log(OpCodes.Ldelem, type);
            _il.Emit(OpCodes.Ldelem, type);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type native int at a specified array index onto the top of the evaluation stack as a native int.</para>
        ///     <para>Popref_popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I()
        {
            _logger?.Log(OpCodes.Ldelem_I);
            _il.Emit(OpCodes.Ldelem_I);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type int8 at a specified array index onto the top of the evaluation stack as an int32.</para>
        ///     <para>Popref_popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I1()
        {
            _logger?.Log(OpCodes.Ldelem_I1);
            _il.Emit(OpCodes.Ldelem_I1);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type int16 at a specified array index onto the top of the evaluation stack as an int32.</para>
        ///     <para>Popref_popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I2()
        {
            _logger?.Log(OpCodes.Ldelem_I2);
            _il.Emit(OpCodes.Ldelem_I2);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type int32 at a specified array index onto the top of the evaluation stack as an int32.</para>
        ///     <para>Popref_popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I4()
        {
            _logger?.Log(OpCodes.Ldelem_I4);
            _il.Emit(OpCodes.Ldelem_I4);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type int64 at a specified array index onto the top of the evaluation stack as an int64.</para>
        ///     <para>Popref_popi, Pushi8.</para>
        /// </summary>
        public ILEmitter Ldelem_I8()
        {
            _logger?.Log(OpCodes.Ldelem_I8);
            _il.Emit(OpCodes.Ldelem_I8);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type float32 at a specified array index onto the top of the evaluation stack as type F (float).</para>
        ///     <para>Popref_popi, Pushr4.</para>
        /// </summary>
        public ILEmitter Ldelem_R4()
        {
            _logger?.Log(OpCodes.Ldelem_R4);
            _il.Emit(OpCodes.Ldelem_R4);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type float64 at a specified array index onto the top of the evaluation stack as type F (float).</para>
        ///     <para>Popref_popi, Pushr8.</para>
        /// </summary>
        public ILEmitter Ldelem_R8()
        {
            _logger?.Log(OpCodes.Ldelem_R8);
            _il.Emit(OpCodes.Ldelem_R8);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element containing an object reference at a specified array index onto the top of the evaluation stack as type O (object reference).</para>
        ///     <para>Popref_popi, Pushref.</para>
        /// </summary>
        public ILEmitter Ldelem_Ref()
        {
            _logger?.Log(OpCodes.Ldelem_Ref);
            _il.Emit(OpCodes.Ldelem_Ref);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type unsigned int8 at a specified array index onto the top of the evaluation stack as an int32.</para>
        ///     <para>Popref_popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_U1()
        {
            _logger?.Log(OpCodes.Ldelem_U1);
            _il.Emit(OpCodes.Ldelem_U1);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type unsigned int16 at a specified array index onto the top of the evaluation stack as an int32.</para>
        ///     <para>Popref_popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_U2()
        {
            _logger?.Log(OpCodes.Ldelem_U2);
            _il.Emit(OpCodes.Ldelem_U2);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type unsigned int32 at a specified array index onto the top of the evaluation stack as an int32.</para>
        ///     <para>Popref_popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_U4()
        {
            _logger?.Log(OpCodes.Ldelem_U4);
            _il.Emit(OpCodes.Ldelem_U4);

            return this;
        }

        /// <summary>
        ///     <para>Loads the address of the array element at a specified array index onto the top of the evaluation stack as type & (managed pointer).</para>
        ///     <para>Popref_popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldelema(in Type type)
        {
            _logger?.Log(OpCodes.Ldelema, type);
            _il.Emit(OpCodes.Ldelema, type);

            return this;
        }

        /// <summary>
        ///     <para>Finds the value of a field in the object whose reference is currently on the evaluation stack.</para>
        ///     <para>Popref, Push1.</para>
        /// </summary>
        public ILEmitter Ldfld(in FieldInfo fieldInfo)
        {
            _logger?.Log(OpCodes.Ldfld, fieldInfo);
            _il.Emit(OpCodes.Ldfld, fieldInfo);

            return this;
        }

        /// <summary>
        ///     <para>Finds the address of a field in the object whose reference is currently on the evaluation stack.</para>
        ///     <para>Popref, Pushi.</para>
        /// </summary>
        public ILEmitter Ldflda(in FieldInfo fieldInfo)
        {
            _logger?.Log(OpCodes.Ldflda, fieldInfo);
            _il.Emit(OpCodes.Ldflda, fieldInfo);

            return this;
        }

        /// <summary>
        ///     <para>Pushes an unmanaged pointer (type native int) to the native code implementing a specific method onto the evaluation stack.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldftn(in MethodInfo methodInfo)
        {
            _logger?.Log(OpCodes.Ldftn, methodInfo);
            _il.Emit(OpCodes.Ldftn, methodInfo);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type native int as a native int onto the evaluation stack indirectly.</para>
        ///     <para>Popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I()
        {
            _logger?.Log(OpCodes.Ldind_I);
            _il.Emit(OpCodes.Ldind_I);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type int8 as an int32 onto the evaluation stack indirectly.</para>
        ///     <para>Popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I1()
        {
            _logger?.Log(OpCodes.Ldind_I1);
            _il.Emit(OpCodes.Ldind_I1);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type int16 as an int32 onto the evaluation stack indirectly.</para>
        ///     <para>Popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I2()
        {
            _logger?.Log(OpCodes.Ldind_I2);
            _il.Emit(OpCodes.Ldind_I2);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type int32 as an int32 onto the evaluation stack indirectly.</para>
        ///     <para>Popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I4()
        {
            _logger?.Log(OpCodes.Ldind_I4);
            _il.Emit(OpCodes.Ldind_I4);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type int64 as an int64 onto the evaluation stack indirectly.</para>
        ///     <para>Popi, Pushi8.</para>
        /// </summary>
        public ILEmitter Ldind_I8()
        {
            _logger?.Log(OpCodes.Ldind_I8);
            _il.Emit(OpCodes.Ldind_I8);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type float32 as a type F (float) onto the evaluation stack indirectly.</para>
        ///     <para>Popi, Pushr4.</para>
        /// </summary>
        public ILEmitter Ldind_R4()
        {
            _logger?.Log(OpCodes.Ldind_R4);
            _il.Emit(OpCodes.Ldind_R4);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type float64 as a type F (float) onto the evaluation stack indirectly.</para>
        ///     <para>Popi, Pushr8.</para>
        /// </summary>
        public ILEmitter Ldind_R8()
        {
            _logger?.Log(OpCodes.Ldind_R8);
            _il.Emit(OpCodes.Ldind_R8);

            return this;
        }

        /// <summary>
        ///     <para>Loads an object reference as a type O (object reference) onto the evaluation stack indirectly.</para>
        ///     <para>Popi, Pushref.</para>
        /// </summary>
        public ILEmitter Ldind_Ref()
        {
            _logger?.Log(OpCodes.Ldind_Ref);
            _il.Emit(OpCodes.Ldind_Ref);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type unsigned int8 as an int32 onto the evaluation stack indirectly.</para>
        ///     <para>Popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_U1()
        {
            _logger?.Log(OpCodes.Ldind_U1);
            _il.Emit(OpCodes.Ldind_U1);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type unsigned int16 as an int32 onto the evaluation stack indirectly.</para>
        ///     <para>Popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_U2()
        {
            _logger?.Log(OpCodes.Ldind_U2);
            _il.Emit(OpCodes.Ldind_U2);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type unsigned int32 as an int32 onto the evaluation stack indirectly.</para>
        ///     <para>Popi, Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_U4()
        {
            _logger?.Log(OpCodes.Ldind_U4);
            _il.Emit(OpCodes.Ldind_U4);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the number of elements of a zero-based, one-dimensional array onto the evaluation stack.</para>
        ///     <para>Popref, Pushi.</para>
        /// </summary>
        public ILEmitter Ldlen()
        {
            _logger?.Log(OpCodes.Ldlen);
            _il.Emit(OpCodes.Ldlen);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at a specific index onto the evaluation stack.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldloc(in LocalBuilder localBuilder)
        {
            _logger?.Log(OpCodes.Ldloc, localBuilder);
            _il.Emit(OpCodes.Ldloc, localBuilder);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at a specific index onto the evaluation stack.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldloc(in short value)
        {
            _logger?.Log(OpCodes.Ldloc, value);
            _il.Emit(OpCodes.Ldloc, value);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at index 0 onto the evaluation stack.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_0()
        {
            _logger?.Log(OpCodes.Ldloc_0);
            _il.Emit(OpCodes.Ldloc_0);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at index 1 onto the evaluation stack.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_1()
        {
            _logger?.Log(OpCodes.Ldloc_1);
            _il.Emit(OpCodes.Ldloc_1);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at index 2 onto the evaluation stack.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_2()
        {
            _logger?.Log(OpCodes.Ldloc_2);
            _il.Emit(OpCodes.Ldloc_2);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at index 3 onto the evaluation stack.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_3()
        {
            _logger?.Log(OpCodes.Ldloc_3);
            _il.Emit(OpCodes.Ldloc_3);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at a specific index onto the evaluation stack, short form.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_S(in LocalBuilder localBuilder)
        {
            _logger?.Log(OpCodes.Ldloc_S, localBuilder);
            _il.Emit(OpCodes.Ldloc_S, localBuilder);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at a specific index onto the evaluation stack, short form.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_S(in short value)
        {
            _logger?.Log(OpCodes.Ldloc_S, value);
            _il.Emit(OpCodes.Ldloc_S, value);

            return this;
        }

        /// <summary>
        ///     <para>Loads the address of the local variable at a specific index onto the evaluation stack.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldloca(in short value)
        {
            _logger?.Log(OpCodes.Ldloca, value);
            _il.Emit(OpCodes.Ldloca, value);

            return this;
        }

        /// <summary>
        ///     <para>Loads the address of the local variable at a specific index onto the evaluation stack, short form.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldloca_S(in byte value)
        {
            _logger?.Log(OpCodes.Ldloca_S, value);
            _il.Emit(OpCodes.Ldloca_S, value);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a null reference (type O) onto the evaluation stack.</para>
        ///     <para>Pop0, Pushref.</para>
        /// </summary>
        public ILEmitter Ldnull()
        {
            _logger?.Log(OpCodes.Ldnull);
            _il.Emit(OpCodes.Ldnull);

            return this;
        }

        /// <summary>
        ///     <para>Copies the value type object pointed to by an address to the top of the evaluation stack.</para>
        ///     <para>Popi, Push1.</para>
        /// </summary>
        public ILEmitter Ldobj(in Type type)
        {
            _logger?.Log(OpCodes.Ldobj, type);
            _il.Emit(OpCodes.Ldobj, type);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the value of a static field onto the evaluation stack.</para>
        ///     <para>Pop0, Push1.</para>
        /// </summary>
        public ILEmitter Ldsfld(in FieldInfo fieldInfo)
        {
            _logger?.Log(OpCodes.Ldsfld, fieldInfo);
            _il.Emit(OpCodes.Ldsfld, fieldInfo);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the address of a static field onto the evaluation stack.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldsflda(in FieldInfo fieldInfo)
        {
            _logger?.Log(OpCodes.Ldsflda, fieldInfo);
            _il.Emit(OpCodes.Ldsflda, fieldInfo);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a new object reference to a string literal stored in the metadata.</para>
        ///     <para>Pop0, Pushref.</para>
        /// </summary>
        public ILEmitter Ldstr(in string value)
        {
            _logger?.Log(OpCodes.Ldstr, value);
            _il.Emit(OpCodes.Ldstr, value);

            return this;
        }

        /// <summary>
        ///     <para>Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldtoken(in MethodInfo methodInfo)
        {
            _logger?.Log(OpCodes.Ldtoken, methodInfo);
            _il.Emit(OpCodes.Ldtoken, methodInfo);

            return this;
        }

        /// <summary>
        ///     <para>Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldtoken(in FieldInfo fieldInfo)
        {
            _logger?.Log(OpCodes.Ldtoken, fieldInfo);
            _il.Emit(OpCodes.Ldtoken, fieldInfo);

            return this;
        }

        /// <summary>
        ///     <para>Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Ldtoken(in Type type)
        {
            _logger?.Log(OpCodes.Ldtoken, type);
            _il.Emit(OpCodes.Ldtoken, type);

            return this;
        }

        /// <summary>
        ///     <para>Pushes an unmanaged pointer (type native int) to the native code implementing a particular virtual method associated with a specified object onto the evaluation stack.</para>
        ///     <para>Popref, Pushi.</para>
        /// </summary>
        public ILEmitter Ldvirtftn(in MethodInfo methodInfo)
        {
            _logger?.Log(OpCodes.Ldvirtftn, methodInfo);
            _il.Emit(OpCodes.Ldvirtftn, methodInfo);

            return this;
        }

        /// <summary>
        ///     <para>Exits a protected region of code, unconditionally transferring control to a specific target instruction.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Leave(in Label label)
        {
            _logger?.Log(OpCodes.Leave, label);
            _il.Emit(OpCodes.Leave, label);

            return this;
        }

        /// <summary>
        ///     <para>Exits a protected region of code, unconditionally transferring control to a target instruction (short form).</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Leave_S(in Label label)
        {
            ValidateJump(label);
            _logger?.Log(OpCodes.Leave_S, label);
            _il.Emit(OpCodes.Leave_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Allocates a certain number of bytes from the local dynamic memory pool and pushes the address (a transient pointer, type *) of the first allocated byte onto the evaluation stack.</para>
        ///     <para>Popi, Pushi.</para>
        /// </summary>
        public ILEmitter Localloc()
        {
            _logger?.Log(OpCodes.Localloc);
            _il.Emit(OpCodes.Localloc);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a typed reference to an instance of a specific type onto the evaluation stack.</para>
        ///     <para>Popi, Push1.</para>
        /// </summary>
        public ILEmitter Mkrefany(in Type type)
        {
            _logger?.Log(OpCodes.Mkrefany, type);
            _il.Emit(OpCodes.Mkrefany, type);

            return this;
        }

        /// <summary>
        ///     <para>Multiplies two values and pushes the result on the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Mul()
        {
            _logger?.Log(OpCodes.Mul);
            _il.Emit(OpCodes.Mul);

            return this;
        }

        /// <summary>
        ///     <para>Multiplies two integer values, performs an overflow check, and pushes the result onto the evaluation stack</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Mul_Ovf()
        {
            _logger?.Log(OpCodes.Mul_Ovf);
            _il.Emit(OpCodes.Mul_Ovf);

            return this;
        }

        /// <summary>
        ///     <para>Multiplies two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Mul_Ovf_Un()
        {
            _logger?.Log(OpCodes.Mul_Ovf_Un);
            _il.Emit(OpCodes.Mul_Ovf_Un);

            return this;
        }

        /// <summary>
        ///     <para>Negates a value and pushes the result onto the evaluation stack.</para>
        ///     <para>Pop1, Push1.</para>
        /// </summary>
        public ILEmitter Neg()
        {
            _logger?.Log(OpCodes.Neg);
            _il.Emit(OpCodes.Neg);

            return this;
        }

        /// <summary>
        ///     <para>Pushes an object reference to a new zero-based, one-dimensional array whose elements are of a specific type onto the evaluation stack.</para>
        ///     <para>Popi, Pushref.</para>
        /// </summary>
        public ILEmitter Newarr(in Type type)
        {
            _logger?.Log(OpCodes.Newarr, type);
            _il.Emit(OpCodes.Newarr, type);

            return this;
        }

        /// <summary>
        ///     <para>Creates a new object or a new instance of a value type, pushing an object reference (type O) onto the evaluation stack.</para>
        ///     <para>Varpop, Pushref.</para>
        /// </summary>
        public ILEmitter Newobj(in ConstructorInfo constructorInfo)
        {
            _logger?.Log(OpCodes.Newobj, constructorInfo);
            _il.Emit(OpCodes.Newobj, constructorInfo);

            return this;
        }

        /// <summary>
        ///     <para>Fills space if opcodes are patched. No meaningful operation is performed although a processing cycle can be consumed.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Nop()
        {
            _logger?.Log(OpCodes.Nop);
            _il.Emit(OpCodes.Nop);

            return this;
        }

        /// <summary>
        ///     <para>Computes the bitwise complement of the integer value on top of the stack and pushes the result onto the evaluation stack as the same type.</para>
        ///     <para>Pop1, Push1.</para>
        /// </summary>
        public ILEmitter Not()
        {
            _logger?.Log(OpCodes.Not);
            _il.Emit(OpCodes.Not);

            return this;
        }

        /// <summary>
        ///     <para>Compute the bitwise complement of the two integer values on top of the stack and pushes the result onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Or()
        {
            _logger?.Log(OpCodes.Or);
            _il.Emit(OpCodes.Or);

            return this;
        }

        /// <summary>
        ///     <para>Removes the value currently on top of the evaluation stack.</para>
        ///     <para>Pop1, Push0.</para>
        /// </summary>
        public ILEmitter Pop()
        {
            _logger?.Log(OpCodes.Pop);
            _il.Emit(OpCodes.Pop);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Prefix1()
        {
            _logger?.Log(OpCodes.Prefix1);
            _il.Emit(OpCodes.Prefix1);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Prefix2()
        {
            _logger?.Log(OpCodes.Prefix2);
            _il.Emit(OpCodes.Prefix2);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Prefix3()
        {
            _logger?.Log(OpCodes.Prefix3);
            _il.Emit(OpCodes.Prefix3);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Prefix4()
        {
            _logger?.Log(OpCodes.Prefix4);
            _il.Emit(OpCodes.Prefix4);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Prefix5()
        {
            _logger?.Log(OpCodes.Prefix5);
            _il.Emit(OpCodes.Prefix5);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Prefix6()
        {
            _logger?.Log(OpCodes.Prefix6);
            _il.Emit(OpCodes.Prefix6);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Prefix7()
        {
            _logger?.Log(OpCodes.Prefix7);
            _il.Emit(OpCodes.Prefix7);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Prefixref()
        {
            _logger?.Log(OpCodes.Prefixref);
            _il.Emit(OpCodes.Prefixref);

            return this;
        }

        /// <summary>
        ///     <para>Specifies that the subsequent array address operation performs no type check at run time, and that it returns a managed pointer whose mutability is restricted.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Readonly()
        {
            _logger?.Log(OpCodes.Readonly);
            _il.Emit(OpCodes.Readonly);

            return this;
        }

        /// <summary>
        ///     <para>Retrieves the type token embedded in a typed reference.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Refanytype()
        {
            _logger?.Log(OpCodes.Refanytype);
            _il.Emit(OpCodes.Refanytype);

            return this;
        }

        /// <summary>
        ///     <para>Retrieves the address (type &) embedded in a typed reference.</para>
        ///     <para>Pop1, Pushi.</para>
        /// </summary>
        public ILEmitter Refanyval(in Type type)
        {
            _logger?.Log(OpCodes.Refanyval, type);
            _il.Emit(OpCodes.Refanyval, type);

            return this;
        }

        /// <summary>
        ///     <para>Divides two values and pushes the remainder onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Rem()
        {
            _logger?.Log(OpCodes.Rem);
            _il.Emit(OpCodes.Rem);

            return this;
        }

        /// <summary>
        ///     <para>Divides two unsigned values and pushes the remainder onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Rem_Un()
        {
            _logger?.Log(OpCodes.Rem_Un);
            _il.Emit(OpCodes.Rem_Un);

            return this;
        }

        /// <summary>
        ///     <para>Returns from the current method, pushing a return value (if present) from the callee's evaluation stack onto the caller's evaluation stack.</para>
        ///     <para>Varpop, Push0.</para>
        /// </summary>
        public ILEmitter Ret()
        {
            _logger?.Log(OpCodes.Ret);
            _il.Emit(OpCodes.Ret);

            return this;
        }

        /// <summary>
        ///     <para>Rethrows the current exception.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Rethrow()
        {
            _logger?.Log(OpCodes.Rethrow);
            _il.Emit(OpCodes.Rethrow);

            return this;
        }

        /// <summary>
        ///     <para>Shifts an integer value to the left (in zeroes) by a specified number of bits, pushing the result onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Shl()
        {
            _logger?.Log(OpCodes.Shl);
            _il.Emit(OpCodes.Shl);

            return this;
        }

        /// <summary>
        ///     <para>Shifts an integer value (in sign) to the right by a specified number of bits, pushing the result onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Shr()
        {
            _logger?.Log(OpCodes.Shr);
            _il.Emit(OpCodes.Shr);

            return this;
        }

        /// <summary>
        ///     <para>Shifts an unsigned integer value (in zeroes) to the right by a specified number of bits, pushing the result onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Shr_Un()
        {
            _logger?.Log(OpCodes.Shr_Un);
            _il.Emit(OpCodes.Shr_Un);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the size, in bytes, of a supplied value type onto the evaluation stack.</para>
        ///     <para>Pop0, Pushi.</para>
        /// </summary>
        public ILEmitter Sizeof(in Type type)
        {
            _logger?.Log(OpCodes.Sizeof, type);
            _il.Emit(OpCodes.Sizeof, type);

            return this;
        }

        /// <summary>
        ///     <para>Stores the value on top of the evaluation stack in the argument slot at a specified index.</para>
        ///     <para>Pop1, Push0.</para>
        /// </summary>
        public ILEmitter Starg(in short value)
        {
            _logger?.Log(OpCodes.Starg, value);
            _il.Emit(OpCodes.Starg, value);

            return this;
        }

        /// <summary>
        ///     <para>Stores the value on top of the evaluation stack in the argument slot at a specified index, short form.</para>
        ///     <para>Pop1, Push0.</para>
        /// </summary>
        public ILEmitter Starg_S(in byte value)
        {
            _logger?.Log(OpCodes.Starg_S, value);
            _il.Emit(OpCodes.Starg_S, value);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the value on the evaluation stack, whose type is specified in the instruction.</para>
        ///     <para>Popref_popi_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Stelem(in Type type)
        {
            _logger?.Log(OpCodes.Stelem, type);
            _il.Emit(OpCodes.Stelem, type);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the native int value on the evaluation stack.</para>
        ///     <para>Popref_popi_popi, Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I()
        {
            _logger?.Log(OpCodes.Stelem_I);
            _il.Emit(OpCodes.Stelem_I);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the int8 value on the evaluation stack.</para>
        ///     <para>Popref_popi_popi, Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I1()
        {
            _logger?.Log(OpCodes.Stelem_I1);
            _il.Emit(OpCodes.Stelem_I1);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the int16 value on the evaluation stack.</para>
        ///     <para>Popref_popi_popi, Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I2()
        {
            _logger?.Log(OpCodes.Stelem_I2);
            _il.Emit(OpCodes.Stelem_I2);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the int32 value on the evaluation stack.</para>
        ///     <para>Popref_popi_popi, Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I4()
        {
            _logger?.Log(OpCodes.Stelem_I4);
            _il.Emit(OpCodes.Stelem_I4);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the int64 value on the evaluation stack.</para>
        ///     <para>Popref_popi_popi8, Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I8()
        {
            _logger?.Log(OpCodes.Stelem_I8);
            _il.Emit(OpCodes.Stelem_I8);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the float32 value on the evaluation stack.</para>
        ///     <para>Popref_popi_popr4, Push0.</para>
        /// </summary>
        public ILEmitter Stelem_R4()
        {
            _logger?.Log(OpCodes.Stelem_R4);
            _il.Emit(OpCodes.Stelem_R4);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the float64 value on the evaluation stack.</para>
        ///     <para>Popref_popi_popr8, Push0.</para>
        /// </summary>
        public ILEmitter Stelem_R8()
        {
            _logger?.Log(OpCodes.Stelem_R8);
            _il.Emit(OpCodes.Stelem_R8);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the object ref value (type O) on the evaluation stack.</para>
        ///     <para>Popref_popi_popref, Push0.</para>
        /// </summary>
        public ILEmitter Stelem_Ref()
        {
            _logger?.Log(OpCodes.Stelem_Ref);
            _il.Emit(OpCodes.Stelem_Ref);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the value stored in the field of an object reference or pointer with a new value.</para>
        ///     <para>Popref_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Stfld(in FieldInfo fieldInfo)
        {
            _logger?.Log(OpCodes.Stfld, fieldInfo);
            _il.Emit(OpCodes.Stfld, fieldInfo);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type native int at a supplied address.</para>
        ///     <para>Popi_popi, Push0.</para>
        /// </summary>
        public ILEmitter Stind_I()
        {
            _logger?.Log(OpCodes.Stind_I);
            _il.Emit(OpCodes.Stind_I);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type int8 at a supplied address.</para>
        ///     <para>Popi_popi, Push0.</para>
        /// </summary>
        public ILEmitter Stind_I1()
        {
            _logger?.Log(OpCodes.Stind_I1);
            _il.Emit(OpCodes.Stind_I1);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type int16 at a supplied address.</para>
        ///     <para>Popi_popi, Push0.</para>
        /// </summary>
        public ILEmitter Stind_I2()
        {
            _logger?.Log(OpCodes.Stind_I2);
            _il.Emit(OpCodes.Stind_I2);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type int32 at a supplied address.</para>
        ///     <para>Popi_popi, Push0.</para>
        /// </summary>
        public ILEmitter Stind_I4()
        {
            _logger?.Log(OpCodes.Stind_I4);
            _il.Emit(OpCodes.Stind_I4);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type int64 at a supplied address.</para>
        ///     <para>Popi_popi8, Push0.</para>
        /// </summary>
        public ILEmitter Stind_I8()
        {
            _logger?.Log(OpCodes.Stind_I8);
            _il.Emit(OpCodes.Stind_I8);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type float32 at a supplied address.</para>
        ///     <para>Popi_popr4, Push0.</para>
        /// </summary>
        public ILEmitter Stind_R4()
        {
            _logger?.Log(OpCodes.Stind_R4);
            _il.Emit(OpCodes.Stind_R4);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type float64 at a supplied address.</para>
        ///     <para>Popi_popr8, Push0.</para>
        /// </summary>
        public ILEmitter Stind_R8()
        {
            _logger?.Log(OpCodes.Stind_R8);
            _il.Emit(OpCodes.Stind_R8);

            return this;
        }

        /// <summary>
        ///     <para>Stores a object reference value at a supplied address.</para>
        ///     <para>Popi_popi, Push0.</para>
        /// </summary>
        public ILEmitter Stind_Ref()
        {
            _logger?.Log(OpCodes.Stind_Ref);
            _il.Emit(OpCodes.Stind_Ref);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.</para>
        ///     <para>Pop1, Push0.</para>
        /// </summary>
        public ILEmitter Stloc(in LocalBuilder localBuilder)
        {
            _logger?.Log(OpCodes.Stloc, localBuilder);
            _il.Emit(OpCodes.Stloc, localBuilder);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.</para>
        ///     <para>Pop1, Push0.</para>
        /// </summary>
        public ILEmitter Stloc(in short value)
        {
            _logger?.Log(OpCodes.Stloc, value);
            _il.Emit(OpCodes.Stloc, value);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 0.</para>
        ///     <para>Pop1, Push0.</para>
        /// </summary>
        public ILEmitter Stloc_0()
        {
            _logger?.Log(OpCodes.Stloc_0);
            _il.Emit(OpCodes.Stloc_0);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 1.</para>
        ///     <para>Pop1, Push0.</para>
        /// </summary>
        public ILEmitter Stloc_1()
        {
            _logger?.Log(OpCodes.Stloc_1);
            _il.Emit(OpCodes.Stloc_1);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 2.</para>
        ///     <para>Pop1, Push0.</para>
        /// </summary>
        public ILEmitter Stloc_2()
        {
            _logger?.Log(OpCodes.Stloc_2);
            _il.Emit(OpCodes.Stloc_2);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 3.</para>
        ///     <para>Pop1, Push0.</para>
        /// </summary>
        public ILEmitter Stloc_3()
        {
            _logger?.Log(OpCodes.Stloc_3);
            _il.Emit(OpCodes.Stloc_3);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index (short form).</para>
        ///     <para>Pop1, Push0.</para>
        /// </summary>
        public ILEmitter Stloc_S(in LocalBuilder localBuilder)
        {
            _logger?.Log(OpCodes.Stloc_S, localBuilder);
            _il.Emit(OpCodes.Stloc_S, localBuilder);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index (short form).</para>
        ///     <para>Pop1, Push0.</para>
        /// </summary>
        public ILEmitter Stloc_S(in byte value)
        {
            _logger?.Log(OpCodes.Stloc_S, value);
            _il.Emit(OpCodes.Stloc_S, value);

            return this;
        }

        /// <summary>
        ///     <para>Copies a value of a specified type from the evaluation stack into a supplied memory address.</para>
        ///     <para>Popi_pop1, Push0.</para>
        /// </summary>
        public ILEmitter Stobj(in Type type)
        {
            _logger?.Log(OpCodes.Stobj, type);
            _il.Emit(OpCodes.Stobj, type);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the value of a static field with a value from the evaluation stack.</para>
        ///     <para>Pop1, Push0.</para>
        /// </summary>
        public ILEmitter Stsfld(in FieldInfo fieldInfo)
        {
            _logger?.Log(OpCodes.Stsfld, fieldInfo);
            _il.Emit(OpCodes.Stsfld, fieldInfo);

            return this;
        }

        /// <summary>
        ///     <para>Subtracts one value from another and pushes the result onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Sub()
        {
            _logger?.Log(OpCodes.Sub);
            _il.Emit(OpCodes.Sub);

            return this;
        }

        /// <summary>
        ///     <para>Subtracts one integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Sub_Ovf()
        {
            _logger?.Log(OpCodes.Sub_Ovf);
            _il.Emit(OpCodes.Sub_Ovf);

            return this;
        }

        /// <summary>
        ///     <para>Subtracts one unsigned integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Sub_Ovf_Un()
        {
            _logger?.Log(OpCodes.Sub_Ovf_Un);
            _il.Emit(OpCodes.Sub_Ovf_Un);

            return this;
        }

        /// <summary>
        ///     <para>Implements a jump table.</para>
        ///     <para>Popi, Push0.</para>
        /// </summary>
        public ILEmitter Switch(in Label[] label)
        {
            _logger?.Log(OpCodes.Switch, label);
            _il.Emit(OpCodes.Switch, label);

            return this;
        }

        /// <summary>
        ///     <para>Performs a postfixed method call instruction such that the current method's stack frame is removed before the actual call instruction is executed.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Tailcall()
        {
            _logger?.Log(OpCodes.Tailcall);
            _il.Emit(OpCodes.Tailcall);

            return this;
        }

        /// <summary>
        ///     <para>Throws the exception object currently on the evaluation stack.</para>
        ///     <para>Popref, Push0.</para>
        /// </summary>
        public ILEmitter Throw()
        {
            _logger?.Log(OpCodes.Throw);
            _il.Emit(OpCodes.Throw);

            return this;
        }

        /// <summary>
        ///     <para>Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Unaligned(in byte value)
        {
            _logger?.Log(OpCodes.Unaligned, value);
            _il.Emit(OpCodes.Unaligned, value);

            return this;
        }

        /// <summary>
        ///     <para>Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Unaligned(in Label label)
        {
            _logger?.Log(OpCodes.Unaligned, label);
            _il.Emit(OpCodes.Unaligned, label);

            return this;
        }

        /// <summary>
        ///     <para>Converts the boxed representation of a value type to its unboxed form.</para>
        ///     <para>Popref, Pushi.</para>
        /// </summary>
        public ILEmitter Unbox(in Type type)
        {
            _logger?.Log(OpCodes.Unbox, type);
            _il.Emit(OpCodes.Unbox, type);

            return this;
        }

        /// <summary>
        ///     <para>Converts the boxed representation of a type specified in the instruction to its unboxed form.</para>
        ///     <para>Popref, Push1.</para>
        /// </summary>
        public ILEmitter Unbox_Any(in Type type)
        {
            _logger?.Log(OpCodes.Unbox_Any, type);
            _il.Emit(OpCodes.Unbox_Any, type);

            return this;
        }

        /// <summary>
        ///     <para>Specifies that an address currently atop the evaluation stack might be volatile, and the results of reading that location cannot be cached or that multiple stores to that location cannot be suppressed.</para>
        ///     <para>Pop0, Push0.</para>
        /// </summary>
        public ILEmitter Volatile()
        {
            _logger?.Log(OpCodes.Volatile);
            _il.Emit(OpCodes.Volatile);

            return this;
        }

        /// <summary>
        ///     <para>Computes the bitwise XOR of the top two values on the evaluation stack, pushing the result onto the evaluation stack.</para>
        ///     <para>Pop1_pop1, Push1.</para>
        /// </summary>
        public ILEmitter Xor()
        {
            _logger?.Log(OpCodes.Xor);
            _il.Emit(OpCodes.Xor);

            return this;
        }
    }
}
