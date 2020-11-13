using System;
using System.Threading.Tasks;

namespace RingCentral.Net.WebSocket
{
    public class Subscription
    {
        private WebSocketExtension _wse;
        private string[] _eventFilters;
        private Action<string> _callback;

        public SubscriptionInfo subscriptionInfo;

        public Subscription(WebSocketExtension wse, string[] eventFilters, Action<string> callback)
        {
            this._wse = wse;
            this._eventFilters = eventFilters;
            this._callback = callback;
        }

        public async Task SubScribe()
        {
            subscriptionInfo = await _wse.Request<SubscriptionInfo>("POST", "/restapi/v1.0/subscription", new SubscriptionRequestBody
            {
                deliveryMode = new SubscriptionRequestBodyDeliveryMode
                {
                    transportType = "WebSocket"
                },
                eventFilters = _eventFilters,
            });
        }
    }
}