namespace RingCentral.Net.WebSocket
{
    public class WebSocketExtension : SdkExtension
    {
        private RestClient _rc;
        private readonly WebSocketOptions _options;

        public WebSocketExtension(WebSocketOptions options = null)
        {
            this._options = options ?? WebSocketOptions.DefaultInstance;
        }

        public override void Install(RestClient rc)
        {
            this._rc = rc;
        }
    }
}