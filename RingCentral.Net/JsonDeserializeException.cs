using System;
using Newtonsoft.Json;

namespace RingCentral
{
    public class JsonDeserializeException : Exception
    {
        public JsonDeserializeException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}