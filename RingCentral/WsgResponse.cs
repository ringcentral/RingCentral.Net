using System;
using Newtonsoft.Json.Linq;

namespace RingCentral
{
    public class WsgResponse<T>
    {
        public string rawMessage;
        public WsgMetadata metadata;
        public string bodyString;
        public T body;
        public static WsgResponse<T> Parse(string rawMessage)
        {
            var wsgResponse = new WsgResponse<T>();
            wsgResponse.rawMessage = rawMessage;
            var jArray = JArray.Parse(rawMessage);
            wsgResponse.metadata = jArray[0].ToObject<WsgMetadata>();
            if (jArray.Count > 1) // has body
            {
                wsgResponse.bodyString = jArray[1].ToString();
                try
                {
                    wsgResponse.body = jArray[1].ToObject<T>();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return wsgResponse;
        }
    }
}
