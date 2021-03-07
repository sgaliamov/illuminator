/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System;
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

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Add_Ovf()
        {
            _il.Emit(OpCodes.Add_Ovf);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Add_Ovf_Un()
        {
            _il.Emit(OpCodes.Add_Ovf_Un);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter And()
        {
            _il.Emit(OpCodes.And);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Arglist()
        {
            _il.Emit(OpCodes.Arglist);

            Pop(0);
            Push(1);

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

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Beq_S()
        {
            _il.Emit(OpCodes.Beq_S);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bge()
        {
            _il.Emit(OpCodes.Bge);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bge_S()
        {
            _il.Emit(OpCodes.Bge_S);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bge_Un()
        {
            _il.Emit(OpCodes.Bge_Un);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bge_Un_S()
        {
            _il.Emit(OpCodes.Bge_Un_S);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bgt()
        {
            _il.Emit(OpCodes.Bgt);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bgt_S()
        {
            _il.Emit(OpCodes.Bgt_S);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bgt_Un()
        {
            _il.Emit(OpCodes.Bgt_Un);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bgt_Un_S()
        {
            _il.Emit(OpCodes.Bgt_Un_S);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Ble()
        {
            _il.Emit(OpCodes.Ble);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Ble_S()
        {
            _il.Emit(OpCodes.Ble_S);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Ble_Un()
        {
            _il.Emit(OpCodes.Ble_Un);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Ble_Un_S()
        {
            _il.Emit(OpCodes.Ble_Un_S);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Blt()
        {
            _il.Emit(OpCodes.Blt);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Blt_S()
        {
            _il.Emit(OpCodes.Blt_S);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Blt_Un()
        {
            _il.Emit(OpCodes.Blt_Un);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Blt_Un_S()
        {
            _il.Emit(OpCodes.Blt_Un_S);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bne_Un()
        {
            _il.Emit(OpCodes.Bne_Un);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bne_Un_S()
        {
            _il.Emit(OpCodes.Bne_Un_S);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Box()
        {
            _il.Emit(OpCodes.Box);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Br()
        {
            _il.Emit(OpCodes.Br);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Br_S()
        {
            _il.Emit(OpCodes.Br_S);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Break()
        {
            _il.Emit(OpCodes.Break);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Brfalse()
        {
            _il.Emit(OpCodes.Brfalse);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Brfalse_S()
        {
            _il.Emit(OpCodes.Brfalse_S);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Brtrue()
        {
            _il.Emit(OpCodes.Brtrue);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Brtrue_S()
        {
            _il.Emit(OpCodes.Brtrue_S);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Castclass()
        {
            _il.Emit(OpCodes.Castclass);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ceq()
        {
            _il.Emit(OpCodes.Ceq);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Cgt()
        {
            _il.Emit(OpCodes.Cgt);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Cgt_Un()
        {
            _il.Emit(OpCodes.Cgt_Un);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Ckfinite()
        {
            _il.Emit(OpCodes.Ckfinite);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Clt()
        {
            _il.Emit(OpCodes.Clt);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Clt_Un()
        {
            _il.Emit(OpCodes.Clt_Un);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Constrained()
        {
            _il.Emit(OpCodes.Constrained);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I()
        {
            _il.Emit(OpCodes.Conv_I);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I1()
        {
            _il.Emit(OpCodes.Conv_I1);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I2()
        {
            _il.Emit(OpCodes.Conv_I2);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I4()
        {
            _il.Emit(OpCodes.Conv_I4);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_I8()
        {
            _il.Emit(OpCodes.Conv_I8);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I()
        {
            _il.Emit(OpCodes.Conv_Ovf_I);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I1()
        {
            _il.Emit(OpCodes.Conv_Ovf_I1);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I1_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I1_Un);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I2()
        {
            _il.Emit(OpCodes.Conv_Ovf_I2);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I2_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I2_Un);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I4()
        {
            _il.Emit(OpCodes.Conv_Ovf_I4);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I4_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I4_Un);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I8()
        {
            _il.Emit(OpCodes.Conv_Ovf_I8);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I8_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I8_Un);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I_Un);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U()
        {
            _il.Emit(OpCodes.Conv_Ovf_U);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U1()
        {
            _il.Emit(OpCodes.Conv_Ovf_U1);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U1_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U1_Un);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U2()
        {
            _il.Emit(OpCodes.Conv_Ovf_U2);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U2_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U2_Un);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U4()
        {
            _il.Emit(OpCodes.Conv_Ovf_U4);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U4_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U4_Un);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U8()
        {
            _il.Emit(OpCodes.Conv_Ovf_U8);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U8_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U8_Un);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U_Un);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushr4.</para>
        /// </summary>
        public ILEmitter Conv_R4()
        {
            _il.Emit(OpCodes.Conv_R4);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Conv_R8()
        {
            _il.Emit(OpCodes.Conv_R8);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Conv_R_Un()
        {
            _il.Emit(OpCodes.Conv_R_Un);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U()
        {
            _il.Emit(OpCodes.Conv_U);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U1()
        {
            _il.Emit(OpCodes.Conv_U1);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U2()
        {
            _il.Emit(OpCodes.Conv_U2);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U4()
        {
            _il.Emit(OpCodes.Conv_U4);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_U8()
        {
            _il.Emit(OpCodes.Conv_U8);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Cpblk()
        {
            _il.Emit(OpCodes.Cpblk);

            Pop(3);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Cpobj()
        {
            _il.Emit(OpCodes.Cpobj);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Div()
        {
            _il.Emit(OpCodes.Div);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Div_Un()
        {
            _il.Emit(OpCodes.Div_Un);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push1_push1.</para>
        /// </summary>
        public ILEmitter Dup()
        {
            _il.Emit(OpCodes.Dup);

            Pop(1);
            Push(2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Endfilter()
        {
            _il.Emit(OpCodes.Endfilter);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Endfinally()
        {
            _il.Emit(OpCodes.Endfinally);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Initblk()
        {
            _il.Emit(OpCodes.Initblk);

            Pop(3);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Initobj()
        {
            _il.Emit(OpCodes.Initobj);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Isinst()
        {
            _il.Emit(OpCodes.Isinst);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Jmp()
        {
            _il.Emit(OpCodes.Jmp);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg()
        {
            _il.Emit(OpCodes.Ldarg);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_0()
        {
            _il.Emit(OpCodes.Ldarg_0);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_1()
        {
            _il.Emit(OpCodes.Ldarg_1);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_2()
        {
            _il.Emit(OpCodes.Ldarg_2);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_3()
        {
            _il.Emit(OpCodes.Ldarg_3);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_S()
        {
            _il.Emit(OpCodes.Ldarg_S);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldarga()
        {
            _il.Emit(OpCodes.Ldarga);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldarga_S()
        {
            _il.Emit(OpCodes.Ldarga_S);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4()
        {
            _il.Emit(OpCodes.Ldc_I4);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_0()
        {
            _il.Emit(OpCodes.Ldc_I4_0);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_1()
        {
            _il.Emit(OpCodes.Ldc_I4_1);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_2()
        {
            _il.Emit(OpCodes.Ldc_I4_2);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_3()
        {
            _il.Emit(OpCodes.Ldc_I4_3);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_4()
        {
            _il.Emit(OpCodes.Ldc_I4_4);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_5()
        {
            _il.Emit(OpCodes.Ldc_I4_5);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_6()
        {
            _il.Emit(OpCodes.Ldc_I4_6);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_7()
        {
            _il.Emit(OpCodes.Ldc_I4_7);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_8()
        {
            _il.Emit(OpCodes.Ldc_I4_8);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_M1()
        {
            _il.Emit(OpCodes.Ldc_I4_M1);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_S()
        {
            _il.Emit(OpCodes.Ldc_I4_S);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Ldc_I8()
        {
            _il.Emit(OpCodes.Ldc_I8);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushr4.</para>
        /// </summary>
        public ILEmitter Ldc_R4()
        {
            _il.Emit(OpCodes.Ldc_R4);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Ldc_R8()
        {
            _il.Emit(OpCodes.Ldc_R8);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldelem()
        {
            _il.Emit(OpCodes.Ldelem);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I()
        {
            _il.Emit(OpCodes.Ldelem_I);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I1()
        {
            _il.Emit(OpCodes.Ldelem_I1);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I2()
        {
            _il.Emit(OpCodes.Ldelem_I2);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I4()
        {
            _il.Emit(OpCodes.Ldelem_I4);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Ldelem_I8()
        {
            _il.Emit(OpCodes.Ldelem_I8);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushr4.</para>
        /// </summary>
        public ILEmitter Ldelem_R4()
        {
            _il.Emit(OpCodes.Ldelem_R4);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Ldelem_R8()
        {
            _il.Emit(OpCodes.Ldelem_R8);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Ldelem_Ref()
        {
            _il.Emit(OpCodes.Ldelem_Ref);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_U1()
        {
            _il.Emit(OpCodes.Ldelem_U1);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_U2()
        {
            _il.Emit(OpCodes.Ldelem_U2);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_U4()
        {
            _il.Emit(OpCodes.Ldelem_U4);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelema()
        {
            _il.Emit(OpCodes.Ldelema);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldfld()
        {
            _il.Emit(OpCodes.Ldfld);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldflda()
        {
            _il.Emit(OpCodes.Ldflda);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldftn()
        {
            _il.Emit(OpCodes.Ldftn);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I()
        {
            _il.Emit(OpCodes.Ldind_I);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I1()
        {
            _il.Emit(OpCodes.Ldind_I1);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I2()
        {
            _il.Emit(OpCodes.Ldind_I2);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I4()
        {
            _il.Emit(OpCodes.Ldind_I4);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Ldind_I8()
        {
            _il.Emit(OpCodes.Ldind_I8);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushr4.</para>
        /// </summary>
        public ILEmitter Ldind_R4()
        {
            _il.Emit(OpCodes.Ldind_R4);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Ldind_R8()
        {
            _il.Emit(OpCodes.Ldind_R8);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Ldind_Ref()
        {
            _il.Emit(OpCodes.Ldind_Ref);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_U1()
        {
            _il.Emit(OpCodes.Ldind_U1);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_U2()
        {
            _il.Emit(OpCodes.Ldind_U2);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_U4()
        {
            _il.Emit(OpCodes.Ldind_U4);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldlen()
        {
            _il.Emit(OpCodes.Ldlen);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc()
        {
            _il.Emit(OpCodes.Ldloc);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_0()
        {
            _il.Emit(OpCodes.Ldloc_0);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_1()
        {
            _il.Emit(OpCodes.Ldloc_1);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_2()
        {
            _il.Emit(OpCodes.Ldloc_2);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_3()
        {
            _il.Emit(OpCodes.Ldloc_3);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_S()
        {
            _il.Emit(OpCodes.Ldloc_S);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldloca()
        {
            _il.Emit(OpCodes.Ldloca);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>Loads the address of the local variable at a specific index onto the evaluation stack, short form.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldloca_S(Byte @byte)
        {
            _il.Emit(OpCodes.Ldloca_S, @byte);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Ldnull()
        {
            _il.Emit(OpCodes.Ldnull);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldobj()
        {
            _il.Emit(OpCodes.Ldobj);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldsfld()
        {
            _il.Emit(OpCodes.Ldsfld);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldsflda()
        {
            _il.Emit(OpCodes.Ldsflda);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Ldstr()
        {
            _il.Emit(OpCodes.Ldstr);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldtoken()
        {
            _il.Emit(OpCodes.Ldtoken);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldvirtftn()
        {
            _il.Emit(OpCodes.Ldvirtftn);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Leave()
        {
            _il.Emit(OpCodes.Leave);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Leave_S()
        {
            _il.Emit(OpCodes.Leave_S);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Localloc()
        {
            _il.Emit(OpCodes.Localloc);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Mkrefany()
        {
            _il.Emit(OpCodes.Mkrefany);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Mul()
        {
            _il.Emit(OpCodes.Mul);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Mul_Ovf()
        {
            _il.Emit(OpCodes.Mul_Ovf);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Mul_Ovf_Un()
        {
            _il.Emit(OpCodes.Mul_Ovf_Un);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Neg()
        {
            _il.Emit(OpCodes.Neg);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Newarr()
        {
            _il.Emit(OpCodes.Newarr);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Nop()
        {
            _il.Emit(OpCodes.Nop);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Not()
        {
            _il.Emit(OpCodes.Not);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Or()
        {
            _il.Emit(OpCodes.Or);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Pop()
        {
            _il.Emit(OpCodes.Pop);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix1()
        {
            _il.Emit(OpCodes.Prefix1);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix2()
        {
            _il.Emit(OpCodes.Prefix2);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix3()
        {
            _il.Emit(OpCodes.Prefix3);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix4()
        {
            _il.Emit(OpCodes.Prefix4);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix5()
        {
            _il.Emit(OpCodes.Prefix5);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix6()
        {
            _il.Emit(OpCodes.Prefix6);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix7()
        {
            _il.Emit(OpCodes.Prefix7);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefixref()
        {
            _il.Emit(OpCodes.Prefixref);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Readonly()
        {
            _il.Emit(OpCodes.Readonly);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Refanytype()
        {
            _il.Emit(OpCodes.Refanytype);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Refanyval()
        {
            _il.Emit(OpCodes.Refanyval);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Rem()
        {
            _il.Emit(OpCodes.Rem);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Rem_Un()
        {
            _il.Emit(OpCodes.Rem_Un);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Rethrow()
        {
            _il.Emit(OpCodes.Rethrow);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Shl()
        {
            _il.Emit(OpCodes.Shl);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Shr()
        {
            _il.Emit(OpCodes.Shr);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Shr_Un()
        {
            _il.Emit(OpCodes.Shr_Un);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Sizeof()
        {
            _il.Emit(OpCodes.Sizeof);

            Pop(0);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Starg()
        {
            _il.Emit(OpCodes.Starg);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Starg_S()
        {
            _il.Emit(OpCodes.Starg_S);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem()
        {
            _il.Emit(OpCodes.Stelem);

            Pop(3);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I()
        {
            _il.Emit(OpCodes.Stelem_I);

            Pop(3);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I1()
        {
            _il.Emit(OpCodes.Stelem_I1);

            Pop(3);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I2()
        {
            _il.Emit(OpCodes.Stelem_I2);

            Pop(3);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I4()
        {
            _il.Emit(OpCodes.Stelem_I4);

            Pop(3);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi8.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I8()
        {
            _il.Emit(OpCodes.Stelem_I8);

            Pop(3);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popr4.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_R4()
        {
            _il.Emit(OpCodes.Stelem_R4);

            Pop(3);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popr8.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_R8()
        {
            _il.Emit(OpCodes.Stelem_R8);

            Pop(3);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popref.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_Ref()
        {
            _il.Emit(OpCodes.Stelem_Ref);

            Pop(3);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stfld()
        {
            _il.Emit(OpCodes.Stfld);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I()
        {
            _il.Emit(OpCodes.Stind_I);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I1()
        {
            _il.Emit(OpCodes.Stind_I1);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I2()
        {
            _il.Emit(OpCodes.Stind_I2);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I4()
        {
            _il.Emit(OpCodes.Stind_I4);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi8.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I8()
        {
            _il.Emit(OpCodes.Stind_I8);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popr4.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_R4()
        {
            _il.Emit(OpCodes.Stind_R4);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popr8.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_R8()
        {
            _il.Emit(OpCodes.Stind_R8);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_Ref()
        {
            _il.Emit(OpCodes.Stind_Ref);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc()
        {
            _il.Emit(OpCodes.Stloc);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_0()
        {
            _il.Emit(OpCodes.Stloc_0);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_1()
        {
            _il.Emit(OpCodes.Stloc_1);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_2()
        {
            _il.Emit(OpCodes.Stloc_2);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_3()
        {
            _il.Emit(OpCodes.Stloc_3);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_S()
        {
            _il.Emit(OpCodes.Stloc_S);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stobj()
        {
            _il.Emit(OpCodes.Stobj);

            Pop(2);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stsfld()
        {
            _il.Emit(OpCodes.Stsfld);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Sub()
        {
            _il.Emit(OpCodes.Sub);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Sub_Ovf()
        {
            _il.Emit(OpCodes.Sub_Ovf);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Sub_Ovf_Un()
        {
            _il.Emit(OpCodes.Sub_Ovf_Un);

            Pop(2);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Switch()
        {
            _il.Emit(OpCodes.Switch);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Tailcall()
        {
            _il.Emit(OpCodes.Tailcall);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Throw()
        {
            _il.Emit(OpCodes.Throw);

            Pop(1);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Unaligned()
        {
            _il.Emit(OpCodes.Unaligned);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Unbox()
        {
            _il.Emit(OpCodes.Unbox);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Unbox_Any()
        {
            _il.Emit(OpCodes.Unbox_Any);

            Pop(1);
            Push(1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Volatile()
        {
            _il.Emit(OpCodes.Volatile);

            Pop(0);
            Push(0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Xor()
        {
            _il.Emit(OpCodes.Xor);

            Pop(2);
            Push(1);

            return this;
        }
    }
}
