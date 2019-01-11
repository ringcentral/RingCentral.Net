using System;
using System.Collections.Generic;
using System.Text;
using Websocket.Client;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace RingCentral
{
    public class RestClient
    {
        private WebsocketClient client;
        private string clientId;
        private string clientSecret;
        private string wsgUrl;

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

        public Task<string> Authorize(string username, string extension, string password)
        {
            var wsgMetadata = new WsgMetadata
            {
                messageId = "authorize",
                method = "POST",
                path = "/restapi/oauth/token",
                headers = new Dictionary<string, string> {
                    { "Content-Type", "application/x-www-form-urlencoded" },
                    {"Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{this.clientId}:{this.clientSecret}"))}"}
                }
            };
            var wsgBody = $"grant_type=password&username={username}&extension={extension}&password={password}";
            var wsgRequest = $"[{JsonConvert.SerializeObject(wsgMetadata)}, \"{wsgBody}\"]";

            var t = new TaskCompletionSource<string>();
            IDisposable subscription = null;
            subscription = client.MessageReceived.Subscribe(msg =>
            {
                subscription.Dispose();
                t.TrySetResult(msg);
            });
            this.client.Send(wsgRequest);
            return t.Task;
        }
    }
}
