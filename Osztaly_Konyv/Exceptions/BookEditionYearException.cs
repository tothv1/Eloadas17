using System;
using System.Runtime.Serialization;

namespace Osztaly_Konyv
{
    [Serializable]
    internal class BookEditionYearException : Exception
    {
        public BookEditionYearException()
        {
        }

        public BookEditionYearException(string message) : base(message)
        {
        }

        public BookEditionYearException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BookEditionYearException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        public override string Message => "A kiadási év -10000 -- 2023 között kell lenni!";
    }
}