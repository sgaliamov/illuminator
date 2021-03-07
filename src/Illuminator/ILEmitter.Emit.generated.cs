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
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Add);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Add_Ovf()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Add_Ovf);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Add_Ovf_Un()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Add_Ovf_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter And()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.And);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Arglist()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Arglist);

            return this;
        }

        /// <summary>
        ///     <para>Transfers control to a target instruction if two values are equal.</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Beq(Label label)
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Beq, label);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Beq_S()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Beq_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bge()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Bge);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bge_S()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Bge_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bge_Un()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Bge_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bge_Un_S()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Bge_Un_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bgt()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Bgt);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bgt_S()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Bgt_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bgt_Un()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Bgt_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bgt_Un_S()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Bgt_Un_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Ble()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Ble);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Ble_S()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Ble_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Ble_Un()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Ble_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Ble_Un_S()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Ble_Un_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Blt()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Blt);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Blt_S()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Blt_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Blt_Un()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Blt_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Blt_Un_S()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Blt_Un_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bne_Un()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Bne_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Bne_Un_S()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Bne_Un_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Box()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Box);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Br()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Br);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Br_S()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Br_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Break()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Break);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Brfalse()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Brfalse);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Brfalse_S()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Brfalse_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Brtrue()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Brtrue);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Brtrue_S()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Brtrue_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Castclass()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Castclass);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ceq()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ceq);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Cgt()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Cgt);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Cgt_Un()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Cgt_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Ckfinite()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ckfinite);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Clt()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Clt);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Clt_Un()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Clt_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Constrained()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Constrained);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_I);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I1()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_I1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I2()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_I2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_I4()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_I4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_I8()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_I8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_I);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I1()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_I1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I1_Un()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_I1_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I2()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_I2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I2_Un()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_I2_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I4()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_I4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I4_Un()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_I4_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I8()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_I8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I8_Un()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_I8_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_I_Un()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_I_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_U);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U1()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_U1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U1_Un()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_U1_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U2()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_U2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U2_Un()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_U2_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U4()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_U4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U4_Un()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_U4_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U8()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_U8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U8_Un()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_U8_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_Ovf_U_Un()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_Ovf_U_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushr4.</para>
        /// </summary>
        public ILEmitter Conv_R4()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_R4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Conv_R8()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_R8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Conv_R_Un()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_R_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_U);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U1()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_U1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U2()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_U2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Conv_U4()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_U4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Conv_U8()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Conv_U8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Cpblk()
        {
            Pop(3);
            Push(0);

            _il.Emit(OpCodes.Cpblk);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Cpobj()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Cpobj);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Div()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Div);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Div_Un()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Div_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push1_push1.</para>
        /// </summary>
        public ILEmitter Dup()
        {
            Pop(1);
            Push(2);

            _il.Emit(OpCodes.Dup);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Endfilter()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Endfilter);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Endfinally()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Endfinally);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Initblk()
        {
            Pop(3);
            Push(0);

            _il.Emit(OpCodes.Initblk);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Initobj()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Initobj);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Isinst()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Isinst);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Jmp()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Jmp);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldarg);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_0()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldarg_0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_1()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldarg_1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_2()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldarg_2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_3()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldarg_3);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldarg_S()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldarg_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldarga()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldarga);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldarga_S()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldarga_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_I4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_0()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_I4_0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_1()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_I4_1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_2()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_I4_2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_3()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_I4_3);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_4()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_I4_4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_5()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_I4_5);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_6()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_I4_6);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_7()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_I4_7);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_8()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_I4_8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_M1()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_I4_M1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldc_I4_S()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_I4_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Ldc_I8()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_I8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushr4.</para>
        /// </summary>
        public ILEmitter Ldc_R4()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_R4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Ldc_R8()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldc_R8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldelem()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ldelem);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ldelem_I);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I1()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ldelem_I1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I2()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ldelem_I2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_I4()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ldelem_I4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Ldelem_I8()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ldelem_I8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushr4.</para>
        /// </summary>
        public ILEmitter Ldelem_R4()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ldelem_R4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Ldelem_R8()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ldelem_R8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Ldelem_Ref()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ldelem_Ref);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_U1()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ldelem_U1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_U2()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ldelem_U2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelem_U4()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ldelem_U4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldelema()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Ldelema);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldfld()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldfld);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldflda()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldflda);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldftn()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldftn);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldind_I);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I1()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldind_I1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I2()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldind_I2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_I4()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldind_I4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi8.</para>
        /// </summary>
        public ILEmitter Ldind_I8()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldind_I8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushr4.</para>
        /// </summary>
        public ILEmitter Ldind_R4()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldind_R4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushr8.</para>
        /// </summary>
        public ILEmitter Ldind_R8()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldind_R8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Ldind_Ref()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldind_Ref);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_U1()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldind_U1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_U2()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldind_U2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldind_U4()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldind_U4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldlen()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldlen);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldloc);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_0()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldloc_0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_1()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldloc_1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_2()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldloc_2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_3()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldloc_3);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldloc_S()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldloc_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldloca()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldloca);

            return this;
        }

        /// <summary>
        ///     <para>Loads the address of the local variable at a specific index onto the evaluation stack, short form.</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldloca_S(Byte @byte)
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldloca_S, @byte);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Ldnull()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldnull);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldobj()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldobj);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Ldsfld()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldsfld);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldsflda()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldsflda);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Ldstr()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldstr);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldtoken()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Ldtoken);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Ldvirtftn()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Ldvirtftn);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Leave()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Leave);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Leave_S()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Leave_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Localloc()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Localloc);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Mkrefany()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Mkrefany);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Mul()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Mul);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Mul_Ovf()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Mul_Ovf);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Mul_Ovf_Un()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Mul_Ovf_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Neg()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Neg);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Pushref.</para>
        /// </summary>
        public ILEmitter Newarr()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Newarr);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Nop()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Nop);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Not()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Not);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Or()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Or);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Pop()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Pop);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix1()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Prefix1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix2()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Prefix2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix3()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Prefix3);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix4()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Prefix4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix5()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Prefix5);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix6()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Prefix6);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefix7()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Prefix7);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Prefixref()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Prefixref);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Readonly()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Readonly);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Refanytype()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Refanytype);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Refanyval()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Refanyval);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Rem()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Rem);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Rem_Un()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Rem_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Rethrow()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Rethrow);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Shl()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Shl);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Shr()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Shr);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Shr_Un()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Shr_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Sizeof()
        {
            Pop(0);
            Push(1);

            _il.Emit(OpCodes.Sizeof);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Starg()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Starg);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Starg_S()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Starg_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem()
        {
            Pop(3);
            Push(0);

            _il.Emit(OpCodes.Stelem);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I()
        {
            Pop(3);
            Push(0);

            _il.Emit(OpCodes.Stelem_I);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I1()
        {
            Pop(3);
            Push(0);

            _il.Emit(OpCodes.Stelem_I1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I2()
        {
            Pop(3);
            Push(0);

            _il.Emit(OpCodes.Stelem_I2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I4()
        {
            Pop(3);
            Push(0);

            _il.Emit(OpCodes.Stelem_I4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popi8.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_I8()
        {
            Pop(3);
            Push(0);

            _il.Emit(OpCodes.Stelem_I8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popr4.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_R4()
        {
            Pop(3);
            Push(0);

            _il.Emit(OpCodes.Stelem_R4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popr8.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_R8()
        {
            Pop(3);
            Push(0);

            _il.Emit(OpCodes.Stelem_R8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_popi_popref.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stelem_Ref()
        {
            Pop(3);
            Push(0);

            _il.Emit(OpCodes.Stelem_Ref);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stfld()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Stfld);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Stind_I);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I1()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Stind_I1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I2()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Stind_I2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I4()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Stind_I4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi8.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_I8()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Stind_I8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popr4.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_R4()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Stind_R4);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popr8.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_R8()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Stind_R8);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stind_Ref()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Stind_Ref);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Stloc);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_0()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Stloc_0);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_1()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Stloc_1);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_2()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Stloc_2);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_3()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Stloc_3);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stloc_S()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Stloc_S);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi_pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stobj()
        {
            Pop(2);
            Push(0);

            _il.Emit(OpCodes.Stobj);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Stsfld()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Stsfld);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Sub()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Sub);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Sub_Ovf()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Sub_Ovf);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Sub_Ovf_Un()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Sub_Ovf_Un);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popi.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Switch()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Switch);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Tailcall()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Tailcall);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Throw()
        {
            Pop(1);
            Push(0);

            _il.Emit(OpCodes.Throw);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Unaligned()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Unaligned);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Pushi.</para>
        /// </summary>
        public ILEmitter Unbox()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Unbox);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Popref.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Unbox_Any()
        {
            Pop(1);
            Push(1);

            _il.Emit(OpCodes.Unbox_Any);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop0.</para>
        ///     <para>StackBehaviourPush: Push0.</para>
        /// </summary>
        public ILEmitter Volatile()
        {
            Pop(0);
            Push(0);

            _il.Emit(OpCodes.Volatile);

            return this;
        }

        /// <summary>
        ///     <para>TBD</para>
        ///     <para>StackBehaviourPop: Pop1_pop1.</para>
        ///     <para>StackBehaviourPush: Push1.</para>
        /// </summary>
        public ILEmitter Xor()
        {
            Pop(2);
            Push(1);

            _il.Emit(OpCodes.Xor);

            return this;
        }
    }
}
