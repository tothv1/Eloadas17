using System;
using System.Runtime.Serialization;

namespace Osztaly_Konyv
{
    [Serializable]
    internal class TitleLengthException : Exception
    {
        public TitleLengthException()
        {
        }

        public TitleLengthException(string message) : base(message)
        {
        }

        public TitleLengthException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TitleLengthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        public override string Message => "A mű címének minimum 1 karakterből kell állni!";
    }
}