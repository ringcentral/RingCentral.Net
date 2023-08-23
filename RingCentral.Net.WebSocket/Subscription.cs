using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RingCentral.Net.WebSocket
{
    public class Subscription
    {
        private readonly string[] _eventFilters;
        private readonly EventHandler<WsgMessage> _eventListener;
        private readonly WebSocketExtension _wse;

        public Subscription(WebSocketExtension wse, string[] eventFilters, Action<string> callback)
        {
            _wse = wse;
            _eventFilters = eventFilters;
            _eventListener = (sender, wsgMessage) =>
            {
                if (wsgMessage.meta.type == MessageType.ServerNotification)
                    callback(JsonConvert.SerializeObject(wsgMessage.body));
            };
            _wse.MessageReceived += _eventListener;
        }

        public SubscriptionInfo SubscriptionInfo { get; set; }

        public async Task SubScribe()
        {
            SubscriptionInfo = await _wse.Request<SubscriptionInfo>("POST",
                "/restapi/v1.0/subscription",
                RequestBody());
        }

        public async Task Refresh()
        {
            if (SubscriptionInfo == null) return;

            await _wse.Request<SubscriptionInfo>("PUT",
                $"/restapi/v1.0/subscription/{SubscriptionInfo.id}",
                RequestBody());
        }

        public async Task Revoke()
        {
            if (SubscriptionInfo == null) return;

            await _wse.Request<SubscriptionInfo>("DELETE",
                $"/restapi/v1.0/subscription/{SubscriptionInfo.id}");
            SubscriptionInfo = null;
            _wse.MessageReceived -= _eventListener;
        }

        private SubscriptionRequestBody RequestBody()
        {
            return new SubscriptionRequestBody
            {
                deliveryMode = new SubscriptionRequestBodyDeliveryMode
                {
                    transportType = "WebSocket"
                },
                eventFilters = _eventFilters
            };
        }
    }
}