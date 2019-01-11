using Newtonsoft.Json.Linq;

namespace RingCentral
{
    public class WsgResponse<T>
    {
        public string rawMessage;
        public WsgMetadata metadata;
        public T body;

        public static WsgResponse<T> Parse(string rawMessage)
        {
            var wsgResponse = new WsgResponse<T>();
            wsgResponse.rawMessage = rawMessage;
            var jArray = JArray.Parse(rawMessage);
            wsgResponse.metadata = jArray[0].ToObject<WsgMetadata>();
            wsgResponse.body = jArray[1].ToObject<T>();
            return wsgResponse;
        }
    }
}
