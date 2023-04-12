using System;
using System.Runtime.Serialization;

namespace Osztaly_Konyv
{
    [Serializable]
    internal class AuthorNameLengthException : Exception
    {
        public AuthorNameLengthException()
        {
        }

        public AuthorNameLengthException(string message) : base(message)
        {
        }

        public AuthorNameLengthException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AuthorNameLengthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public override string Message => "A szerző nevének minimum 6 karakterből kell állni.";
    }
}