namespace RingCentral
{
    /// <summary>
    ///     Notification delivery transport information
    /// </summary>
    public class AnyPublicDeliveryModeRequest
    {
        /// <summary>
        ///     The transport type for this subscription, or the channel by which an app should be notified of an event
        ///     Required
        ///     Enum: WebHook
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
        ///     An optional validation token used to verify the authenticity of the incoming webhook. Applicable only for the
        ///     `WebHook` transport type.
        /// </summary>
        public string verificationToken { get; set; }
    }
}