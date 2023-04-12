using System;
using System.Runtime.Serialization;

namespace Osztaly_Konyv
{
    [Serializable]
    internal class AccessionNumberLength : Exception
    {
        public AccessionNumberLength()
        {
        }

        public AccessionNumberLength(string message) : base(message)
        {
        }

        public AccessionNumberLength(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AccessionNumberLength(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public override string Message => "A leltári számnak 11 karakterből kell állni!";

    }
}