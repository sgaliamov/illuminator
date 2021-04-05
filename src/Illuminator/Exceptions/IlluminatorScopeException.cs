using System;
using System.Runtime.Serialization;

namespace Illuminator.Exceptions
{
    /// <summary>
    ///     Thrown when invalid locals scopes is detected.
    /// </summary>
    [Serializable]
    public class IlluminatorScopeException : IlluminatorException
    {
        public IlluminatorScopeException() { }
        public IlluminatorScopeException(string message) : base(message) { }
        public IlluminatorScopeException(string message, Exception inner) : base(message, inner) { }
        protected IlluminatorScopeException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
