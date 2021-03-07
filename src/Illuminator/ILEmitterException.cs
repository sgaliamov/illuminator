using System;
using System.Runtime.Serialization;

namespace Illuminator
{
    public sealed class ILEmitterException : Exception
    {
        public ILEmitterException() { }
        public ILEmitterException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public ILEmitterException(string message) : base(message) { }
        public ILEmitterException(string message, Exception innerException) : base(message, innerException) { }
    }
}