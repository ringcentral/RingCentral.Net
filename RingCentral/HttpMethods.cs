using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RingCentral
{
    public partial class RestClient
    {
        public static readonly JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        public async Task<HttpResponseMessage> Request(HttpMethod httpMethod, string endpoint,
            object obj = null)
        {
            HttpContent httpContent = null;
            if (obj is HttpContent)
            {
                httpContent = (HttpContent) obj;
            }
            else if (obj != null)
            {
                httpContent = new StringContent(
                    JsonConvert.SerializeObject(obj, Formatting.None, jsonSerializerSettings), Encoding.UTF8,
                    "application/json"
                );
            }

            var httpRequestMessage = new HttpRequestMessage
            {
                Method = httpMethod,
                RequestUri = new Uri(server, endpoint),
                Content = httpContent
            };
            return await Request(httpRequestMessage);
        }

        public async Task<T> Request<T>(HttpMethod httpMethod, string endpoint,
            object obj = null)
        {
            var httpResponseMessage = await Request(httpMethod, endpoint, obj);
            if (typeof(T) == typeof(HttpResponseMessage))
            {
                return (T) (object) httpResponseMessage;
            }

            var content = await httpResponseMessage.Content.ReadAsStringAsync();
            if (typeof(T) == typeof(string))
            {
                return (T) (object) content;
            }

            return JsonConvert.DeserializeObject<T>(content);
        }

        public async Task<HttpResponseMessage> Post(string endpoint, object obj = null)
        {
            return await Request(HttpMethod.Post, endpoint, obj);
        }

        public async Task<T> Post<T>(string endpoint, object obj = null)
        {
            return await Request<T>(HttpMethod.Post, endpoint, obj);
        }


        public async Task<HttpResponseMessage> Put(string endpoint, object obj = null)
        {
            return await Request(HttpMethod.Put, endpoint, obj);
        }

        public async Task<T> Put<T>(string endpoint, object obj = null)
        {
            return await Request<T>(HttpMethod.Put, endpoint, obj);
        }

        public async Task<HttpResponseMessage> Patch(string endpoint, object obj = null)
        {
            return await Request(new HttpMethod("PATCH"), endpoint, obj);
        }

        public async Task<T> Patch<T>(string endpoint, object obj = null)
        {
            return await Request<T>(new HttpMethod("PATCH"), endpoint, obj);
        }

        public async Task<HttpResponseMessage> Get(string endpoint)
        {
            return await Request(HttpMethod.Get, endpoint);
        }

        public async Task<T> Get<T>(string endpoint)
        {
            return await Request<T>(HttpMethod.Get, endpoint);
        }

        public async Task<HttpResponseMessage> Delete(string endpoint)
        {
            return await Request(HttpMethod.Delete, endpoint);
        }

        public async Task<T> Delete<T>(string endpoint)
        {
            return await Request<T>(HttpMethod.Delete, endpoint);
        }
    }
}