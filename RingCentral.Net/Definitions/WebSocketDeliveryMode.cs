namespace RingCentral
{
    public class WebSocketDeliveryMode
    {
        /// <summary>
        ///     The transport type for this subscription, or the channel by which an app should be notified of an event
        ///     Required
        ///     Enum: WebSocket
        /// </summary>
        public string transportType { get; set; }
    }
}