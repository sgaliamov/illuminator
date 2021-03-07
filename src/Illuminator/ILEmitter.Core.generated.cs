/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System.Reflection.Emit;

namespace Illuminator
{
    public sealed partial class ILEmitter
    {
        /// <summary>
        ///     Adds two values and pushes the result onto the evaluation stack.
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Add()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Add);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Add_Ovf()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Add_Ovf);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Add_Ovf_Un()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Add_Ovf_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter And()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.And);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Arglist()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Arglist);
            
            return this;
        }

        /// <summary>
        ///     Transfers control to a target instruction if two values are equal.
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Beq(Label label)
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Beq, label);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Beq_S()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Beq_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Bge()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Bge);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Bge_S()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Bge_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Bge_Un()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Bge_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Bge_Un_S()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Bge_Un_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Bgt()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Bgt);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Bgt_S()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Bgt_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Bgt_Un()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Bgt_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Bgt_Un_S()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Bgt_Un_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Ble()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ble);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Ble_S()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ble_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Ble_Un()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ble_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Ble_Un_S()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ble_Un_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Blt()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Blt);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Blt_S()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Blt_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Blt_Un()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Blt_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Blt_Un_S()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Blt_Un_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Bne_Un()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Bne_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Bne_Un_S()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Bne_Un_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushref.
        /// </summary>
        public ILEmitter Box()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Box);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Br()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Br);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Br_S()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Br_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Break()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Break);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Brfalse()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Brfalse);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Brfalse_S()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Brfalse_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Brtrue()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Brtrue);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Brtrue_S()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Brtrue_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Varpop.
        ///     StackBehaviourPush: Varpush.
        /// </summary>
        public ILEmitter Call()
        {
            Pop(-1);
            Push(-1);
            
            _il.Emit(OpCodes.Call);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Varpop.
        ///     StackBehaviourPush: Varpush.
        /// </summary>
        public ILEmitter Calli()
        {
            Pop(-1);
            Push(-1);
            
            _il.Emit(OpCodes.Calli);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Varpop.
        ///     StackBehaviourPush: Varpush.
        /// </summary>
        public ILEmitter Callvirt()
        {
            Pop(-1);
            Push(-1);
            
            _il.Emit(OpCodes.Callvirt);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref.
        ///     StackBehaviourPush: Pushref.
        /// </summary>
        public ILEmitter Castclass()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Castclass);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ceq()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ceq);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Cgt()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Cgt);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Cgt_Un()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Cgt_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushr8.
        /// </summary>
        public ILEmitter Ckfinite()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ckfinite);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Clt()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Clt);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Clt_Un()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Clt_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Constrained()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Constrained);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_I()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_I);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_I1()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_I1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_I2()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_I2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_I4()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_I4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi8.
        /// </summary>
        public ILEmitter Conv_I8()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_I8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_I()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_I);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_I1()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_I1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_I1_Un()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_I1_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_I2()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_I2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_I2_Un()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_I2_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_I4()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_I4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_I4_Un()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_I4_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi8.
        /// </summary>
        public ILEmitter Conv_Ovf_I8()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_I8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi8.
        /// </summary>
        public ILEmitter Conv_Ovf_I8_Un()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_I8_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_I_Un()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_I_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_U()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_U);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_U1()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_U1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_U1_Un()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_U1_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_U2()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_U2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_U2_Un()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_U2_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_U4()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_U4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_U4_Un()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_U4_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi8.
        /// </summary>
        public ILEmitter Conv_Ovf_U8()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_U8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi8.
        /// </summary>
        public ILEmitter Conv_Ovf_U8_Un()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_U8_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_Ovf_U_Un()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_Ovf_U_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushr4.
        /// </summary>
        public ILEmitter Conv_R4()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_R4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushr8.
        /// </summary>
        public ILEmitter Conv_R8()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_R8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushr8.
        /// </summary>
        public ILEmitter Conv_R_Un()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_R_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_U()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_U);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_U1()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_U1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_U2()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_U2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Conv_U4()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_U4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi8.
        /// </summary>
        public ILEmitter Conv_U8()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Conv_U8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Popi_popi_popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Cpblk()
        {
            Pop(3);
            Push(1);
            
            _il.Emit(OpCodes.Cpblk);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi_popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Cpobj()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Cpobj);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Div()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Div);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Div_Un()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Div_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Push1_push1.
        /// </summary>
        public ILEmitter Dup()
        {
            Pop(1);
            Push(2);
            
            _il.Emit(OpCodes.Dup);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Endfilter()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Endfilter);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Endfinally()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Endfinally);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Popi_popi_popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Initblk()
        {
            Pop(3);
            Push(1);
            
            _il.Emit(OpCodes.Initblk);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Initobj()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Initobj);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Isinst()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Isinst);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Jmp()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Jmp);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldarg()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldarg);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldarg_0()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldarg_0);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldarg_1()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldarg_1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldarg_2()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldarg_2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldarg_3()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldarg_3);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldarg_S()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldarg_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldarga()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldarga);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldarga_S()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldarga_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldc_I4()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_I4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldc_I4_0()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_I4_0);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldc_I4_1()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_I4_1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldc_I4_2()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_I4_2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldc_I4_3()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_I4_3);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldc_I4_4()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_I4_4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldc_I4_5()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_I4_5);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldc_I4_6()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_I4_6);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldc_I4_7()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_I4_7);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldc_I4_8()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_I4_8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldc_I4_M1()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_I4_M1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldc_I4_S()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_I4_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi8.
        /// </summary>
        public ILEmitter Ldc_I8()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_I8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushr4.
        /// </summary>
        public ILEmitter Ldc_R4()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_R4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushr8.
        /// </summary>
        public ILEmitter Ldc_R8()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldc_R8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldelem()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ldelem);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldelem_I()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ldelem_I);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldelem_I1()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ldelem_I1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldelem_I2()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ldelem_I2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldelem_I4()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ldelem_I4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi.
        ///     StackBehaviourPush: Pushi8.
        /// </summary>
        public ILEmitter Ldelem_I8()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ldelem_I8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi.
        ///     StackBehaviourPush: Pushr4.
        /// </summary>
        public ILEmitter Ldelem_R4()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ldelem_R4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi.
        ///     StackBehaviourPush: Pushr8.
        /// </summary>
        public ILEmitter Ldelem_R8()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ldelem_R8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi.
        ///     StackBehaviourPush: Pushref.
        /// </summary>
        public ILEmitter Ldelem_Ref()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ldelem_Ref);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldelem_U1()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ldelem_U1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldelem_U2()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ldelem_U2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldelem_U4()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ldelem_U4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldelema()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Ldelema);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldfld()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldfld);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldflda()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldflda);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldftn()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldftn);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldind_I()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldind_I);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldind_I1()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldind_I1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldind_I2()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldind_I2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldind_I4()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldind_I4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Pushi8.
        /// </summary>
        public ILEmitter Ldind_I8()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldind_I8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Pushr4.
        /// </summary>
        public ILEmitter Ldind_R4()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldind_R4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Pushr8.
        /// </summary>
        public ILEmitter Ldind_R8()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldind_R8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Pushref.
        /// </summary>
        public ILEmitter Ldind_Ref()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldind_Ref);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldind_U1()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldind_U1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldind_U2()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldind_U2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldind_U4()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldind_U4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldlen()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldlen);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldloc()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldloc);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldloc_0()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldloc_0);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldloc_1()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldloc_1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldloc_2()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldloc_2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldloc_3()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldloc_3);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldloc_S()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldloc_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldloca()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldloca);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldloca_S()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldloca_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushref.
        /// </summary>
        public ILEmitter Ldnull()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldnull);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldobj()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldobj);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Ldsfld()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldsfld);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldsflda()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldsflda);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushref.
        /// </summary>
        public ILEmitter Ldstr()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldstr);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldtoken()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Ldtoken);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Popref.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Ldvirtftn()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Ldvirtftn);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Leave()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Leave);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Leave_S()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Leave_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Localloc()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Localloc);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Mkrefany()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Mkrefany);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Mul()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Mul);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Mul_Ovf()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Mul_Ovf);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Mul_Ovf_Un()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Mul_Ovf_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Neg()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Neg);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Pushref.
        /// </summary>
        public ILEmitter Newarr()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Newarr);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Varpop.
        ///     StackBehaviourPush: Pushref.
        /// </summary>
        public ILEmitter Newobj()
        {
            Pop(-1);
            Push(1);
            
            _il.Emit(OpCodes.Newobj);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Nop()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Nop);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Not()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Not);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Or()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Or);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Pop()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Pop);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Prefix1()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Prefix1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Prefix2()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Prefix2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Prefix3()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Prefix3);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Prefix4()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Prefix4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Prefix5()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Prefix5);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Prefix6()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Prefix6);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Prefix7()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Prefix7);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Prefixref()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Prefixref);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Readonly()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Readonly);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Refanytype()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Refanytype);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Refanyval()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Refanyval);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Rem()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Rem);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Rem_Un()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Rem_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Varpop.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Ret()
        {
            Pop(-1);
            Push(1);
            
            _il.Emit(OpCodes.Ret);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Rethrow()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Rethrow);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Shl()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Shl);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Shr()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Shr);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Shr_Un()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Shr_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Sizeof()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Sizeof);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Starg()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Starg);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Starg_S()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Starg_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stelem()
        {
            Pop(3);
            Push(1);
            
            _il.Emit(OpCodes.Stelem);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi_popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stelem_I()
        {
            Pop(3);
            Push(1);
            
            _il.Emit(OpCodes.Stelem_I);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi_popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stelem_I1()
        {
            Pop(3);
            Push(1);
            
            _il.Emit(OpCodes.Stelem_I1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi_popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stelem_I2()
        {
            Pop(3);
            Push(1);
            
            _il.Emit(OpCodes.Stelem_I2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi_popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stelem_I4()
        {
            Pop(3);
            Push(1);
            
            _il.Emit(OpCodes.Stelem_I4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi_popi8.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stelem_I8()
        {
            Pop(3);
            Push(1);
            
            _il.Emit(OpCodes.Stelem_I8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi_popr4.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stelem_R4()
        {
            Pop(3);
            Push(1);
            
            _il.Emit(OpCodes.Stelem_R4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi_popr8.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stelem_R8()
        {
            Pop(3);
            Push(1);
            
            _il.Emit(OpCodes.Stelem_R8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_popi_popref.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stelem_Ref()
        {
            Pop(3);
            Push(1);
            
            _il.Emit(OpCodes.Stelem_Ref);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stfld()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Stfld);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi_popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stind_I()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Stind_I);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi_popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stind_I1()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Stind_I1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi_popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stind_I2()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Stind_I2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi_popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stind_I4()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Stind_I4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi_popi8.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stind_I8()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Stind_I8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi_popr4.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stind_R4()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Stind_R4);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi_popr8.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stind_R8()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Stind_R8);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi_popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stind_Ref()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Stind_Ref);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stloc()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Stloc);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stloc_0()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Stloc_0);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stloc_1()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Stloc_1);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stloc_2()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Stloc_2);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stloc_3()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Stloc_3);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stloc_S()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Stloc_S);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi_pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stobj()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Stobj);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Stsfld()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Stsfld);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Sub()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Sub);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Sub_Ovf()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Sub_Ovf);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Sub_Ovf_Un()
        {
            Pop(2);
            Push(1);
            
            _il.Emit(OpCodes.Sub_Ovf_Un);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popi.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Switch()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Switch);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Tailcall()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Tailcall);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Throw()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Throw);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Unaligned()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Unaligned);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref.
        ///     StackBehaviourPush: Pushi.
        /// </summary>
        public ILEmitter Unbox()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Unbox);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Popref.
        ///     StackBehaviourPush: Push1.
        /// </summary>
        public ILEmitter Unbox_Any()
        {
            Pop(1);
            Push(1);
            
            _il.Emit(OpCodes.Unbox_Any);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 2.
        ///     StackBehaviourPop: Pop0.
        ///     StackBehaviourPush: Push0.
        /// </summary>
        public ILEmitter Volatile()
        {
            Pop(0);
            Push(1);
            
            _il.Emit(OpCodes.Volatile);
            
            return this;
        }

        /// <summary>
        ///     TBD
        ///     Size: 1.
        ///     StackBehaviourPop: Pop1_pop1.
        ///     StackBehaviourPush: Push1.
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
