using System;
using System.Runtime.Serialization;

namespace AprendendoCSharpApp.Exceptions
{
    [Serializable]
    public class EmailException : System.Exception
    {
        // Construtor padrao
        public EmailException() : base() { }

        // Construtor para mensagem
        public EmailException(string message) : base(message) { }

        // Construtor para mensagem e exception
        public EmailException(string message, Exception exception) : base(message, exception) { }

        // Construtor para serializacao
        protected EmailException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
