using System;

namespace RingCentral.Net.WebSocket
{
    public class WebSocketExtension : SdkExtension
    {
        private RestClient _rc;

        public WebSocketExtension(WebSocketOptions webSocketOptions = null)
        {
            if (webSocketOptions == null)
            {
                webSocketOptions = WebSocketOptions.DefaultInstance;
            }
        }

        public override void Install(RestClient rc)
        {
            this._rc = rc;
        }
    }
}