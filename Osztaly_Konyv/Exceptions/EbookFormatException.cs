using System;
using System.Runtime.Serialization;

namespace Osztaly_Konyv
{
    [Serializable]
    internal class EbookFormatException : Exception
    {
        public EbookFormatException()
        {
        }

        public EbookFormatException(string message) : base(message)
        {
        }

        public EbookFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EbookFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        public override string Message => "i/n értéket lehet megadni";
    }
}