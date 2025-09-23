namespace RingCentral
{
    /// <summary>
    ///     Notification delivery transport information
    /// </summary>
    public class NotificationDeliveryModeRequest
    {
        /// <summary>
        ///     The transport type for this subscription
        ///     Required
        ///     Enum: WebHook, RC/APNS, RC/GCM, PubNub, Internal
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

        /// <summary>
        ///     (Only for an `Internal` transport)
        ///     The name of internal channel (defined in the backend service configuration) to deliver notifications through.
        ///     Required
        ///     Example: my-server-channel
        /// </summary>
        public string configName { get; set; }
    }
}