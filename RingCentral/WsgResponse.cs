using System;
using Newtonsoft.Json.Linq;

namespace RingCentral.Net
{
    public class WsgResponse
    {
        public string message;
        public WsgMetadata metadata;
        public string body;
        public WsgResponse(string message)
        {
            this.message = message;
            var jArray = JArray.Parse(message);
            this.metadata = jArray[0].ToObject<WsgMetadata>();
            if (jArray.Count > 1) // has body
            {
                this.body = jArray[1].ToString();
            }
        }
    }

    public class WsgResponse<T>
    {
        public string message;
        public WsgMetadata metadata;
        public T body;
        public static WsgResponse<T> Parse(string message)
        {
            var wsgResponse = new WsgResponse<T>();
            wsgResponse.message = message;
            var jArray = JArray.Parse(message);
            wsgResponse.metadata = jArray[0].ToObject<WsgMetadata>();
            if (jArray.Count > 1) // has body
            {
                // wsgResponse.bodyString = jArray[1].ToString();
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
