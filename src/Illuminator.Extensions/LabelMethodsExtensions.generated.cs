/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System.Reflection.Emit;

namespace Illuminator.Extensions
{
    public static class LabelMethodsExtensions
    {
        /// <summary>
        ///     Transfers control to a target instruction if two values are equal.
        /// </summary>
        public static ILEmitter Beq(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Beq(label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if two values are equal.
        /// </summary>
        public static ILEmitter Beq_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Beq_S(label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than or equal to the second value.
        /// </summary>
        public static ILEmitter Bge(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Bge(label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than or equal to the second value.
        /// </summary>
        public static ILEmitter Bge_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Bge_S(label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Bge_Un(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Bge_Un(label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Bge_Un_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Bge_Un_S(label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than the second value.
        /// </summary>
        public static ILEmitter Bgt(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Bgt(label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than the second value.
        /// </summary>
        public static ILEmitter Bgt_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Bgt_S(label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Bgt_Un(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Bgt_Un(label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Bgt_Un_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Bgt_Un_S(label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than or equal to the second value.
        /// </summary>
        public static ILEmitter Ble(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Ble(label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than or equal to the second value.
        /// </summary>
        public static ILEmitter Ble_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Ble_S(label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Ble_Un(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Ble_Un(label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Ble_Un_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Ble_Un_S(label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than the second value.
        /// </summary>
        public static ILEmitter Blt(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Blt(label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than the second value.
        /// </summary>
        public static ILEmitter Blt_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Blt_S(label);

        /// <summary>
        ///     Transfers control to a target instruction if the first value is less than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Blt_Un(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Blt_Un(label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if the first value is less than the second value, when comparing unsigned integer values or unordered float values.
        /// </summary>
        public static ILEmitter Blt_Un_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Blt_Un_S(label);

        /// <summary>
        ///     Transfers control to a target instruction when two unsigned integer values or unordered float values are not equal.
        /// </summary>
        public static ILEmitter Bne_Un(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Bne_Un(label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) when two unsigned integer values or unordered float values are not equal.
        /// </summary>
        public static ILEmitter Bne_Un_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Bne_Un_S(label);

        /// <summary>
        ///     Unconditionally transfers control to a target instruction.
        /// </summary>
        public static ILEmitter Br(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Br(label);

        /// <summary>
        ///     Unconditionally transfers control to a target instruction (short form).
        /// </summary>
        public static ILEmitter Br_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Br_S(label);

        /// <summary>
        ///     Transfers control to a target instruction if value is false, a null reference (Nothing in Visual Basic), or zero.
        /// </summary>
        public static ILEmitter Brfalse(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Brfalse(label);

        /// <summary>
        ///     Transfers control to a target instruction if value is false, a null reference, or zero.
        /// </summary>
        public static ILEmitter Brfalse_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Brfalse_S(label);

        /// <summary>
        ///     Transfers control to a target instruction if value is true, not null, or non-zero.
        /// </summary>
        public static ILEmitter Brtrue(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Brtrue(label);

        /// <summary>
        ///     Transfers control to a target instruction (short form) if value is true, not null, or non-zero.
        /// </summary>
        public static ILEmitter Brtrue_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Brtrue_S(label);

        /// <summary>
        ///     Exits a protected region of code, unconditionally transferring control to a specific target instruction.
        /// </summary>
        public static ILEmitter Leave(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Leave(label);

        /// <summary>
        ///     Exits a protected region of code, unconditionally transferring control to a target instruction (short form).
        /// </summary>
        public static ILEmitter Leave_S(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Leave_S(label);

        /// <summary>
        ///     Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.
        /// </summary>
        public static ILEmitter Unaligned(this ILEmitter self, out Label label) =>
            self.DefineLabel(out label)
                .Unaligned(label);
    }
}
