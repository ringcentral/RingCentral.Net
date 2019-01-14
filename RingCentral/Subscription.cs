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
        public RingCentral rc;
        public Action<string> callback;
        public IDisposable subscription;

        private SubscriptionInfo _subscriptionInfo;
        private bool renewScheduled = false;
        public SubscriptionInfo subscriptionInfo
        {
            get
            {
                return _subscriptionInfo;
            }
            set
            {
                _subscriptionInfo = value;
                if (value != null && !renewScheduled)
                {
                    Task.Delay((int)(_subscriptionInfo.expiresIn.Value - 120) * 1000).ContinueWith(async (action) =>
                    { // 2 minutes before expiration
                        renewScheduled = false;
                        await Renew();
                    });
                    renewScheduled = true;
                }
            }
        }

        public Subscription(RingCentral rc, string[] eventFilters, Action<string> callback)
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

        public async Task<WsgResponse<string>> Revoke()
        {
            var r = await rc.Delete<string>($"/restapi/v1.0/subscription/{subscriptionInfo.id}");
            subscriptionInfo = null;
            return r;
        }

        public async Task<WsgResponse<SubscriptionInfo>> Renew()
        {
            var r = await rc.Post<SubscriptionInfo>($"/restapi/v1.0/subscription/{subscriptionInfo.id}/renew");
            subscriptionInfo = r.body;
            return r;
        }
    }
}
