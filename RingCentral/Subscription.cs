using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RingCentral
{
    public class Subscription
    {
        public RestClient rc;
        public string[] eventFilters;
        public Action<string> callback;

        private bool renewScheduled = false;
        private SubscriptionInfo _subscriptionInfo;

        public SubscriptionInfo subscriptionInfo
        {
            get => _subscriptionInfo;
            set
            {
                _subscriptionInfo = value;
                if (value == null || renewScheduled) return;
                Debug.Assert(_subscriptionInfo.expiresIn != null, "subscriptionInfo.expiresIn != null");
                Task.Delay((int) (_subscriptionInfo.expiresIn.Value - 120) * 1000).ContinueWith(async (action) =>
                {
                    // 2 minutes before expiration
                    renewScheduled = false;
                    await Refresh();
                });
                renewScheduled = true;
            }
        }

        public Subscription(RestClient rc, string[] eventFilters, Action<string> callback)
        {
            this.rc = rc;
            this.eventFilters = eventFilters;
            this.callback = callback;
        }

        public async Task<SubscriptionInfo> Subscribe()
        {
            var requestBody = new
            {
                eventFilters = eventFilters,
                deliveryMode = new {transportType = "PubNub", encryption = true}
            };
            var httpContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8,
                "application/json");
            subscriptionInfo = await rc.Post<SubscriptionInfo>("/restapi/v1.0/subscription", httpContent);
            return subscriptionInfo;
        }

        public async Task<SubscriptionInfo> Refresh()
        {
            subscriptionInfo =
                await rc.Post<SubscriptionInfo>($"/restapi/v1.0/subscription/{subscriptionInfo.id}/renew", null);
            return subscriptionInfo;
        }

        public async Task<HttpResponseMessage> Revoke()
        {
            var r = await rc.Delete($"/restapi/v1.0/subscription/{_subscriptionInfo.id}");
            subscriptionInfo = null;
            return r;
        }
    }
}