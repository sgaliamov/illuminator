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
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Add()
        {
            _il.Emit(OpCodes.Add);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Adds two integers, performs an overflow check, and pushes the result onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Add_Ovf()
        {
            _il.Emit(OpCodes.Add_Ovf);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Adds two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Add_Ovf_Un()
        {
            _il.Emit(OpCodes.Add_Ovf_Un);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Computes the bitwise AND of two values and pushes the result onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter And()
        {
            _il.Emit(OpCodes.And);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Returns an unmanaged pointer to the argument list of the current method.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Arglist()
        {
            _il.Emit(OpCodes.Arglist);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if two values are equal.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Beq(Label label)
        {
            _il.Emit(OpCodes.Beq, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if two values are equal.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Beq_S(Label label)
        {
            _il.Emit(OpCodes.Beq_S, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is greater than or equal to the second value.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bge(Label label)
        {
            _il.Emit(OpCodes.Bge, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is greater than or equal to the second value.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bge_S(Label label)
        {
            _il.Emit(OpCodes.Bge_S, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bge_Un(Label label)
        {
            _il.Emit(OpCodes.Bge_Un, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bge_Un_S(Label label)
        {
            _il.Emit(OpCodes.Bge_Un_S, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is greater than the second value.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bgt(Label label)
        {
            _il.Emit(OpCodes.Bgt, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is greater than the second value.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bgt_S(Label label)
        {
            _il.Emit(OpCodes.Bgt_S, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bgt_Un(Label label)
        {
            _il.Emit(OpCodes.Bgt_Un, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bgt_Un_S(Label label)
        {
            _il.Emit(OpCodes.Bgt_Un_S, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is less than or equal to the second value.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Ble(Label label)
        {
            _il.Emit(OpCodes.Ble, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is less than or equal to the second value.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Ble_S(Label label)
        {
            _il.Emit(OpCodes.Ble_S, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Ble_Un(Label label)
        {
            _il.Emit(OpCodes.Ble_Un, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Ble_Un_S(Label label)
        {
            _il.Emit(OpCodes.Ble_Un_S, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is less than the second value.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Blt(Label label)
        {
            _il.Emit(OpCodes.Blt, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is less than the second value.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Blt_S(Label label)
        {
            _il.Emit(OpCodes.Blt_S, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if the first value is less than the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Blt_Un(Label label)
        {
            _il.Emit(OpCodes.Blt_Un, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if the first value is less than the second value, when comparing unsigned integer values or unordered float values.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Blt_Un_S(Label label)
        {
            _il.Emit(OpCodes.Blt_Un_S, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction when two unsigned integer values or unordered float values are not equal.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bne_Un(Label label)
        {
            _il.Emit(OpCodes.Bne_Un, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) when two unsigned integer values or unordered float values are not equal.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bne_Un_S(Label label)
        {
            _il.Emit(OpCodes.Bne_Un_S, label);
            Pop(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Converts a value type to an object reference (type O).</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Box(Type type)
        {
            _il.Emit(OpCodes.Box, type);
            Pop(AnyType);
            Push(RefType);

            return this;
        }

        /// <summary>
        ///     <para>Unconditionally transfers control to a target instruction.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Br(Label label)
        {
            _il.Emit(OpCodes.Br, label);

            return this;
        }

        /// <summary>
        ///     <para>Unconditionally transfers control to a target instruction (short form).</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Br_S(Label label)
        {
            _il.Emit(OpCodes.Br_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Signals the Common Language Infrastructure (CLI) to inform the debugger that a break point has been tripped.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Break()
        {
            _il.Emit(OpCodes.Break);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if value is false, a null reference (Nothing in Visual Basic), or zero.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Brfalse(Label label)
        {
            _il.Emit(OpCodes.Brfalse, label);
            Pop(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if value is false, a null reference, or zero.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Brfalse_S(Label label)
        {
            _il.Emit(OpCodes.Brfalse_S, label);
            Pop(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if value is true, not null, or non-zero.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Brtrue(Label label)
        {
            _il.Emit(OpCodes.Brtrue, label);
            Pop(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction (short form) if value is true, not null, or non-zero.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Brtrue_S(Label label)
        {
            _il.Emit(OpCodes.Brtrue_S, label);
            Pop(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Attempts to cast an object passed by reference to the specified class.</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Castclass(Type type)
        {
            _il.Emit(OpCodes.Castclass, type);
            Pop(RefType);
            Push(RefType);

            return this;
        }

        /// <summary>
        ///     <para>Compares two values. If they are equal, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ceq()
        {
            _il.Emit(OpCodes.Ceq);
            Pop(AnyType, AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Compares two values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Cgt()
        {
            _il.Emit(OpCodes.Cgt);
            Pop(AnyType, AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Compares two unsigned or unordered values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Cgt_Un()
        {
            _il.Emit(OpCodes.Cgt_Un);
            Pop(AnyType, AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Throws ArithmeticException if value is not a finite number.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Ckfinite()
        {
            _il.Emit(OpCodes.Ckfinite);
            Pop(AnyType);
            Push(DoubleType);

            return this;
        }

        /// <summary>
        ///     <para>Compares two values. If the first value is less than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Clt()
        {
            _il.Emit(OpCodes.Clt);
            Pop(AnyType, AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Compares the unsigned or unordered values value1 and value2. If value1 is less than value2, then the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Clt_Un()
        {
            _il.Emit(OpCodes.Clt_Un);
            Pop(AnyType, AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Constrains the type on which a virtual method call is made.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Constrained(Type type)
        {
            _il.Emit(OpCodes.Constrained, type);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to native int.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I()
        {
            _il.Emit(OpCodes.Conv_I);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to int8, then extends (pads) it to int32.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I1()
        {
            _il.Emit(OpCodes.Conv_I1);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to int16, then extends (pads) it to int32.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I2()
        {
            _il.Emit(OpCodes.Conv_I2);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to int32.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I4()
        {
            _il.Emit(OpCodes.Conv_I4);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to int64.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_I8()
        {
            _il.Emit(OpCodes.Conv_I8);
            Pop(AnyType);
            Push(LongType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to signed native int, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I()
        {
            _il.Emit(OpCodes.Conv_Ovf_I);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to signed int8 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I1()
        {
            _il.Emit(OpCodes.Conv_Ovf_I1);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to signed int8 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I1_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I1_Un);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to signed int16 and extending it to int32, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I2()
        {
            _il.Emit(OpCodes.Conv_Ovf_I2);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to signed int16 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I2_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I2_Un);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to signed int32, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I4()
        {
            _il.Emit(OpCodes.Conv_Ovf_I4);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to signed int32, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I4_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I4_Un);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to signed int64, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I8()
        {
            _il.Emit(OpCodes.Conv_Ovf_I8);
            Pop(AnyType);
            Push(LongType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to signed int64, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I8_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I8_Un);
            Pop(AnyType);
            Push(LongType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to signed native int, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I_Un);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to unsigned native int, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U()
        {
            _il.Emit(OpCodes.Conv_Ovf_U);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U1()
        {
            _il.Emit(OpCodes.Conv_Ovf_U1);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U1_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U1_Un);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U2()
        {
            _il.Emit(OpCodes.Conv_Ovf_U2);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U2_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U2_Un);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to unsigned int32, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U4()
        {
            _il.Emit(OpCodes.Conv_Ovf_U4);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to unsigned int32, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U4_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U4_Un);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the signed value on top of the evaluation stack to unsigned int64, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U8()
        {
            _il.Emit(OpCodes.Conv_Ovf_U8);
            Pop(AnyType);
            Push(LongType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to unsigned int64, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U8_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U8_Un);
            Pop(AnyType);
            Push(LongType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned value on top of the evaluation stack to unsigned native int, throwing OverflowException on overflow.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U_Un);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to float32.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushr4.</para>
        /// </summary>
        public ILEmitter Conv_R4()
        {
            _il.Emit(OpCodes.Conv_R4);
            Pop(AnyType);
            Push(FloatType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to float32.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Conv_R8()
        {
            _il.Emit(OpCodes.Conv_R8);
            Pop(AnyType);
            Push(DoubleType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the unsigned integer value on top of the evaluation stack to float32.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Conv_R_Un()
        {
            _il.Emit(OpCodes.Conv_R_Un);
            Pop(AnyType);
            Push(DoubleType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to float32.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U()
        {
            _il.Emit(OpCodes.Conv_U);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to unsigned int8, and extends it to int32.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U1()
        {
            _il.Emit(OpCodes.Conv_U1);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to unsigned int16, and extends it to int32.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U2()
        {
            _il.Emit(OpCodes.Conv_U2);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to unsigned int32, and extends it to int32.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U4()
        {
            _il.Emit(OpCodes.Conv_U4);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the value on top of the evaluation stack to unsigned int64, and extends it to int64.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_U8()
        {
            _il.Emit(OpCodes.Conv_U8);
            Pop(AnyType);
            Push(LongType);

            return this;
        }

        /// <summary>
        ///     <para>Copies a specified number bytes from a source address to a destination address.</para>
        ///     <para>StackBehaviourPop: Popi_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Cpblk()
        {
            _il.Emit(OpCodes.Cpblk);
            Pop(IntType, IntType, IntType);

            return this;
        }

        /// <summary>
        ///     <para>Copies the value type located at the address of an object (type &, or native int) to the address of the destination object (type &, or native int).</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Cpobj(Type type)
        {
            _il.Emit(OpCodes.Cpobj, type);
            Pop(IntType, IntType);

            return this;
        }

        /// <summary>
        ///     <para>Divides two values and pushes the result as a floating-point (type F) or quotient (type int32) onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Div()
        {
            _il.Emit(OpCodes.Div);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Divides two unsigned integer values and pushes the result (int32) onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Div_Un()
        {
            _il.Emit(OpCodes.Div_Un);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Copies the current topmost value on the evaluation stack, and then pushes the copy onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push1_push1.</para>
        /// </summary>
        public ILEmitter Dup()
        {
            _il.Emit(OpCodes.Dup);
            Pop(AnyType);
            Push(AnyType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control from the filter clause of an exception back to the Common Language Infrastructure (CLI) exception handler.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Endfilter()
        {
            _il.Emit(OpCodes.Endfilter);
            Pop(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control from the fault or finally clause of an exception block back to the Common Language Infrastructure (CLI) exception handler.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Endfinally()
        {
            _il.Emit(OpCodes.Endfinally);

            return this;
        }

        /// <summary>
        ///     <para>Initializes a specified block of memory at a specific address to a given size and initial value.</para>
        ///     <para>StackBehaviourPop: Popi_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Initblk()
        {
            _il.Emit(OpCodes.Initblk);
            Pop(IntType, IntType, IntType);

            return this;
        }

        /// <summary>
        ///     <para>Initializes each field of the value type at a specified address to a null reference or a 0 of the appropriate primitive type.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Initobj(Type type)
        {
            _il.Emit(OpCodes.Initobj, type);
            Pop(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Tests whether an object reference (type O) is an instance of a particular class.</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Isinst(Type type)
        {
            _il.Emit(OpCodes.Isinst, type);
            Pop(RefType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Exits current method and jumps to specified method.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Jmp(MethodInfo methodInfo)
        {
            _il.Emit(OpCodes.Jmp, methodInfo);

            return this;
        }

        /// <summary>
        ///     <para>Loads an argument (referenced by a specified index value) onto the stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg(short value)
        {
            _il.Emit(OpCodes.Ldarg, value);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the argument at index 0 onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_0()
        {
            _il.Emit(OpCodes.Ldarg_0);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the argument at index 1 onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_1()
        {
            _il.Emit(OpCodes.Ldarg_1);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the argument at index 2 onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_2()
        {
            _il.Emit(OpCodes.Ldarg_2);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the argument at index 3 onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_3()
        {
            _il.Emit(OpCodes.Ldarg_3);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the argument (referenced by a specified short form index) onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_S(byte value)
        {
            _il.Emit(OpCodes.Ldarg_S, value);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Load an argument address onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldarga(short value)
        {
            _il.Emit(OpCodes.Ldarga, value);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Load an argument address, in short form, onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldarga_S(byte value)
        {
            _il.Emit(OpCodes.Ldarga_S, value);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a supplied value of type int32 onto the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4(int value)
        {
            _il.Emit(OpCodes.Ldc_I4, value);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 0 onto the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_0()
        {
            _il.Emit(OpCodes.Ldc_I4_0);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 1 onto the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_1()
        {
            _il.Emit(OpCodes.Ldc_I4_1);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 2 onto the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_2()
        {
            _il.Emit(OpCodes.Ldc_I4_2);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 3 onto the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_3()
        {
            _il.Emit(OpCodes.Ldc_I4_3);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 4 onto the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_4()
        {
            _il.Emit(OpCodes.Ldc_I4_4);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 5 onto the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_5()
        {
            _il.Emit(OpCodes.Ldc_I4_5);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 6 onto the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_6()
        {
            _il.Emit(OpCodes.Ldc_I4_6);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 7 onto the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_7()
        {
            _il.Emit(OpCodes.Ldc_I4_7);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of 8 onto the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_8()
        {
            _il.Emit(OpCodes.Ldc_I4_8);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the integer value of -1 onto the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_M1()
        {
            _il.Emit(OpCodes.Ldc_I4_M1);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the supplied int8 value onto the evaluation stack as an int32, short form.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_S(byte value)
        {
            _il.Emit(OpCodes.Ldc_I4_S, value);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the supplied int8 value onto the evaluation stack as an int32, short form.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_S(sbyte value)
        {
            _il.Emit(OpCodes.Ldc_I4_S, value);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a supplied value of type int64 onto the evaluation stack as an int64.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Ldc_I8(long value)
        {
            _il.Emit(OpCodes.Ldc_I8, value);
            Push(LongType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a supplied value of type float32 onto the evaluation stack as type F (float).</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushr4.</para>
        /// </summary>
        public ILEmitter Ldc_R4(float value)
        {
            _il.Emit(OpCodes.Ldc_R4, value);
            Push(FloatType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a supplied value of type float64 onto the evaluation stack as type F (float).</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Ldc_R8(double value)
        {
            _il.Emit(OpCodes.Ldc_R8, value);
            Push(DoubleType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element at a specified array index onto the top of the evaluation stack as the type specified in the instruction.</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldelem(Type type)
        {
            _il.Emit(OpCodes.Ldelem, type);
            Pop(RefType, IntType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type native int at a specified array index onto the top of the evaluation stack as a native int.</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I()
        {
            _il.Emit(OpCodes.Ldelem_I);
            Pop(RefType, IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type int8 at a specified array index onto the top of the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I1()
        {
            _il.Emit(OpCodes.Ldelem_I1);
            Pop(RefType, IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type int16 at a specified array index onto the top of the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I2()
        {
            _il.Emit(OpCodes.Ldelem_I2);
            Pop(RefType, IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type int32 at a specified array index onto the top of the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I4()
        {
            _il.Emit(OpCodes.Ldelem_I4);
            Pop(RefType, IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type int64 at a specified array index onto the top of the evaluation stack as an int64.</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Ldelem_I8()
        {
            _il.Emit(OpCodes.Ldelem_I8);
            Pop(RefType, IntType);
            Push(LongType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type float32 at a specified array index onto the top of the evaluation stack as type F (float).</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushr4.</para>
        /// </summary>
        public ILEmitter Ldelem_R4()
        {
            _il.Emit(OpCodes.Ldelem_R4);
            Pop(RefType, IntType);
            Push(FloatType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type float64 at a specified array index onto the top of the evaluation stack as type F (float).</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Ldelem_R8()
        {
            _il.Emit(OpCodes.Ldelem_R8);
            Pop(RefType, IntType);
            Push(DoubleType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element containing an object reference at a specified array index onto the top of the evaluation stack as type O (object reference).</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Ldelem_Ref()
        {
            _il.Emit(OpCodes.Ldelem_Ref);
            Pop(RefType, IntType);
            Push(RefType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type unsigned int8 at a specified array index onto the top of the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_U1()
        {
            _il.Emit(OpCodes.Ldelem_U1);
            Pop(RefType, IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type unsigned int16 at a specified array index onto the top of the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_U2()
        {
            _il.Emit(OpCodes.Ldelem_U2);
            Pop(RefType, IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the element with type unsigned int32 at a specified array index onto the top of the evaluation stack as an int32.</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_U4()
        {
            _il.Emit(OpCodes.Ldelem_U4);
            Pop(RefType, IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the address of the array element at a specified array index onto the top of the evaluation stack as type & (managed pointer).</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelema(Type type)
        {
            _il.Emit(OpCodes.Ldelema, type);
            Pop(RefType, IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Finds the value of a field in the object whose reference is currently on the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldfld(FieldInfo fieldInfo)
        {
            _il.Emit(OpCodes.Ldfld, fieldInfo);
            Pop(RefType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Finds the address of a field in the object whose reference is currently on the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldflda(FieldInfo fieldInfo)
        {
            _il.Emit(OpCodes.Ldflda, fieldInfo);
            Pop(RefType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes an unmanaged pointer (type native int) to the native code implementing a specific method onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldftn(MethodInfo methodInfo)
        {
            _il.Emit(OpCodes.Ldftn, methodInfo);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type native int as a native int onto the evaluation stack indirectly.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I()
        {
            _il.Emit(OpCodes.Ldind_I);
            Pop(IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type int8 as an int32 onto the evaluation stack indirectly.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I1()
        {
            _il.Emit(OpCodes.Ldind_I1);
            Pop(IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type int16 as an int32 onto the evaluation stack indirectly.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I2()
        {
            _il.Emit(OpCodes.Ldind_I2);
            Pop(IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type int32 as an int32 onto the evaluation stack indirectly.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I4()
        {
            _il.Emit(OpCodes.Ldind_I4);
            Pop(IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type int64 as an int64 onto the evaluation stack indirectly.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Ldind_I8()
        {
            _il.Emit(OpCodes.Ldind_I8);
            Pop(IntType);
            Push(LongType);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type float32 as a type F (float) onto the evaluation stack indirectly.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushr4.</para>
        /// </summary>
        public ILEmitter Ldind_R4()
        {
            _il.Emit(OpCodes.Ldind_R4);
            Pop(IntType);
            Push(FloatType);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type float64 as a type F (float) onto the evaluation stack indirectly.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Ldind_R8()
        {
            _il.Emit(OpCodes.Ldind_R8);
            Pop(IntType);
            Push(DoubleType);

            return this;
        }

        /// <summary>
        ///     <para>Loads an object reference as a type O (object reference) onto the evaluation stack indirectly.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Ldind_Ref()
        {
            _il.Emit(OpCodes.Ldind_Ref);
            Pop(IntType);
            Push(RefType);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type unsigned int8 as an int32 onto the evaluation stack indirectly.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_U1()
        {
            _il.Emit(OpCodes.Ldind_U1);
            Pop(IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type unsigned int16 as an int32 onto the evaluation stack indirectly.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_U2()
        {
            _il.Emit(OpCodes.Ldind_U2);
            Pop(IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads a value of type unsigned int32 as an int32 onto the evaluation stack indirectly.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_U4()
        {
            _il.Emit(OpCodes.Ldind_U4);
            Pop(IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the number of elements of a zero-based, one-dimensional array onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldlen()
        {
            _il.Emit(OpCodes.Ldlen);
            Pop(RefType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at a specific index onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc(LocalBuilder localBuilder)
        {
            _il.Emit(OpCodes.Ldloc, localBuilder);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at a specific index onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc(short value)
        {
            _il.Emit(OpCodes.Ldloc, value);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at index 0 onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_0()
        {
            _il.Emit(OpCodes.Ldloc_0);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at index 1 onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_1()
        {
            _il.Emit(OpCodes.Ldloc_1);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at index 2 onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_2()
        {
            _il.Emit(OpCodes.Ldloc_2);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at index 3 onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_3()
        {
            _il.Emit(OpCodes.Ldloc_3);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at a specific index onto the evaluation stack, short form.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_S(LocalBuilder localBuilder)
        {
            _il.Emit(OpCodes.Ldloc_S, localBuilder);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the local variable at a specific index onto the evaluation stack, short form.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_S(short value)
        {
            _il.Emit(OpCodes.Ldloc_S, value);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the address of the local variable at a specific index onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldloca(short value)
        {
            _il.Emit(OpCodes.Ldloca, value);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Loads the address of the local variable at a specific index onto the evaluation stack, short form.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldloca_S(byte value)
        {
            _il.Emit(OpCodes.Ldloca_S, value);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a null reference (type O) onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Ldnull()
        {
            _il.Emit(OpCodes.Ldnull);
            Push(RefType);

            return this;
        }

        /// <summary>
        ///     <para>Copies the value type object pointed to by an address to the top of the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldobj(Type type)
        {
            _il.Emit(OpCodes.Ldobj, type);
            Pop(IntType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the value of a static field onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldsfld(FieldInfo fieldInfo)
        {
            _il.Emit(OpCodes.Ldsfld, fieldInfo);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the address of a static field onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldsflda(FieldInfo fieldInfo)
        {
            _il.Emit(OpCodes.Ldsflda, fieldInfo);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a new object reference to a string literal stored in the metadata.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Ldstr(string value)
        {
            _il.Emit(OpCodes.Ldstr, value);
            Push(RefType);

            return this;
        }

        /// <summary>
        ///     <para>Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldtoken(MethodInfo methodInfo)
        {
            _il.Emit(OpCodes.Ldtoken, methodInfo);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldtoken(FieldInfo fieldInfo)
        {
            _il.Emit(OpCodes.Ldtoken, fieldInfo);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldtoken(Type type)
        {
            _il.Emit(OpCodes.Ldtoken, type);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes an unmanaged pointer (type native int) to the native code implementing a particular virtual method associated with a specified object onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldvirtftn(MethodInfo methodInfo)
        {
            _il.Emit(OpCodes.Ldvirtftn, methodInfo);
            Pop(RefType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Exits a protected region of code, unconditionally transferring control to a specific target instruction.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Leave(Label label)
        {
            _il.Emit(OpCodes.Leave, label);

            return this;
        }

        /// <summary>
        ///     <para>Exits a protected region of code, unconditionally transferring control to a target instruction (short form).</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Leave_S(Label label)
        {
            _il.Emit(OpCodes.Leave_S, label);

            return this;
        }

        /// <summary>
        ///     <para>Allocates a certain number of bytes from the local dynamic memory pool and pushes the address (a transient pointer, type *) of the first allocated byte onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Localloc()
        {
            _il.Emit(OpCodes.Localloc);
            Pop(IntType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes a typed reference to an instance of a specific type onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Mkrefany(Type type)
        {
            _il.Emit(OpCodes.Mkrefany, type);
            Pop(IntType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Multiplies two values and pushes the result on the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Mul()
        {
            _il.Emit(OpCodes.Mul);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Multiplies two integer values, performs an overflow check, and pushes the result onto the evaluation stack</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Mul_Ovf()
        {
            _il.Emit(OpCodes.Mul_Ovf);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Multiplies two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Mul_Ovf_Un()
        {
            _il.Emit(OpCodes.Mul_Ovf_Un);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Negates a value and pushes the result onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Neg()
        {
            _il.Emit(OpCodes.Neg);
            Pop(AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes an object reference to a new zero-based, one-dimensional array whose elements are of a specific type onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Newarr(Type type)
        {
            _il.Emit(OpCodes.Newarr, type);
            Pop(IntType);
            Push(RefType);

            return this;
        }

        /// <summary>
        ///     <para>Fills space if opcodes are patched. No meaningful operation is performed although a processing cycle can be consumed.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Nop()
        {
            _il.Emit(OpCodes.Nop);

            return this;
        }

        /// <summary>
        ///     <para>Computes the bitwise complement of the integer value on top of the stack and pushes the result onto the evaluation stack as the same type.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Not()
        {
            _il.Emit(OpCodes.Not);
            Pop(AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Compute the bitwise complement of the two integer values on top of the stack and pushes the result onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Or()
        {
            _il.Emit(OpCodes.Or);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Removes the value currently on top of the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Pop()
        {
            _il.Emit(OpCodes.Pop);
            Pop(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix1()
        {
            _il.Emit(OpCodes.Prefix1);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix2()
        {
            _il.Emit(OpCodes.Prefix2);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix3()
        {
            _il.Emit(OpCodes.Prefix3);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix4()
        {
            _il.Emit(OpCodes.Prefix4);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix5()
        {
            _il.Emit(OpCodes.Prefix5);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix6()
        {
            _il.Emit(OpCodes.Prefix6);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix7()
        {
            _il.Emit(OpCodes.Prefix7);

            return this;
        }

        /// <summary>
        ///     <para>This is a reserved instruction.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefixref()
        {
            _il.Emit(OpCodes.Prefixref);

            return this;
        }

        /// <summary>
        ///     <para>Specifies that the subsequent array address operation performs no type check at run time, and that it returns a managed pointer whose mutability is restricted.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Readonly()
        {
            _il.Emit(OpCodes.Readonly);

            return this;
        }

        /// <summary>
        ///     <para>Retrieves the type token embedded in a typed reference.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Refanytype()
        {
            _il.Emit(OpCodes.Refanytype);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Retrieves the address (type &) embedded in a typed reference.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Refanyval(Type type)
        {
            _il.Emit(OpCodes.Refanyval, type);
            Pop(AnyType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Divides two values and pushes the remainder onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Rem()
        {
            _il.Emit(OpCodes.Rem);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Divides two unsigned values and pushes the remainder onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Rem_Un()
        {
            _il.Emit(OpCodes.Rem_Un);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Rethrows the current exception.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Rethrow()
        {
            _il.Emit(OpCodes.Rethrow);

            return this;
        }

        /// <summary>
        ///     <para>Shifts an integer value to the left (in zeroes) by a specified number of bits, pushing the result onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Shl()
        {
            _il.Emit(OpCodes.Shl);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Shifts an integer value (in sign) to the right by a specified number of bits, pushing the result onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Shr()
        {
            _il.Emit(OpCodes.Shr);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Shifts an unsigned integer value (in zeroes) to the right by a specified number of bits, pushing the result onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Shr_Un()
        {
            _il.Emit(OpCodes.Shr_Un);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Pushes the size, in bytes, of a supplied value type onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Sizeof(Type type)
        {
            _il.Emit(OpCodes.Sizeof, type);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Stores the value on top of the evaluation stack in the argument slot at a specified index.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Starg(short value)
        {
            _il.Emit(OpCodes.Starg, value);
            Pop(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Stores the value on top of the evaluation stack in the argument slot at a specified index, short form.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Starg_S(byte value)
        {
            _il.Emit(OpCodes.Starg_S, value);
            Pop(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the value on the evaluation stack, whose type is specified in the instruction.</para>
        ///     <para>StackBehaviourPop: Popref_popi_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem(Type type)
        {
            _il.Emit(OpCodes.Stelem, type);
            Pop(RefType, IntType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the native int value on the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I()
        {
            _il.Emit(OpCodes.Stelem_I);
            Pop(RefType, IntType, IntType);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the int8 value on the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I1()
        {
            _il.Emit(OpCodes.Stelem_I1);
            Pop(RefType, IntType, IntType);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the int16 value on the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I2()
        {
            _il.Emit(OpCodes.Stelem_I2);
            Pop(RefType, IntType, IntType);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the int32 value on the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I4()
        {
            _il.Emit(OpCodes.Stelem_I4);
            Pop(RefType, IntType, IntType);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the int64 value on the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi8.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I8()
        {
            _il.Emit(OpCodes.Stelem_I8);
            Pop(RefType, IntType, LongType);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the float32 value on the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popref_popi_popr4.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_R4()
        {
            _il.Emit(OpCodes.Stelem_R4);
            Pop(RefType, IntType, FloatType);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the float64 value on the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popref_popi_popr8.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_R8()
        {
            _il.Emit(OpCodes.Stelem_R8);
            Pop(RefType, IntType, DoubleType);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the array element at a given index with the object ref value (type O) on the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popref_popi_popref.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_Ref()
        {
            _il.Emit(OpCodes.Stelem_Ref);
            Pop(RefType, IntType, RefType);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the value stored in the field of an object reference or pointer with a new value.</para>
        ///     <para>StackBehaviourPop: Popref_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stfld(FieldInfo fieldInfo)
        {
            _il.Emit(OpCodes.Stfld, fieldInfo);
            Pop(RefType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type native int at a supplied address.</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I()
        {
            _il.Emit(OpCodes.Stind_I);
            Pop(IntType, IntType);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type int8 at a supplied address.</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I1()
        {
            _il.Emit(OpCodes.Stind_I1);
            Pop(IntType, IntType);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type int16 at a supplied address.</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I2()
        {
            _il.Emit(OpCodes.Stind_I2);
            Pop(IntType, IntType);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type int32 at a supplied address.</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I4()
        {
            _il.Emit(OpCodes.Stind_I4);
            Pop(IntType, IntType);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type int64 at a supplied address.</para>
        ///     <para>StackBehaviourPop: Popi_popi8.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I8()
        {
            _il.Emit(OpCodes.Stind_I8);
            Pop(IntType, LongType);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type float32 at a supplied address.</para>
        ///     <para>StackBehaviourPop: Popi_popr4.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_R4()
        {
            _il.Emit(OpCodes.Stind_R4);
            Pop(IntType, FloatType);

            return this;
        }

        /// <summary>
        ///     <para>Stores a value of type float64 at a supplied address.</para>
        ///     <para>StackBehaviourPop: Popi_popr8.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_R8()
        {
            _il.Emit(OpCodes.Stind_R8);
            Pop(IntType, DoubleType);

            return this;
        }

        /// <summary>
        ///     <para>Stores a object reference value at a supplied address.</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_Ref()
        {
            _il.Emit(OpCodes.Stind_Ref);
            Pop(IntType, IntType);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc(LocalBuilder localBuilder)
        {
            _il.Emit(OpCodes.Stloc, localBuilder);
            Pop(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc(short value)
        {
            _il.Emit(OpCodes.Stloc, value);
            Pop(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 0.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_0()
        {
            _il.Emit(OpCodes.Stloc_0);
            Pop(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 1.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_1()
        {
            _il.Emit(OpCodes.Stloc_1);
            Pop(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 2.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_2()
        {
            _il.Emit(OpCodes.Stloc_2);
            Pop(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 3.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_3()
        {
            _il.Emit(OpCodes.Stloc_3);
            Pop(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index (short form).</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_S(LocalBuilder localBuilder)
        {
            _il.Emit(OpCodes.Stloc_S, localBuilder);
            Pop(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index (short form).</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_S(byte value)
        {
            _il.Emit(OpCodes.Stloc_S, value);
            Pop(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Copies a value of a specified type from the evaluation stack into a supplied memory address.</para>
        ///     <para>StackBehaviourPop: Popi_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stobj(Type type)
        {
            _il.Emit(OpCodes.Stobj, type);
            Pop(IntType, AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Replaces the value of a static field with a value from the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stsfld(FieldInfo fieldInfo)
        {
            _il.Emit(OpCodes.Stsfld, fieldInfo);
            Pop(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Subtracts one value from another and pushes the result onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Sub()
        {
            _il.Emit(OpCodes.Sub);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Subtracts one integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Sub_Ovf()
        {
            _il.Emit(OpCodes.Sub_Ovf);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Subtracts one unsigned integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Sub_Ovf_Un()
        {
            _il.Emit(OpCodes.Sub_Ovf_Un);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Implements a jump table.</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Switch(Label[] label)
        {
            _il.Emit(OpCodes.Switch, label);
            Pop(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Performs a postfixed method call instruction such that the current method's stack frame is removed before the actual call instruction is executed.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Tailcall()
        {
            _il.Emit(OpCodes.Tailcall);

            return this;
        }

        /// <summary>
        ///     <para>Throws the exception object currently on the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Throw()
        {
            _il.Emit(OpCodes.Throw);
            Pop(RefType);

            return this;
        }

        /// <summary>
        ///     <para>Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Unaligned(byte value)
        {
            _il.Emit(OpCodes.Unaligned, value);

            return this;
        }

        /// <summary>
        ///     <para>Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Unaligned(Label label)
        {
            _il.Emit(OpCodes.Unaligned, label);

            return this;
        }

        /// <summary>
        ///     <para>Converts the boxed representation of a value type to its unboxed form.</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Unbox(Type type)
        {
            _il.Emit(OpCodes.Unbox, type);
            Pop(RefType);
            Push(IntType);

            return this;
        }

        /// <summary>
        ///     <para>Converts the boxed representation of a type specified in the instruction to its unboxed form.</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Unbox_Any(Type type)
        {
            _il.Emit(OpCodes.Unbox_Any, type);
            Pop(RefType);
            Push(AnyType);

            return this;
        }

        /// <summary>
        ///     <para>Specifies that an address currently atop the evaluation stack might be volatile, and the results of reading that location cannot be cached or that multiple stores to that location cannot be suppressed.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Volatile()
        {
            _il.Emit(OpCodes.Volatile);

            return this;
        }

        /// <summary>
        ///     <para>Computes the bitwise XOR of the top two values on the evaluation stack, pushing the result onto the evaluation stack.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Xor()
        {
            _il.Emit(OpCodes.Xor);
            Pop(AnyType, AnyType);
            Push(AnyType);

            return this;
        }
    }
}
