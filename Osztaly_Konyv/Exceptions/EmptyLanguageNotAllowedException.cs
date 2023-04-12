using System;
using System.Runtime.Serialization;

namespace Osztaly_Konyv
{
    [Serializable]
    internal class EmptyLanguageNotAllowedException : Exception
    {
        public EmptyLanguageNotAllowedException()
        {
        }

        public EmptyLanguageNotAllowedException(string message) : base(message)
        {
        }

        public EmptyLanguageNotAllowedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyLanguageNotAllowedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        public override string Message => "Mindenképp meg kell adnod egy nyelvet!";
    }
}