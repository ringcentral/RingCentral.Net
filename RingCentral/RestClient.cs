using System;
using System.Collections.Generic;
using System.Text;
using Websocket.Client;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RingCentral
{
    public class RestClient : IDisposable
    {
        public const string SANDBOX_HTTPS_SERVER = "https://platform.devtest.ringcentral.com";
        public const string PRODUCTION_HTTPS_SERVER = "https://platform.ringcentral.com";
        public const string SANDBOX_WSS_SERVER = "wss://ws-api.devtest.ringcentral.com/ws";
        public const string PRODUCTION_WSS_SERVER = "wss://ws-api.ringcentral.com/ws";

        public WebsocketClient wsClient;
        public string clientId;
        public string clientSecret;
        public TokenInfo token;

        public RestClient(string clientId, string clientSecret, string wssServer)
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
        public RestClient(string clientId, string clientSecret, bool production = false)
            : this(clientId, clientSecret, production ? PRODUCTION_WSS_SERVER : SANDBOX_WSS_SERVER)
        {
        }

        public Task<WsgResponse<T>> Request<T>(WsgMetadata metadata, string body, bool oauth = false)
        {
            if (oauth)
            {
                metadata.headers = new Dictionary<string, string> {
                    { "Content-Type", "application/x-www-form-urlencoded" },
                    {"Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{this.clientId}:{this.clientSecret}"))}"}
                };
            }
            else
            {
                metadata.headers = new Dictionary<string, string> {
                    {"Authorization", $"Bearer {this.token.access_token}"}
                };
            }
            var messageId = Guid.NewGuid().ToString();
            metadata.messageId = messageId;
            if (metadata.type == null)
            {
                metadata.type = "ClientRequest";
            }
            if (!(body.StartsWith("{") && body.EndsWith("}"))) // x-www-form-urlencoded istead of json
            {
                body = $"\"{body}\"";
            }
            var wsgRequest = $"[{metadata.ToJsonString()}, {body}]";
            var t = new TaskCompletionSource<WsgResponse<T>>();
            IDisposable subscription = null;
            subscription = wsClient.MessageReceived.Subscribe(message =>
            {
                if (message.Contains($"\"messageId\":\"{messageId}\""))
                {
                    subscription.Dispose();
                    var wsgResponse = WsgResponse<T>.Parse(message);
                    t.TrySetResult(wsgResponse);
                }
            });
            this.wsClient.Send(wsgRequest);
            return t.Task;
        }

        public Task<WsgResponse<T>> Post<T>(string path, Serializable body, bool oauth = false)
        {
            var metadata = new WsgMetadata
            {
                method = "POST",
                path = path
            };
            return Request<T>(metadata, oauth ? body.ToQueryString() : body.ToJsonString(), oauth);
        }

        public async Task<WsgResponse<TokenInfo>> Authorize(string username, string extension, string password)
        {
            var oauthTokenRequest = new OauthTokenRequest
            {
                grant_type = "password",
                username = username,
                extension = extension,
                password = password
            };
            var r = await this.Post<TokenInfo>("/restapi/oauth/token", oauthTokenRequest, true);
            this.token = r.body;
            return r;
        }

        public async Task<WsgResponse<string>> Revoke()
        {
            if (this.token == null) // nothing  to revoke
            {
                return null;
            }
            var metadata = new WsgMetadata
            {
                method = "POST",
                path = "/restapi/oauth/revoke",
            };
            var body = $"token={this.token.access_token}";
            var r = await this.Request<string>(metadata, body, true);
            this.token = null;
            return r;
        }

        public async Task<WsgResponse<SubscriptionInfo>> Subscribe(string[] eventFilters, Action<string> callback)
        {
            var createSubscriptionRequest = new CreateSubscriptionRequest
            {
                eventFilters = eventFilters,
                deliveryMode = new NotificationDeliveryModeRequest
                {
                    transportType = "WebSocket"
                }
            };
            var r = await this.Post<SubscriptionInfo>("/restapi/v1.0/subscription", createSubscriptionRequest);
            var subscriptionId = r.body.id;
            wsClient.MessageReceived.Subscribe(message =>
            {
                if (message.Contains($"\"subscriptionId\":\"{subscriptionId}\""))
                {
                    var messages = JArray.Parse(message);
                    callback(messages[1].ToString()); // message[0] is some metadata
                }
            });
            return r;
        }

        public async void Dispose()
        {
            await this.Revoke();
        }
    }
}
