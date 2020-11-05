namespace RingCentral.Net.WebSocket
{
    public class WebSocketOptions
    {
        public static readonly WebSocketOptions DefaultInstance = new WebSocketOptions();
        public bool restOverWebSocket = false;
        public bool debugMode = false;
        public bool autoRecover = true;
    }
}