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
    // Generated wrappers over ILGenerator.
    public sealed partial class ILEmitter
    {
        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginCatchBlock(Type)"/>.
        /// </summary>
        public ILEmitter BeginCatchBlock(in Type exceptionType)
        {
            _il.BeginCatchBlock(exceptionType);
            _logger?.Log(nameof(BeginCatchBlock), exceptionType);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginExceptFilterBlock()"/>.
        /// </summary>
        public ILEmitter BeginExceptFilterBlock()
        {
            _il.BeginExceptFilterBlock();
            _logger?.Log(nameof(BeginExceptFilterBlock));

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginExceptionBlock()"/>.
        /// </summary>
        public ILEmitter BeginExceptionBlock(out Label output)
        {
            output =_il.BeginExceptionBlock();
            _logger?.Log(nameof(BeginExceptionBlock), output);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginFaultBlock()"/>.
        /// </summary>
        public ILEmitter BeginFaultBlock()
        {
            _il.BeginFaultBlock();
            _logger?.Log(nameof(BeginFaultBlock));

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginFinallyBlock()"/>.
        /// </summary>
        public ILEmitter BeginFinallyBlock()
        {
            _il.BeginFinallyBlock();
            _logger?.Log(nameof(BeginFinallyBlock));

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.BeginScope()"/>.
        /// </summary>
        public ILEmitter BeginScope()
        {
            _il.BeginScope();
            _logger?.Log(nameof(BeginScope));

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.DefineLabel()"/>.
        /// </summary>
        public ILEmitter DefineLabel(out Label output)
        {
            output =_il.DefineLabel();
            _logger?.Log(nameof(DefineLabel), output);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EmitCall(OpCode, MethodInfo, Type[])"/>.
        /// </summary>
        public ILEmitter EmitCall(in OpCode opcode, in MethodInfo methodInfo, in Type[] optionalParameterTypes)
        {
            _il.EmitCall(opcode, methodInfo, optionalParameterTypes);
            _logger?.Log(nameof(EmitCall), opcode, methodInfo, optionalParameterTypes);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EmitWriteLine(String)"/>.
        /// </summary>
        public ILEmitter EmitWriteLine(in String value)
        {
            _il.EmitWriteLine(value);
            _logger?.Log(nameof(EmitWriteLine), value);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EmitWriteLine(LocalBuilder)"/>.
        /// </summary>
        public ILEmitter EmitWriteLine(in LocalBuilder localBuilder)
        {
            _il.EmitWriteLine(localBuilder);
            _logger?.Log(nameof(EmitWriteLine), localBuilder);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EmitWriteLine(FieldInfo)"/>.
        /// </summary>
        public ILEmitter EmitWriteLine(in FieldInfo fld)
        {
            _il.EmitWriteLine(fld);
            _logger?.Log(nameof(EmitWriteLine), fld);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EndExceptionBlock()"/>.
        /// </summary>
        public ILEmitter EndExceptionBlock()
        {
            _il.EndExceptionBlock();
            _logger?.Log(nameof(EndExceptionBlock));

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.EndScope()"/>.
        /// </summary>
        public ILEmitter EndScope()
        {
            _il.EndScope();
            _logger?.Log(nameof(EndScope));

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.ThrowException(Type)"/>.
        /// </summary>
        public ILEmitter ThrowException(in Type excType)
        {
            _il.ThrowException(excType);
            _logger?.Log(nameof(ThrowException), excType);

            return this;
        }

        /// <summary>
        ///     Wrapper over <see cref="ILGenerator.UsingNamespace(String)"/>.
        /// </summary>
        public ILEmitter UsingNamespace(in String usingNamespace)
        {
            _il.UsingNamespace(usingNamespace);
            _logger?.Log(nameof(UsingNamespace), usingNamespace);

            return this;
        }
    }
}
