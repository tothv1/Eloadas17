using System;
using System.Runtime.Serialization;

namespace Osztaly_Konyv
{
    [Serializable]
    internal class EncyclopediaRequiredException : Exception
    {
        public EncyclopediaRequiredException()
        {
        }

        public EncyclopediaRequiredException(string message) : base(message)
        {
        }

        public EncyclopediaRequiredException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EncyclopediaRequiredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        public override string Message => "Csak igaz vagy hamis értéket tudsz megadni!";
    }
}