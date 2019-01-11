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

        public Task<WsgResponse<TokenInfo>> Authorize(string username, string extension, string password)
        {
            var messageId = Guid.NewGuid().ToString();
            var wsgMetadata = new WsgMetadata
            {
                type = "ClientRequest",
                messageId = messageId,
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
            var wsgRequest = $"[{wsgMetadata.ToJsonString()}, \"{oauthTokenRequest.ToQueryString()}\"]";
            var t = new TaskCompletionSource<WsgResponse<TokenInfo>>();
            IDisposable subscription = null;
            subscription = client.MessageReceived.Subscribe(message =>
            {
                if (message.Contains($"\"messageId\":\"{messageId}\""))
                {
                    subscription.Dispose();
                    var wsgResponse = WsgResponse<TokenInfo>.Parse(message);
                    // var jArray = JArray.Parse(message);
                    // var metadata = jArray[0].ToObject<WsgMetadata>();
                    // var token = jArray[1].ToObject<TokenInfo>();
                    this.token = wsgResponse.body;
                    t.TrySetResult(wsgResponse);
                }
            });
            this.client.Send(wsgRequest);
            return t.Task;
        }

        public Task<string> Subscribe(string[] eventFilters, Action<string> callback)
        {
            var messageId = Guid.NewGuid().ToString();
            var wsgMetadata = new WsgMetadata
            {
                type = "ClientRequest",
                messageId = messageId,
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

            var wsgRequest = $"[{wsgMetadata.ToJsonString()},{createSubscriptionRequest.ToJsonString()}]";
            var t = new TaskCompletionSource<string>();
            IDisposable subscription = null;
            subscription = client.MessageReceived.Subscribe(message =>
            {
                if (message.Contains($"\"messageId\":\"{messageId}\""))
                {
                    subscription.Dispose();
                    t.TrySetResult(message);
                }
            });
            this.client.Send(wsgRequest);
            return t.Task;
        }
    }
}
