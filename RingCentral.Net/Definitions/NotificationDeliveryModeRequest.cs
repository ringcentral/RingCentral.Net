namespace RingCentral
{
    public class NotificationDeliveryModeRequest
    {
        /// <summary>
        ///     Notifications transport type
        ///     Required
        ///     Enum: WebHook, RC/APNS, RC/GCM, PubNub
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

        /// <summary>
        ///     Certificate name for mobile notification transports
        ///     Required
        /// </summary>
        public string certificateName { get; set; }

        /// <summary>
        ///     Device instance ID for mobile notification transports
        ///     Required
        ///     Example: 38b062ae-85f8-4dcc-8734-04d3f7393d42
        /// </summary>
        public string registrationId { get; set; }

        /// <summary>
        ///     Optional. Specifies if notification messages will be encrypted
        ///     or not. Please note that for some event filters (e.g. presence) encryption is mandatory and
        ///     `false` value provided by caller will be ignored.
        /// </summary>
        public bool? encryption { get; set; }
    }
}