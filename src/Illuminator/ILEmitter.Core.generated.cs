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
        /// </summary>
        public ILEmitter Add()
        {
            _il.Emit(OpCodes.Add);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Add_Ovf()
        {
            _il.Emit(OpCodes.Add_Ovf);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Add_Ovf_Un()
        {
            _il.Emit(OpCodes.Add_Ovf_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter And()
        {
            _il.Emit(OpCodes.And);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Arglist()
        {
            _il.Emit(OpCodes.Arglist);
            return this;
        }

        /// <summary>
        ///     Transfers control to a target instruction if two values are equal.
        /// </summary>
        public ILEmitter Beq(Label label)
        {
            _il.Emit(OpCodes.Beq, label);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Beq_S()
        {
            _il.Emit(OpCodes.Beq_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Bge()
        {
            _il.Emit(OpCodes.Bge);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Bge_S()
        {
            _il.Emit(OpCodes.Bge_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Bge_Un()
        {
            _il.Emit(OpCodes.Bge_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Bge_Un_S()
        {
            _il.Emit(OpCodes.Bge_Un_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Bgt()
        {
            _il.Emit(OpCodes.Bgt);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Bgt_S()
        {
            _il.Emit(OpCodes.Bgt_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Bgt_Un()
        {
            _il.Emit(OpCodes.Bgt_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Bgt_Un_S()
        {
            _il.Emit(OpCodes.Bgt_Un_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ble()
        {
            _il.Emit(OpCodes.Ble);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ble_S()
        {
            _il.Emit(OpCodes.Ble_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ble_Un()
        {
            _il.Emit(OpCodes.Ble_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ble_Un_S()
        {
            _il.Emit(OpCodes.Ble_Un_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Blt()
        {
            _il.Emit(OpCodes.Blt);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Blt_S()
        {
            _il.Emit(OpCodes.Blt_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Blt_Un()
        {
            _il.Emit(OpCodes.Blt_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Blt_Un_S()
        {
            _il.Emit(OpCodes.Blt_Un_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Bne_Un()
        {
            _il.Emit(OpCodes.Bne_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Bne_Un_S()
        {
            _il.Emit(OpCodes.Bne_Un_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Box()
        {
            _il.Emit(OpCodes.Box);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Br()
        {
            _il.Emit(OpCodes.Br);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Br_S()
        {
            _il.Emit(OpCodes.Br_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Break()
        {
            _il.Emit(OpCodes.Break);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Brfalse()
        {
            _il.Emit(OpCodes.Brfalse);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Brfalse_S()
        {
            _il.Emit(OpCodes.Brfalse_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Brtrue()
        {
            _il.Emit(OpCodes.Brtrue);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Brtrue_S()
        {
            _il.Emit(OpCodes.Brtrue_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Call()
        {
            _il.Emit(OpCodes.Call);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Calli()
        {
            _il.Emit(OpCodes.Calli);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Callvirt()
        {
            _il.Emit(OpCodes.Callvirt);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Castclass()
        {
            _il.Emit(OpCodes.Castclass);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ceq()
        {
            _il.Emit(OpCodes.Ceq);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Cgt()
        {
            _il.Emit(OpCodes.Cgt);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Cgt_Un()
        {
            _il.Emit(OpCodes.Cgt_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ckfinite()
        {
            _il.Emit(OpCodes.Ckfinite);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Clt()
        {
            _il.Emit(OpCodes.Clt);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Clt_Un()
        {
            _il.Emit(OpCodes.Clt_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Constrained()
        {
            _il.Emit(OpCodes.Constrained);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_I()
        {
            _il.Emit(OpCodes.Conv_I);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_I1()
        {
            _il.Emit(OpCodes.Conv_I1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_I2()
        {
            _il.Emit(OpCodes.Conv_I2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_I4()
        {
            _il.Emit(OpCodes.Conv_I4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_I8()
        {
            _il.Emit(OpCodes.Conv_I8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_I()
        {
            _il.Emit(OpCodes.Conv_Ovf_I);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_I1()
        {
            _il.Emit(OpCodes.Conv_Ovf_I1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_I1_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I1_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_I2()
        {
            _il.Emit(OpCodes.Conv_Ovf_I2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_I2_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I2_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_I4()
        {
            _il.Emit(OpCodes.Conv_Ovf_I4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_I4_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I4_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_I8()
        {
            _il.Emit(OpCodes.Conv_Ovf_I8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_I8_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I8_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_I_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_I_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_U()
        {
            _il.Emit(OpCodes.Conv_Ovf_U);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_U1()
        {
            _il.Emit(OpCodes.Conv_Ovf_U1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_U1_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U1_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_U2()
        {
            _il.Emit(OpCodes.Conv_Ovf_U2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_U2_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U2_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_U4()
        {
            _il.Emit(OpCodes.Conv_Ovf_U4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_U4_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U4_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_U8()
        {
            _il.Emit(OpCodes.Conv_Ovf_U8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_U8_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U8_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_Ovf_U_Un()
        {
            _il.Emit(OpCodes.Conv_Ovf_U_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_R4()
        {
            _il.Emit(OpCodes.Conv_R4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_R8()
        {
            _il.Emit(OpCodes.Conv_R8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_R_Un()
        {
            _il.Emit(OpCodes.Conv_R_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_U()
        {
            _il.Emit(OpCodes.Conv_U);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_U1()
        {
            _il.Emit(OpCodes.Conv_U1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_U2()
        {
            _il.Emit(OpCodes.Conv_U2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_U4()
        {
            _il.Emit(OpCodes.Conv_U4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Conv_U8()
        {
            _il.Emit(OpCodes.Conv_U8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Cpblk()
        {
            _il.Emit(OpCodes.Cpblk);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Cpobj()
        {
            _il.Emit(OpCodes.Cpobj);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Div()
        {
            _il.Emit(OpCodes.Div);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Div_Un()
        {
            _il.Emit(OpCodes.Div_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Dup()
        {
            _il.Emit(OpCodes.Dup);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Endfilter()
        {
            _il.Emit(OpCodes.Endfilter);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Endfinally()
        {
            _il.Emit(OpCodes.Endfinally);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Initblk()
        {
            _il.Emit(OpCodes.Initblk);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Initobj()
        {
            _il.Emit(OpCodes.Initobj);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Isinst()
        {
            _il.Emit(OpCodes.Isinst);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Jmp()
        {
            _il.Emit(OpCodes.Jmp);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldarg()
        {
            _il.Emit(OpCodes.Ldarg);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldarg_0()
        {
            _il.Emit(OpCodes.Ldarg_0);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldarg_1()
        {
            _il.Emit(OpCodes.Ldarg_1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldarg_2()
        {
            _il.Emit(OpCodes.Ldarg_2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldarg_3()
        {
            _il.Emit(OpCodes.Ldarg_3);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldarg_S()
        {
            _il.Emit(OpCodes.Ldarg_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldarga()
        {
            _il.Emit(OpCodes.Ldarga);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldarga_S()
        {
            _il.Emit(OpCodes.Ldarga_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_I4()
        {
            _il.Emit(OpCodes.Ldc_I4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_I4_0()
        {
            _il.Emit(OpCodes.Ldc_I4_0);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_I4_1()
        {
            _il.Emit(OpCodes.Ldc_I4_1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_I4_2()
        {
            _il.Emit(OpCodes.Ldc_I4_2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_I4_3()
        {
            _il.Emit(OpCodes.Ldc_I4_3);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_I4_4()
        {
            _il.Emit(OpCodes.Ldc_I4_4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_I4_5()
        {
            _il.Emit(OpCodes.Ldc_I4_5);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_I4_6()
        {
            _il.Emit(OpCodes.Ldc_I4_6);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_I4_7()
        {
            _il.Emit(OpCodes.Ldc_I4_7);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_I4_8()
        {
            _il.Emit(OpCodes.Ldc_I4_8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_I4_M1()
        {
            _il.Emit(OpCodes.Ldc_I4_M1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_I4_S()
        {
            _il.Emit(OpCodes.Ldc_I4_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_I8()
        {
            _il.Emit(OpCodes.Ldc_I8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_R4()
        {
            _il.Emit(OpCodes.Ldc_R4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldc_R8()
        {
            _il.Emit(OpCodes.Ldc_R8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldelem()
        {
            _il.Emit(OpCodes.Ldelem);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldelem_I()
        {
            _il.Emit(OpCodes.Ldelem_I);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldelem_I1()
        {
            _il.Emit(OpCodes.Ldelem_I1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldelem_I2()
        {
            _il.Emit(OpCodes.Ldelem_I2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldelem_I4()
        {
            _il.Emit(OpCodes.Ldelem_I4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldelem_I8()
        {
            _il.Emit(OpCodes.Ldelem_I8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldelem_R4()
        {
            _il.Emit(OpCodes.Ldelem_R4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldelem_R8()
        {
            _il.Emit(OpCodes.Ldelem_R8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldelem_Ref()
        {
            _il.Emit(OpCodes.Ldelem_Ref);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldelem_U1()
        {
            _il.Emit(OpCodes.Ldelem_U1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldelem_U2()
        {
            _il.Emit(OpCodes.Ldelem_U2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldelem_U4()
        {
            _il.Emit(OpCodes.Ldelem_U4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldelema()
        {
            _il.Emit(OpCodes.Ldelema);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldfld()
        {
            _il.Emit(OpCodes.Ldfld);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldflda()
        {
            _il.Emit(OpCodes.Ldflda);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldftn()
        {
            _il.Emit(OpCodes.Ldftn);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldind_I()
        {
            _il.Emit(OpCodes.Ldind_I);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldind_I1()
        {
            _il.Emit(OpCodes.Ldind_I1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldind_I2()
        {
            _il.Emit(OpCodes.Ldind_I2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldind_I4()
        {
            _il.Emit(OpCodes.Ldind_I4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldind_I8()
        {
            _il.Emit(OpCodes.Ldind_I8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldind_R4()
        {
            _il.Emit(OpCodes.Ldind_R4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldind_R8()
        {
            _il.Emit(OpCodes.Ldind_R8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldind_Ref()
        {
            _il.Emit(OpCodes.Ldind_Ref);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldind_U1()
        {
            _il.Emit(OpCodes.Ldind_U1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldind_U2()
        {
            _il.Emit(OpCodes.Ldind_U2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldind_U4()
        {
            _il.Emit(OpCodes.Ldind_U4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldlen()
        {
            _il.Emit(OpCodes.Ldlen);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldloc()
        {
            _il.Emit(OpCodes.Ldloc);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldloc_0()
        {
            _il.Emit(OpCodes.Ldloc_0);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldloc_1()
        {
            _il.Emit(OpCodes.Ldloc_1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldloc_2()
        {
            _il.Emit(OpCodes.Ldloc_2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldloc_3()
        {
            _il.Emit(OpCodes.Ldloc_3);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldloc_S()
        {
            _il.Emit(OpCodes.Ldloc_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldloca()
        {
            _il.Emit(OpCodes.Ldloca);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldloca_S()
        {
            _il.Emit(OpCodes.Ldloca_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldnull()
        {
            _il.Emit(OpCodes.Ldnull);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldobj()
        {
            _il.Emit(OpCodes.Ldobj);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldsfld()
        {
            _il.Emit(OpCodes.Ldsfld);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldsflda()
        {
            _il.Emit(OpCodes.Ldsflda);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldstr()
        {
            _il.Emit(OpCodes.Ldstr);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldtoken()
        {
            _il.Emit(OpCodes.Ldtoken);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ldvirtftn()
        {
            _il.Emit(OpCodes.Ldvirtftn);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Leave()
        {
            _il.Emit(OpCodes.Leave);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Leave_S()
        {
            _il.Emit(OpCodes.Leave_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Localloc()
        {
            _il.Emit(OpCodes.Localloc);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Mkrefany()
        {
            _il.Emit(OpCodes.Mkrefany);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Mul()
        {
            _il.Emit(OpCodes.Mul);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Mul_Ovf()
        {
            _il.Emit(OpCodes.Mul_Ovf);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Mul_Ovf_Un()
        {
            _il.Emit(OpCodes.Mul_Ovf_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Neg()
        {
            _il.Emit(OpCodes.Neg);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Newarr()
        {
            _il.Emit(OpCodes.Newarr);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Newobj()
        {
            _il.Emit(OpCodes.Newobj);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Nop()
        {
            _il.Emit(OpCodes.Nop);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Not()
        {
            _il.Emit(OpCodes.Not);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Or()
        {
            _il.Emit(OpCodes.Or);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Pop()
        {
            _il.Emit(OpCodes.Pop);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Prefix1()
        {
            _il.Emit(OpCodes.Prefix1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Prefix2()
        {
            _il.Emit(OpCodes.Prefix2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Prefix3()
        {
            _il.Emit(OpCodes.Prefix3);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Prefix4()
        {
            _il.Emit(OpCodes.Prefix4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Prefix5()
        {
            _il.Emit(OpCodes.Prefix5);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Prefix6()
        {
            _il.Emit(OpCodes.Prefix6);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Prefix7()
        {
            _il.Emit(OpCodes.Prefix7);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Prefixref()
        {
            _il.Emit(OpCodes.Prefixref);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Readonly()
        {
            _il.Emit(OpCodes.Readonly);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Refanytype()
        {
            _il.Emit(OpCodes.Refanytype);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Refanyval()
        {
            _il.Emit(OpCodes.Refanyval);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Rem()
        {
            _il.Emit(OpCodes.Rem);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Rem_Un()
        {
            _il.Emit(OpCodes.Rem_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Ret()
        {
            _il.Emit(OpCodes.Ret);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Rethrow()
        {
            _il.Emit(OpCodes.Rethrow);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Shl()
        {
            _il.Emit(OpCodes.Shl);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Shr()
        {
            _il.Emit(OpCodes.Shr);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Shr_Un()
        {
            _il.Emit(OpCodes.Shr_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Sizeof()
        {
            _il.Emit(OpCodes.Sizeof);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Starg()
        {
            _il.Emit(OpCodes.Starg);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Starg_S()
        {
            _il.Emit(OpCodes.Starg_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stelem()
        {
            _il.Emit(OpCodes.Stelem);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stelem_I()
        {
            _il.Emit(OpCodes.Stelem_I);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stelem_I1()
        {
            _il.Emit(OpCodes.Stelem_I1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stelem_I2()
        {
            _il.Emit(OpCodes.Stelem_I2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stelem_I4()
        {
            _il.Emit(OpCodes.Stelem_I4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stelem_I8()
        {
            _il.Emit(OpCodes.Stelem_I8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stelem_R4()
        {
            _il.Emit(OpCodes.Stelem_R4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stelem_R8()
        {
            _il.Emit(OpCodes.Stelem_R8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stelem_Ref()
        {
            _il.Emit(OpCodes.Stelem_Ref);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stfld()
        {
            _il.Emit(OpCodes.Stfld);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stind_I()
        {
            _il.Emit(OpCodes.Stind_I);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stind_I1()
        {
            _il.Emit(OpCodes.Stind_I1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stind_I2()
        {
            _il.Emit(OpCodes.Stind_I2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stind_I4()
        {
            _il.Emit(OpCodes.Stind_I4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stind_I8()
        {
            _il.Emit(OpCodes.Stind_I8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stind_R4()
        {
            _il.Emit(OpCodes.Stind_R4);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stind_R8()
        {
            _il.Emit(OpCodes.Stind_R8);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stind_Ref()
        {
            _il.Emit(OpCodes.Stind_Ref);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stloc()
        {
            _il.Emit(OpCodes.Stloc);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stloc_0()
        {
            _il.Emit(OpCodes.Stloc_0);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stloc_1()
        {
            _il.Emit(OpCodes.Stloc_1);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stloc_2()
        {
            _il.Emit(OpCodes.Stloc_2);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stloc_3()
        {
            _il.Emit(OpCodes.Stloc_3);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stloc_S()
        {
            _il.Emit(OpCodes.Stloc_S);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stobj()
        {
            _il.Emit(OpCodes.Stobj);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Stsfld()
        {
            _il.Emit(OpCodes.Stsfld);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Sub()
        {
            _il.Emit(OpCodes.Sub);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Sub_Ovf()
        {
            _il.Emit(OpCodes.Sub_Ovf);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Sub_Ovf_Un()
        {
            _il.Emit(OpCodes.Sub_Ovf_Un);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Switch()
        {
            _il.Emit(OpCodes.Switch);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Tailcall()
        {
            _il.Emit(OpCodes.Tailcall);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Throw()
        {
            _il.Emit(OpCodes.Throw);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Unaligned()
        {
            _il.Emit(OpCodes.Unaligned);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Unbox()
        {
            _il.Emit(OpCodes.Unbox);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Unbox_Any()
        {
            _il.Emit(OpCodes.Unbox_Any);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Volatile()
        {
            _il.Emit(OpCodes.Volatile);
            return this;
        }

        /// <summary>
        ///     TBD
        /// </summary>
        public ILEmitter Xor()
        {
            _il.Emit(OpCodes.Xor);
            return this;
        }
    }
}
