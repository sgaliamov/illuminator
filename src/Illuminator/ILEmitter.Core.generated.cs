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
        ///     <para>Wrapper over BeginExceptionBlock.</para>
        /// </summary>
        public ILEmitter BeginExceptionBlock()
        {
            _il.BeginExceptionBlock();

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over EndExceptionBlock.</para>
        /// </summary>
        public ILEmitter EndExceptionBlock()
        {
            _il.EndExceptionBlock();

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over BeginExceptFilterBlock.</para>
        /// </summary>
        public ILEmitter BeginExceptFilterBlock()
        {
            _il.BeginExceptFilterBlock();

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over BeginCatchBlock.</para>
        /// </summary>
        public ILEmitter BeginCatchBlock(Type exceptionType)
        {
            _il.BeginCatchBlock(exceptionType);

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over BeginFaultBlock.</para>
        /// </summary>
        public ILEmitter BeginFaultBlock()
        {
            _il.BeginFaultBlock();

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over BeginFinallyBlock.</para>
        /// </summary>
        public ILEmitter BeginFinallyBlock()
        {
            _il.BeginFinallyBlock();

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over DefineLabel.</para>
        /// </summary>
        public ILEmitter DefineLabel()
        {
            _il.DefineLabel();

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over MarkLabel.</para>
        /// </summary>
        public ILEmitter MarkLabel(Label loc)
        {
            _il.MarkLabel(loc);

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over ThrowException.</para>
        /// </summary>
        public ILEmitter ThrowException(Type excType)
        {
            _il.ThrowException(excType);

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over EmitWriteLine.</para>
        /// </summary>
        public ILEmitter EmitWriteLine(String value)
        {
            _il.EmitWriteLine(value);

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over EmitWriteLine.</para>
        /// </summary>
        public ILEmitter EmitWriteLine(LocalBuilder localBuilder)
        {
            _il.EmitWriteLine(localBuilder);

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over EmitWriteLine.</para>
        /// </summary>
        public ILEmitter EmitWriteLine(FieldInfo fld)
        {
            _il.EmitWriteLine(fld);

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over DeclareLocal.</para>
        /// </summary>
        public ILEmitter DeclareLocal(Type localType)
        {
            _il.DeclareLocal(localType);

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over DeclareLocal.</para>
        /// </summary>
        public ILEmitter DeclareLocal(Type localType, Boolean pinned)
        {
            _il.DeclareLocal(localType, pinned);

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over UsingNamespace.</para>
        /// </summary>
        public ILEmitter UsingNamespace(String usingNamespace)
        {
            _il.UsingNamespace(usingNamespace);

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over BeginScope.</para>
        /// </summary>
        public ILEmitter BeginScope()
        {
            _il.BeginScope();

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over EndScope.</para>
        /// </summary>
        public ILEmitter EndScope()
        {
            _il.EndScope();

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over EmitCalli.</para>
        /// </summary>
        public ILEmitter EmitCalli(OpCode opcode, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type[] optionalParameterTypes)
        {
            _il.EmitCalli(opcode, callingConvention, returnType, parameterTypes, optionalParameterTypes);

            return this;
        }

        /// <summary>
        ///     <para>Wrapper over EmitCalli.</para>
        /// </summary>
        public ILEmitter EmitCalli(OpCode opcode, CallingConvention unmanagedCallConv, Type returnType, Type[] parameterTypes)
        {
            _il.EmitCalli(opcode, unmanagedCallConv, returnType, parameterTypes);

            return this;
        }
    }
}
