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
    public class RestClient
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

        public Task<WsgResponse<T>> Request<T>(WsgMetadata metadata, string body)
        {
            var messageId = Guid.NewGuid().ToString();
            metadata.messageId = messageId;
            if (metadata.type == null)
            {
                metadata.type = "ClientRequest";
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
                headers = new Dictionary<string, string> {
                    { "Content-Type", "application/x-www-form-urlencoded" },
                    {"Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{this.clientId}:{this.clientSecret}"))}"}
                }
            };
            var oauthTokenRequest = new OauthTokenRequest
            {
                grant_type = "password",
                username = username,
                extension = extension,
                password = password
            };
            var body = $"\"{oauthTokenRequest.ToQueryString()}\"";
            var r = await this.Request<TokenInfo>(metadata, body);
            this.token = r.body;
            return r;
        }

        public async Task<WsgResponse<SubscriptionInfo>> Subscribe(string[] eventFilters, Action<string> callback)
        {
            var metadata = new WsgMetadata
            {
                method = "POST",
                path = "/restapi/v1.0/subscription",
                headers = new Dictionary<string, string> {
                    {"Authorization", $"Bearer {this.token.access_token}"}
                }
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
    }
}
