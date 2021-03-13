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
            Pop("any", "any");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Push("int");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any", "any");

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
            Pop("any");
            Push("ref");

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
            Pop("int");

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
            Pop("int");

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
            Pop("int");

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
            Pop("int");

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
            Pop("ref");
            Push("ref");

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
            Pop("any", "any");
            Push("int");

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
            Pop("any", "any");
            Push("int");

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
            Pop("any", "any");
            Push("int");

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
            Pop("any");
            Push("double");

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
            Pop("any", "any");
            Push("int");

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
            Pop("any", "any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("long");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("long");

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
            Pop("any");
            Push("long");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("long");

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
            Pop("any");
            Push("long");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("float");

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
            Pop("any");
            Push("double");

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
            Pop("any");
            Push("double");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("long");

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
            Pop("int", "int", "int");

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
            Pop("int", "int");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any");
            Push("any", "any");

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
            Pop("int");

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
            Pop("int", "int", "int");

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
            Pop("int");

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
            Pop("ref");
            Push("int");

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
            Push("any");

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
            Push("any");

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
            Push("any");

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
            Push("any");

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
            Push("any");

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
            Push("any");

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
            Push("int");

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
            Push("int");

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
            Push("int");

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
            Push("int");

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
            Push("int");

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
            Push("int");

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
            Push("int");

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
            Push("int");

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
            Push("int");

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
            Push("int");

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
            Push("int");

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
            Push("int");

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
            Push("int");

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
            Push("int");

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
            Push("long");

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
            Push("float");

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
            Push("double");

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
            Pop("ref", "int");
            Push("any");

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
            Pop("ref", "int");
            Push("int");

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
            Pop("ref", "int");
            Push("int");

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
            Pop("ref", "int");
            Push("int");

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
            Pop("ref", "int");
            Push("int");

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
            Pop("ref", "int");
            Push("long");

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
            Pop("ref", "int");
            Push("float");

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
            Pop("ref", "int");
            Push("double");

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
            Pop("ref", "int");
            Push("ref");

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
            Pop("ref", "int");
            Push("int");

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
            Pop("ref", "int");
            Push("int");

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
            Pop("ref", "int");
            Push("int");

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
            Pop("ref", "int");
            Push("int");

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
            Pop("ref");
            Push("any");

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
            Pop("ref");
            Push("int");

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
            Push("int");

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
            Pop("int");
            Push("int");

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
            Pop("int");
            Push("int");

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
            Pop("int");
            Push("int");

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
            Pop("int");
            Push("int");

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
            Pop("int");
            Push("long");

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
            Pop("int");
            Push("float");

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
            Pop("int");
            Push("double");

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
            Pop("int");
            Push("ref");

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
            Pop("int");
            Push("int");

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
            Pop("int");
            Push("int");

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
            Pop("int");
            Push("int");

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
            Pop("ref");
            Push("int");

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
            Push("any");

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
            Push("any");

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
            Push("any");

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
            Push("any");

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
            Push("any");

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
            Push("any");

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
            Push("int");

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
            Push("int");

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
            Push("ref");

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
            Pop("int");
            Push("any");

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
            Push("any");

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
            Push("int");

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
            Push("ref");

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
            Push("int");

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
            Pop("ref");
            Push("int");

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
            Pop("int");
            Push("int");

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
            Pop("int");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any");
            Push("any");

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
            Pop("int");
            Push("ref");

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
            Pop("any");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any");

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
            Pop("any");
            Push("int");

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
            Pop("any");
            Push("int");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Push("int");

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
            Pop("any");

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
            Pop("any");

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
            Pop("ref", "int", "any");

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
            Pop("ref", "int", "int");

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
            Pop("ref", "int", "int");

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
            Pop("ref", "int", "int");

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
            Pop("ref", "int", "int");

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
            Pop("ref", "int", "long");

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
            Pop("ref", "int", "float");

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
            Pop("ref", "int", "double");

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
            Pop("ref", "int", "ref");

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
            Pop("ref", "any");

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
            Pop("int", "int");

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
            Pop("int", "int");

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
            Pop("int", "int");

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
            Pop("int", "int");

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
            Pop("int", "long");

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
            Pop("int", "float");

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
            Pop("int", "double");

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
            Pop("int", "int");

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
            Pop("any");

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
            Pop("any");

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
            Pop("any");

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
            Pop("any");

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
            Pop("any");

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
            Pop("any");

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
            Pop("int", "any");

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
            Pop("any");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Pop("any", "any");
            Push("any");

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
            Pop("int");

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
            Pop("ref");

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
            Pop("ref");
            Push("int");

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
            Pop("ref");
            Push("any");

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
            Pop("any", "any");
            Push("any");

            return this;
        }
    }
}
