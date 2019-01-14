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
    public class Subscription
    {
        public string[] eventFilters;
        public RestClient rc;
        public Action<string> callback;
        public IDisposable subscription;
        public SubscriptionInfo subscriptionInfo;
        public Subscription(RestClient rc, string[] eventFilters, Action<string> callback)
        {
            this.rc = rc;
            this.eventFilters = eventFilters;
            this.callback = callback;
        }

        public async Task<WsgResponse<SubscriptionInfo>> Subscribe()
        {
            var createSubscriptionRequest = new CreateSubscriptionRequest
            {
                eventFilters = this.eventFilters,
                deliveryMode = new NotificationDeliveryModeRequest
                {
                    transportType = "WebSocket"
                }
            };
            var r = await this.rc.Post<SubscriptionInfo>("/restapi/v1.0/subscription", createSubscriptionRequest);
            subscriptionInfo = r.body;
            subscription = this.rc.wsClient.MessageReceived.Subscribe(message =>
            {
                if (message.Contains($"\"subscriptionId\":\"{subscriptionInfo.id}\""))
                {
                    var messages = JArray.Parse(message);
                    callback(messages[1].ToString()); // message[0] is some metadata
                }
            });
            return r;
        }

        public Task<WsgResponse<string>> Revoke()
        {
            return rc.Delete<string>($"/restapi/v1.0/subscription/{subscriptionInfo.id}");
        }
    }
}
