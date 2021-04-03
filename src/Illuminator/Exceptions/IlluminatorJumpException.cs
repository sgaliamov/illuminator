using System;
using System.Runtime.Serialization;

namespace Illuminator.Exceptions
{
    /// <summary>
    ///     Thrown when invalid jump is detected.
    /// </summary>
    [Serializable]
    public class IlluminatorJumpException : IlluminatorException
    {
        public IlluminatorJumpException() { }
        public IlluminatorJumpException(string message) : base(message) { }
        public IlluminatorJumpException(string message, Exception inner) : base(message, inner) { }
        protected IlluminatorJumpException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
