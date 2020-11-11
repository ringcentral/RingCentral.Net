namespace RingCentral.Net.WebSocket
{
    public class WebSocketOptions
    {
        public static readonly WebSocketOptions DefaultInstance = new WebSocketOptions();
        public bool restOverWebSocket = false;
        public bool debugMode = false;
        public bool autoRecover = true;
    }

    public class WsToken
    {
        public string uri;
        public string ws_access_token;
        public int expires_in;
    }

    public class Wsc
    {
        public string token;
        public int sequence;
    }
}