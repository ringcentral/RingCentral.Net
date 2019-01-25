using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RingCentral
{
    public partial class RestClient
    {
        public async Task<HttpResponseMessage> Request(HttpMethod httpMethod, string endpoint,
            HttpContent httpContent = null)
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = httpMethod,
                RequestUri = new Uri(server, endpoint),
                Content = httpContent
            };
            return await Request(httpRequestMessage);
        }

        public async Task<T> Request<T>(HttpMethod httpMethod, string endpoint,
            HttpContent httpContent = null)
        {
            var httpResponseMessage = await Request(httpMethod, endpoint, httpContent);
            var content = await httpResponseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        public async Task<HttpResponseMessage> Post(string endpoint, HttpContent httpContent)
        {
            return await Request(HttpMethod.Post, endpoint, httpContent);
        }

        public async Task<T> Post<T>(string endpoint, HttpContent httpContent)
        {
            return await Request<T>(HttpMethod.Post, endpoint, httpContent);
        }


        public async Task<HttpResponseMessage> Put(string endpoint, HttpContent httpContent)
        {
            return await Request(HttpMethod.Put, endpoint, httpContent);
        }

        public async Task<T> Put<T>(string endpoint, HttpContent httpContent)
        {
            return await Request<T>(HttpMethod.Put, endpoint, httpContent);
        }

        public async Task<HttpResponseMessage> Patch(string endpoint, HttpContent httpContent)
        {
            return await Request(new HttpMethod("PATCH"), endpoint, httpContent);
        }

        public async Task<T> Patch<T>(string endpoint, HttpContent httpContent)
        {
            return await Request<T>(new HttpMethod("PATCH"), endpoint, httpContent);
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