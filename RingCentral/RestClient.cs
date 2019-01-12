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
        private WebsocketClient client;
        private string clientId;
        private string clientSecret;
        private string wsgUrl;
        public TokenInfo token;

        public RestClient(string clientId, string clientSecret, string wsgUrl)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.wsgUrl = wsgUrl;
            var url = new Uri("wss://ws-api.devtest.ringcentral.com/ws");
            client = new WebsocketClient(url);
            client.ReconnectTimeoutMs = (int)TimeSpan.FromSeconds(30).TotalMilliseconds;
            client.ReconnectionHappened.Subscribe(type => Console.WriteLine($"Reconnection happened, type: {type}"));
            client.Start();
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
            subscription = client.MessageReceived.Subscribe(message =>
            {
                if (message.Contains($"\"messageId\":\"{messageId}\""))
                {
                    subscription.Dispose();
                    var wsgResponse = WsgResponse<T>.Parse(message);
                    t.TrySetResult(wsgResponse);
                }
            });
            this.client.Send(wsgRequest);
            return t.Task;
        }

        public async Task<WsgResponse<TokenInfo>> Authorize(string username, string extension, string password)
        {
            var metadata = new WsgMetadata
            {
                method = "POST",
                path = "/restapi/oauth/token",
            };
            var oauthTokenRequest = new OauthTokenRequest
            {
                grant_type = "password",
                username = username,
                extension = extension,
                password = password
            };
            var r = await this.Request<TokenInfo>(metadata, oauthTokenRequest.ToQueryString(), true);
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
            var metadata = new WsgMetadata
            {
                method = "POST",
                path = "/restapi/v1.0/subscription",
            };
            var createSubscriptionRequest = new CreateSubscriptionRequest
            {
                eventFilters = eventFilters,
                deliveryMode = new NotificationDeliveryModeRequest
                {
                    transportType = "WebSocket"
                }
            };
            var body = createSubscriptionRequest.ToJsonString();
            var r = await this.Request<SubscriptionInfo>(metadata, body);
            return r;
        }

        public async void Dispose()
        {
            await this.Revoke();
        }
    }
}
