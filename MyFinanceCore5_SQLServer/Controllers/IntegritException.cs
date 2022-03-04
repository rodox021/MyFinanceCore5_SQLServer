using System;
using System.Runtime.Serialization;

namespace MyFinanceCore5_SQLServer.Controllers
{
    [Serializable]
    internal class IntegritException : Exception
    {
        public IntegritException()
        {
        }

        public IntegritException(string message) : base(message)
        {
        }

        public IntegritException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IntegritException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}