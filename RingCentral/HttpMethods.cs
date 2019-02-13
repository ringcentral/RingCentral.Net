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
            object content = null)
        {
            HttpContent httpContent = null;
            if (content is HttpContent)
            {
                httpContent = (HttpContent) content;
            }
            else if (content != null)
            {
                httpContent = new StringContent(
                    JsonConvert.SerializeObject(content, Formatting.None, jsonSerializerSettings), Encoding.UTF8,
                    "application/json"
                );
            }

            var uriBuilder = new UriBuilder(server) {Path = endpoint};

            var httpRequestMessage = new HttpRequestMessage
            {
                Method = httpMethod,
                RequestUri = uriBuilder.Uri,
                Content = httpContent
            };
            return await Request(httpRequestMessage);
        }

        public async Task<T> Request<T>(HttpMethod httpMethod, string endpoint,
            object content = null)
        {
            var httpResponseMessage = await Request(httpMethod, endpoint, content);
            if (typeof(T) == typeof(HttpResponseMessage))
            {
                return (T) (object) httpResponseMessage;
            }

            var httpContent = await httpResponseMessage.Content.ReadAsStringAsync();
            if (typeof(T) == typeof(string))
            {
                return (T) (object) httpContent;
            }

            return JsonConvert.DeserializeObject<T>(httpContent);
        }

        public async Task<HttpResponseMessage> Post(string endpoint, object content = null)
        {
            return await Request(HttpMethod.Post, endpoint, content);
        }

        public async Task<T> Post<T>(string endpoint, object content = null)
        {
            return await Request<T>(HttpMethod.Post, endpoint, content);
        }


        public async Task<HttpResponseMessage> Put(string endpoint, object content = null)
        {
            return await Request(HttpMethod.Put, endpoint, content);
        }

        public async Task<T> Put<T>(string endpoint, object content = null)
        {
            return await Request<T>(HttpMethod.Put, endpoint, content);
        }

        public async Task<HttpResponseMessage> Patch(string endpoint, object content = null)
        {
            return await Request(new HttpMethod("PATCH"), endpoint, content);
        }

        public async Task<T> Patch<T>(string endpoint, object content = null)
        {
            return await Request<T>(new HttpMethod("PATCH"), endpoint, content);
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