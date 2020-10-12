using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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
            object content = null, object queryParams = null, CancellationToken? cancellationToken = null)
        {
            HttpContent httpContent = null;
            if (content is HttpContent)
            {
                httpContent = (HttpContent) content;
            }
            else if (content is string s)
            {
                httpContent = new StringContent(s);
            }
            else if (content != null)
            {
                httpContent = new StringContent(
                    JsonConvert.SerializeObject(content, Formatting.None, jsonSerializerSettings), Encoding.UTF8,
                    "application/json"
                );
            }

            UriBuilder uriBuilder = null;
            if (endpoint.StartsWith("https://"))
            {
                uriBuilder = new UriBuilder(endpoint);
            }
            else
            {
                uriBuilder = new UriBuilder(server) {Path = endpoint};
            }

            if (queryParams != null)
            {
                var fields = Utils.GetPairs(queryParams).Select(t =>
                {
                    if (t.value.GetType().IsArray)
                    {
                        return string.Join("&",
                            (t.value as object[]).Select(o => $"{t.name}={Uri.EscapeUriString(o.ToString())}")
                            .ToArray());
                    }
                    else
                    {
                        return $"{t.name}={Uri.EscapeUriString(t.value.ToString())}";
                    }
                });
                uriBuilder.Query = string.Join("&", fields);
            }

            var httpRequestMessage = new HttpRequestMessage
            {
                Method = httpMethod,
                RequestUri = uriBuilder.Uri,
                Content = httpContent
            };
            return await extensibleRequest(httpRequestMessage, 0, cancellationToken);
        }

        public async Task<T> Request<T>(HttpMethod httpMethod, string endpoint,
            object content = null, object queryParams = null, CancellationToken? cancellationToken = null)
        {
            var httpResponseMessage = await Request(httpMethod, endpoint, content, queryParams, cancellationToken);
            if (typeof(T) == typeof(HttpResponseMessage))
            {
                return (T) (object) httpResponseMessage;
            }

            if (typeof(T) == typeof(byte[]))
            {
                var bytes = await httpResponseMessage.Content.ReadAsByteArrayAsync();
                return (T) (object) bytes;
            }

            var httpContent = await httpResponseMessage.Content.ReadAsStringAsync();
            if (typeof(T) == typeof(string))
            {
                return (T) (object) httpContent;
            }

            try
            {
                return JsonConvert.DeserializeObject<T>(httpContent);
            }
            catch (Exception e)
            {
                if (e is JsonReaderException || e is JsonSerializationException)
                {
                    throw new JsonDeserializeException(
                        $"Unable to deserialize json string to type {typeof(T)}\n\n{e.Message}\n\nJson string: {httpContent}",
                        e);
                }

                throw;
            }
        }

        public async Task<HttpResponseMessage> Post(string endpoint, object content = null, object queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await Request(HttpMethod.Post, endpoint, content, queryParams, cancellationToken);
        }

        public async Task<T> Post<T>(string endpoint, object content = null, object queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await Request<T>(HttpMethod.Post, endpoint, content, queryParams, cancellationToken);
        }

        public async Task<HttpResponseMessage> Put(string endpoint, object content = null, object queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await Request(HttpMethod.Put, endpoint, content, queryParams, cancellationToken);
        }

        public async Task<T> Put<T>(string endpoint, object content = null, object queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await Request<T>(HttpMethod.Put, endpoint, content, queryParams, cancellationToken);
        }

        public async Task<HttpResponseMessage> Patch(string endpoint, object content = null, object queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await Request(new HttpMethod("PATCH"), endpoint, content, queryParams, cancellationToken);
        }

        public async Task<T> Patch<T>(string endpoint, object content = null, object queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await Request<T>(new HttpMethod("PATCH"), endpoint, content, queryParams, cancellationToken);
        }

        public async Task<HttpResponseMessage> Get(string endpoint, object queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await Request(HttpMethod.Get, endpoint, null, queryParams, cancellationToken);
        }

        public async Task<T> Get<T>(string endpoint, object queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await Request<T>(HttpMethod.Get, endpoint, null, queryParams, cancellationToken);
        }

        public async Task<HttpResponseMessage> Delete(string endpoint, object queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await Request(HttpMethod.Delete, endpoint, null, queryParams, cancellationToken);
        }

        public async Task<T> Delete<T>(string endpoint, object queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await Request<T>(HttpMethod.Delete, endpoint, null, queryParams, cancellationToken);
        }
    }
}