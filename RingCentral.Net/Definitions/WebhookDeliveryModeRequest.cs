namespace RingCentral
{
    public class WebhookDeliveryModeRequest
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
        ///     (Only for a "WebHook" transport, optional) Subscription verification token
        /// </summary>
        public string verificationToken { get; set; }
    }
}