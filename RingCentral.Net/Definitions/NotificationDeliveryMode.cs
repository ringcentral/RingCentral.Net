namespace RingCentral
{
    /// <summary>
    ///     Notification delivery transport information
    /// </summary>
    public class NotificationDeliveryMode
    {
        /// <summary>
        ///     The transport type for this subscription
        ///     Required
        ///     Enum: WebHook, WebSocket
        /// </summary>
        public string transportType { get; set; }

        /// <summary>
        ///     The URL to which notifications should be delivered. This is only applicable for the `WebHook` transport type, for
        ///     which it is a required field.
        ///     Required
        ///     Format: uri
        ///     Example: https://acme.com/myservice/webhook
        /// </summary>
        public string address { get; set; }

        /// <summary>
        ///     Specifies if notification messages will be encrypted or not.
        ///     Required
        ///     Enum: false
        /// </summary>
        public bool? encryption { get; set; }
    }
}