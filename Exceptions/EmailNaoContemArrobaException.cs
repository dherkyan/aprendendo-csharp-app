using System;
using System.Runtime.Serialization;

namespace AprendendoCSharpApp.Exceptions
{
    [Serializable]
    public class EmailNaoContemArrobaException : System.Exception
    {
        public EmailNaoContemArrobaException() : base() { }

        public EmailNaoContemArrobaException(string message) : base(message) { }

        public EmailNaoContemArrobaException(string message, Exception exception) : base(message, exception) { }

        protected EmailNaoContemArrobaException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
