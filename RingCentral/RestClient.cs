using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class RestClient
    {
        public const string SandboxServer = "https://platform.devtest.ringcentral.com";
        public const string ProductionServer = "https://platform.ringcentral.com";

        public string clientId;
        public string clientSecret;
        public Uri server;
        public TokenInfo token;

        private RestClient(string clientId, string clientSecret, Uri server)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.server = server;
        }

        public RestClient(string clientId, string clientSecret, string server)
            : this(clientId, clientSecret, new Uri(server))
        {
        }

        public RestClient(string clientId, string clientSecret, bool production = false)
            : this(clientId, clientSecret, production ? ProductionServer : SandboxServer)
        {
        }

        public async Task<HttpResponseMessage> Authorize(string username, string extension, string password)
        {
            var httpContent = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"grant_type", "password"},
                {"username", username},
                {"extension", extension},
                {"password", password}
            });
            var httpResponseMessage = await Post("/restapi/oauth/token", httpContent, true);
            var json = await httpResponseMessage.Content.ReadAsStringAsync();
            this.token = JsonConvert.DeserializeObject<TokenInfo>(json);
            return httpResponseMessage;
        }

        public async Task<HttpResponseMessage> Post(string endpoint, HttpContent httpContent,
            bool basicAuthorization = false)
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(this.server, endpoint),
                Content = httpContent
            };
            return await Request(httpRequestMessage, basicAuthorization);
        }

        public async Task<HttpResponseMessage> Request(HttpRequestMessage httpRequestMessage,
            bool basicAuthorization = false)
        {
            var httpClient = new HttpClient();
            httpRequestMessage.Headers.Authorization = basicAuthorization
                ? new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(
                        Encoding.UTF8.GetBytes($"{this.clientId}:{this.clientSecret}")))
                : new AuthenticationHeaderValue("Bearer", this.token.access_token);
            return await httpClient.SendAsync(httpRequestMessage);
        }
    }
}