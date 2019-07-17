using Newtonsoft.Json;

namespace RingCentral
{
    public class JsonDeserializeException : JsonReaderException
    {
        public JsonDeserializeException(string message, JsonReaderException inner) : base(message, inner) {}
    }
}