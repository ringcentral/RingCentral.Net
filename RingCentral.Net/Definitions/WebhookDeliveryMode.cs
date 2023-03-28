namespace RingCentral
{
    public class WebhookDeliveryMode
    {
        /// <summary>
        ///     Notifications transport type
        ///     Required
        ///     Enum: WebHook
        /// </summary>
        public string transportType { get; set; }

        /// <summary>
        ///     (Only for a "WebHook" transport, required) URL of a subscriber's web service
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