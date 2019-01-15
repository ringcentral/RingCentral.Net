using System;
using Newtonsoft.Json.Linq;

namespace RingCentral.Net
{
    public class Response
    {
        public string message;
        public Metadata metadata;
        public string body;
        public Response(string message)
        {
            this.message = message;
            var jArray = JArray.Parse(message);
            this.metadata = jArray[0].ToObject<Metadata>();
            if (jArray.Count > 1) // has body
            {
                this.body = jArray[1].ToString();
            }
        }
    }

    public class Response<T>
    {
        public string message;
        public Metadata metadata;
        public T body;
        public static Response<T> Parse(string message)
        {
            var response = new Response<T>();
            response.message = message;
            var jArray = JArray.Parse(message);
            response.metadata = jArray[0].ToObject<Metadata>();
            if (jArray.Count > 1) // has body
            {
                // response.bodyString = jArray[1].ToString();
                try
                {
                    response.body = jArray[1].ToObject<T>();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return response;
        }
    }
}
