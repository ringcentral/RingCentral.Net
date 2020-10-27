using System;

namespace RingCentral
{
    public class JsonDeserializeException : Exception
    {
        public JsonDeserializeException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}