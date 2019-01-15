using System;
using System.Collections.Generic;
using System.Text;
using Websocket.Client;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RingCentral.Net
{
    public class RingCentral : IDisposable
    {
        public const string SANDBOX_HTTPS_SERVER = "https://platform.devtest.ringcentral.com";
        public const string PRODUCTION_HTTPS_SERVER = "https://platform.ringcentral.com";
        public const string SANDBOX_WSS_SERVER = "wss://ws-api.devtest.ringcentral.com/ws";
        public const string PRODUCTION_WSS_SERVER = "wss://ws-api.ringcentral.com/ws";

        public WebsocketClient wsClient;
        public string clientId;
        public string clientSecret;
        public TokenInfo token;

        public RingCentral(string clientId, string clientSecret, string wssServer)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            if (!wssServer.StartsWith("wss://"))
            {
                if (wssServer.StartsWith(SANDBOX_HTTPS_SERVER))
                {
                    wssServer = SANDBOX_WSS_SERVER;
                }
                else if (wssServer.StartsWith(PRODUCTION_HTTPS_SERVER))
                {
                    wssServer = PRODUCTION_WSS_SERVER;
                }
                else
                {
                    throw new ArgumentException("wssServer should start with \"wss://\"", "wssServer");
                }
            }
            wsClient = new WebsocketClient(new Uri(wssServer));
            wsClient.ReconnectTimeoutMs = (int)TimeSpan.FromSeconds(60).TotalMilliseconds;
            wsClient.ReconnectionHappened.Subscribe(type => Console.WriteLine($"WebSocket Reconnection: {type}"));
            wsClient.Start();
        }
        public RingCentral(string clientId, string clientSecret, bool production = false)
            : this(clientId, clientSecret, production ? PRODUCTION_WSS_SERVER : SANDBOX_WSS_SERVER)
        {
        }

        public Task<Response<T>> Request<T>(string method, string path, string body = null, bool basicAuth = false)
        {
            var messageId = Guid.NewGuid().ToString();
            var metadata = new WsgMetadata
            {
                type = "ClientRequest",
                method = method,
                path = path,
                messageId = messageId,
                headers = GetHeaders(basicAuth)
            };
            var requestItems = new List<string>();
            requestItems.Add(metadata.ToJsonString());
            if (body != null)
            {
                requestItems.Add(basicAuth ? $"\"{body}\"" : body);
            }
            var requestBody = $"[{string.Join(",", requestItems)}]";
            var t = new TaskCompletionSource<Response<T>>();
            IDisposable subscription = null;
            subscription = wsClient.MessageReceived.Subscribe(message =>
            {
                if (message.Contains($"\"messageId\":\"{messageId}\""))
                {
                    subscription.Dispose();
                    var response = Response<T>.Parse(message);
                    t.TrySetResult(response);
                }
            });
            this.wsClient.Send(requestBody);
            return t.Task;
        }

        public Task<Response<T>> Post<T>(string path, Serializable body = null)
        {
            return Request<T>("POST", path, body == null ? null : body.ToJsonString());
        }
        public Task<Response<T>> Put<T>(string path, Serializable body = null)
        {
            return Request<T>("PUT", path, body == null ? null : body.ToJsonString());
        }
        public Task<Response<T>> Delete<T>(string path)
        {
            return Request<T>("DELETE", path);
        }
        public Task<Response<T>> Get<T>(string path)
        {
            return Request<T>("GET", path);
        }
        public Task<Response<T>> Patch<T>(string path)
        {
            return Request<T>("PATCH", path);
        }

        public async Task<Response<TokenInfo>> Authorize(string username, string extension, string password)
        {
            var oauthTokenRequest = new OauthTokenRequest
            {
                grant_type = "password",
                username = username,
                extension = extension,
                password = password
            };
            var r = await Request<TokenInfo>("POST", "/restapi/oauth/token", oauthTokenRequest.ToQueryString(), true);
            this.token = r.body;
            return r;
        }
        public async Task<Response<string>> Revoke()
        {
            if (this.token == null) // nothing  to revoke
            {
                return null;
            }
            var body = $"token={this.token.access_token}";
            var r = await this.Request<string>("POST", "/restapi/oauth/revoke", body, true);
            this.token = null;
            return r;
        }
        public async Task<Response<TokenInfo>> Refresh()
        {
            if (this.token == null) // nothing  to refresh
            {
                return null;
            }
            var oauthTokenRequest = new OauthTokenRequest
            {
                grant_type = "refresh_token",
                refresh_token = this.token.refresh_token,
            };
            var r = await this.Request<TokenInfo>("POST", "/restapi/oauth/token", oauthTokenRequest.ToQueryString(), true);
            this.token = r.body;
            return r;
        }

        public async void Dispose()
        {
            await this.Revoke();
        }

        const string userAgent = "tylerlong/RingCentral.Net";
        private Dictionary<string, string> GetHeaders(bool basicAuth = false)
        {
            var dict = new Dictionary<string, string>();
            dict["X-User-Agent"] = userAgent;
            dict["RC-User-Agent"] = userAgent;
            if (basicAuth)
            {
                dict["Content-Type"] = "application/x-www-form-urlencoded";
                dict["Authorization"] = $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{this.clientId}:{this.clientSecret}"))}";
            }
            else
            {
                dict["Authorization"] = $"Bearer {this.token.access_token}";
            }
            return dict;
        }
    }
}
