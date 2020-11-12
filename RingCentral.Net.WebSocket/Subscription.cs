using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RingCentral.Net.WebSocket
{
    public class Subscription
    {
        private WebSocketExtension _wse;
        private string[] _eventFilters;
        private Action<string> _callback;
        
        public Subscription(WebSocketExtension wse, string[] eventFilters, Action<string> callback)
        {
            this._wse = wse;
            this._eventFilters = eventFilters;
            this._callback = callback;
        }

        public async Task SubScribe()
        {
            dynamic[] requestBody = {null, null};
            requestBody[0] = new RestRequestHeaders
            {
                type = "ClientRequest",
                messageId = Guid.NewGuid().ToString(),
                method = "POST",
                path =  "/restapi/v1.0/subscription",
            };
            requestBody[1] = new SubscriptionRequestBody
            {
                deliveryMode = new SubscriptionRequestBodyDeliveryMode
                {
                    transportType = "WebSocket"
                },
                eventFilters = _eventFilters,
            };
            await _wse.Send(JsonConvert.SerializeObject(requestBody));
        }
    }
}