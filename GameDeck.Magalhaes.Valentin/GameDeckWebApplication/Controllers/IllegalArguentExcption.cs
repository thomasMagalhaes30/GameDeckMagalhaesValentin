using System;
using System.Runtime.Serialization;

namespace GameDeckWebApplication.Controllers
{
    [Serializable]
    internal class IllegalArguentExcption : Exception
    {
        public IllegalArguentExcption()
        {
        }

        public IllegalArguentExcption(string message) : base(message)
        {
        }

        public IllegalArguentExcption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IllegalArguentExcption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}