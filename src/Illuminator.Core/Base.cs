using System;
using System.Diagnostics.SymbolStore;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Illuminator.Core
{
    public sealed class ILEmitter
    {
        private readonly ILGenerator _il;

        public ILEmitter(ILGenerator il) => _il = il;

        public ILEmitter Add() => Emit(OpCodes.Add);
        public ILEmitter Ldarg(int index) => Emit(OpCodes.Ldarg, index);
        public ILEmitter Brtrue(Label label) => Emit(OpCodes.Brtrue, label);

        #region Emit

        private ILEmitter Emit(OpCode opcode) => this;

        private ILEmitter Emit(OpCode opcode, byte arg) => this;

        public void Emit(OpCode opcode, sbyte arg)
        {
            return this;
        }

        private ILEmitter Emit(OpCode opcode, short arg) => this;

        private ILEmitter Emit(OpCode opcode, int arg) => this;

        private ILEmitter Emit(OpCode opcode, MethodInfo meth) => this;


        private ILEmitter EmitCalli(OpCode opcode, CallingConventions callingConvention,
            Type? returnType, Type[]? parameterTypes, Type[]? optionalParameterTypes) =>
            this;

        private ILEmitter EmitCalli(OpCode opcode, CallingConvention unmanagedCallConv, Type? returnType, Type[]? parameterTypes) => this;


        private ILEmitter EmitCall(OpCode opcode, MethodInfo methodInfo, Type[]? optionalParameterTypes) => this;

        private ILEmitter Emit(OpCode opcode, SignatureHelper signature) => this;

        private ILEmitter Emit(OpCode opcode, ConstructorInfo con) => this;

        private ILEmitter Emit(OpCode opcode, Type cls) => this;

        private ILEmitter Emit(OpCode opcode, long arg) => this;

        private ILEmitter Emit(OpCode opcode, float arg) => this;

        private ILEmitter Emit(OpCode opcode, double arg) => this;

        private ILEmitter Emit(OpCode opcode, Label label) => this;


        private ILEmitter Emit(OpCode opcode, Label[] labels) => this;


        private ILEmitter Emit(OpCode opcode, FieldInfo field) => this;

        private ILEmitter Emit(OpCode opcode, string str) => this;

        private ILEmitter Emit(OpCode opcode, LocalBuilder local) => this;

        #endregion

        #region Exceptions

        public Label BeginExceptionBlock() => this;


        private ILEmitter EndExceptionBlock() => this;


        private ILEmitter BeginExceptFilterBlock() => this;

        private ILEmitter BeginCatchBlock(Type exceptionType) => this;


        private ILEmitter BeginFaultBlock() => this;


        private ILEmitter BeginFinallyBlock() => this;

        #endregion

        #region Labels

        public Label DefineLabel() => this;

        private ILEmitter MarkLabel(Label loc) => this;

        #endregion

        #region IL Macros

        private ILEmitter ThrowException(Type excType) => this;

        private ILEmitter EmitWriteLine(string value) => this;

        private ILEmitter EmitWriteLine(LocalBuilder localBuilder) => this;


        private ILEmitter EmitWriteLine(FieldInfo fld) => this;

        #endregion

        #region Debug API

        public LocalBuilder DeclareLocal(Type localType) => this;

        public LocalBuilder DeclareLocal(Type localType, bool pinned) => this;


        private ILEmitter UsingNamespace(string usingNamespace) => this;


        private ILEmitter MarkSequencePoint(ISymbolDocumentWriter document,
            int startLine, // line number is 1 based
            int startColumn, // column is 0 based
            int endLine, // line number is 1 based
            int endColumn) // column is 0 based
            =>
                this;

        private ILEmitter BeginScope() => this;

        private ILEmitter EndScope() => this;

        #endregion
    }
}