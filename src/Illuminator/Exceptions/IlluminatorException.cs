using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Illuminator.Exceptions
{
    [Serializable]
    [ExcludeFromCodeCoverage]
    public class IlluminatorException : Exception
    {
        public IlluminatorException() { }
        public IlluminatorException(string message) : base(message) { }
        public IlluminatorException(string message, Exception innerException) : base(message, innerException) { }
        protected IlluminatorException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
