using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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
        public Response<T> ConvertTo<T>()
        {
            var response = new Response<T>
            {
                message = this.message,
                metadata = this.metadata
            };
            if (this.body != null)
            {
                response.body = JsonConvert.DeserializeObject<T>(this.body);
            }
            return response;
        }
    }

    public class Response<T>
    {
        public string message;
        public Metadata metadata;
        public T body;
    }
}
