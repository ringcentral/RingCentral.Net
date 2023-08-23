namespace RingCentral
{
    /// <summary>
    ///     Notification delivery transport information
    /// </summary>
    public class NotificationDeliveryMode
    {
        /// <summary>
        ///     The transport type for this subscription, or the channel by which an app should be notified of an event
        ///     Required
        ///     Enum: WebHook, RC/APNS, RC/GCM, PubNub, WebSocket
        /// </summary>
        public string transportType { get; set; }

        /// <summary>
        ///     PubNub channel name
        ///     Required
        ///     Format: uri
        ///     Example: 54770517599294_6dda849e
        /// </summary>
        public string address { get; set; }

        /// <summary>
        ///     Optional. Specifies if notification messages will be encrypted
        ///     or not. Please note that for some event filters (e.g. presence) encryption is mandatory and
        ///     `false` value provided by caller will be ignored.
        ///     Required
        ///     Enum: false
        /// </summary>
        public bool? encryption { get; set; }

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
        ///     PubNub credential required to subscribe to the channel
        ///     Required
        /// </summary>
        public string subscriberKey { get; set; }

        /// <summary>
        ///     PubNub credential required to subscribe to the channel
        ///     Required
        /// </summary>
        public string secretKey { get; set; }

        /// <summary>
        ///     (Only for a "PubNub" transport, returned only if `encryption` is `true`)
        ///     Encryption algorithm used
        ///     Enum: AES
        /// </summary>
        public string encryptionAlgorithm { get; set; }

        /// <summary>
        ///     (Only for a "PubNub" transport, returned only if `encryption` is `true`)
        ///     Cryptographic key to decrypt PubNub notification messages
        /// </summary>
        public string encryptionKey { get; set; }
    }
}