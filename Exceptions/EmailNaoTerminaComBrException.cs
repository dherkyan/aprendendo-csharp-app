using System;
using System.Runtime.Serialization;

namespace AprendendoCSharpApp.Exceptions
{
    [Serializable]
    public class EmailNaoTerminaComBrException : System.Exception
    {
        public EmailNaoTerminaComBrException() : base() { }

        public EmailNaoTerminaComBrException(string message) : base(message) { }

        public EmailNaoTerminaComBrException(string message, Exception exception) : base(message, exception) { }

        protected EmailNaoTerminaComBrException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
