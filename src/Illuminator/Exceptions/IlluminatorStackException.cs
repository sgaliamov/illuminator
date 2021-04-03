using System;
using System.Runtime.Serialization;

namespace Illuminator.Exceptions
{
    /// <summary>
    ///     Thrown when invalid stack state is detected.
    /// </summary>
    [Serializable]
    public class IlluminatorStackException : IlluminatorException
    {
        public IlluminatorStackException() { }
        public IlluminatorStackException(string message) : base(message) { }
        public IlluminatorStackException(string message, Exception inner) : base(message, inner) { }
        protected IlluminatorStackException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
