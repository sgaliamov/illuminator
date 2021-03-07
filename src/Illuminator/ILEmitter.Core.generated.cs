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
        ///     Wrapper over <see cref="ILGenerator.BeginExceptionBlock"/>.
        /// </summary>
        public ILEmitter BeginExceptionBlock(out Label output)
        {
            output =_il.BeginExceptionBlock();

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EndExceptionBlock"/>.
        /// </summary>
        public ILEmitter EndExceptionBlock()
        {
            _il.EndExceptionBlock();

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginExceptFilterBlock"/>.
        /// </summary>
        public ILEmitter BeginExceptFilterBlock()
        {
            _il.BeginExceptFilterBlock();

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginCatchBlock"/>.
        /// </summary>
        public ILEmitter BeginCatchBlock(Type exceptionType)
        {
            _il.BeginCatchBlock(exceptionType);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginFaultBlock"/>.
        /// </summary>
        public ILEmitter BeginFaultBlock()
        {
            _il.BeginFaultBlock();

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginFinallyBlock"/>.
        /// </summary>
        public ILEmitter BeginFinallyBlock()
        {
            _il.BeginFinallyBlock();

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.DefineLabel"/>.
        /// </summary>
        public ILEmitter DefineLabel(out Label output)
        {
            output =_il.DefineLabel();

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.MarkLabel"/>.
        /// </summary>
        public ILEmitter MarkLabel(Label loc)
        {
            _il.MarkLabel(loc);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.ThrowException"/>.
        /// </summary>
        public ILEmitter ThrowException(Type excType)
        {
            _il.ThrowException(excType);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EmitWriteLine"/>.
        /// </summary>
        public ILEmitter EmitWriteLine(String value)
        {
            _il.EmitWriteLine(value);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EmitWriteLine"/>.
        /// </summary>
        public ILEmitter EmitWriteLine(LocalBuilder localBuilder)
        {
            _il.EmitWriteLine(localBuilder);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EmitWriteLine"/>.
        /// </summary>
        public ILEmitter EmitWriteLine(FieldInfo fld)
        {
            _il.EmitWriteLine(fld);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.DeclareLocal"/>.
        /// </summary>
        public ILEmitter DeclareLocal(out LocalBuilder output, Type localType)
        {
            output =_il.DeclareLocal(localType);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.DeclareLocal"/>.
        /// </summary>
        public ILEmitter DeclareLocal(out LocalBuilder output, Type localType, Boolean pinned)
        {
            output =_il.DeclareLocal(localType, pinned);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.UsingNamespace"/>.
        /// </summary>
        public ILEmitter UsingNamespace(String usingNamespace)
        {
            _il.UsingNamespace(usingNamespace);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginScope"/>.
        /// </summary>
        public ILEmitter BeginScope()
        {
            _il.BeginScope();

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EndScope"/>.
        /// </summary>
        public ILEmitter EndScope()
        {
            _il.EndScope();

            return this;
        }
    }
}
