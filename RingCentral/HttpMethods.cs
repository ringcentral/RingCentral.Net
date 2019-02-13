using System;
using System.Linq;
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
            object content = null, object queryObj = null)
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
            if (queryObj != null)
            {
                var fields = queryObj.GetType().GetFields()
                    .Where(f => f.GetValue(queryObj) != null)
                    .Select(f =>
                    {
                        var obj = f.GetValue(queryObj);
                        if (obj.GetType().IsArray)
                        {
                            return String.Join("&",
                                (obj as object[]).Select(o => $"{f.Name}={Uri.EscapeUriString(o.ToString())}")
                                .ToArray());
                        }
                        else
                        {
                            return $"{f.Name}={Uri.EscapeUriString(obj.ToString())}";
                        }
                    })
                    .ToArray();
                uriBuilder.Query = string.Join("&", fields);
            }

            var httpRequestMessage = new HttpRequestMessage
            {
                Method = httpMethod,
                RequestUri = uriBuilder.Uri,
                Content = httpContent
            };
            return await Request(httpRequestMessage);
        }

        public async Task<T> Request<T>(HttpMethod httpMethod, string endpoint,
            object content = null, object queryObj = null)
        {
            var httpResponseMessage = await Request(httpMethod, endpoint, content, queryObj);
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

        public async Task<HttpResponseMessage> Post(string endpoint, object content = null, object queryObj = null)
        {
            return await Request(HttpMethod.Post, endpoint, content, queryObj);
        }

        public async Task<T> Post<T>(string endpoint, object content = null, object queryObj = null)
        {
            return await Request<T>(HttpMethod.Post, endpoint, content, queryObj);
        }

        public async Task<HttpResponseMessage> Put(string endpoint, object content = null, object queryObj = null)
        {
            return await Request(HttpMethod.Put, endpoint, content, queryObj);
        }

        public async Task<T> Put<T>(string endpoint, object content = null, object queryObj = null)
        {
            return await Request<T>(HttpMethod.Put, endpoint, content, queryObj);
        }

        public async Task<HttpResponseMessage> Patch(string endpoint, object content = null, object queryObj = null)
        {
            return await Request(new HttpMethod("PATCH"), endpoint, content, queryObj);
        }

        public async Task<T> Patch<T>(string endpoint, object content = null, object queryObj = null)
        {
            return await Request<T>(new HttpMethod("PATCH"), endpoint, content, queryObj);
        }

        public async Task<HttpResponseMessage> Get(string endpoint, object queryObj = null)
        {
            return await Request(HttpMethod.Get, endpoint, null, queryObj);
        }

        public async Task<T> Get<T>(string endpoint, object queryObj = null)
        {
            return await Request<T>(HttpMethod.Get, endpoint, null, queryObj);
        }

        public async Task<HttpResponseMessage> Delete(string endpoint, object queryObj = null)
        {
            return await Request(HttpMethod.Delete, endpoint, null, queryObj);
        }

        public async Task<T> Delete<T>(string endpoint, object queryObj = null)
        {
            return await Request<T>(HttpMethod.Delete, endpoint, null, queryObj);
        }
    }
}