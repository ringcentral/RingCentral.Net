namespace RingCentral
{
    /// <summary>
    ///     Delivery mode data
    /// </summary>
    public class NotificationDeliveryMode
    {
        /// <summary>
        ///     Optional parameter. Specifies if the message will be encrypted or not
        /// </summary>
        public bool? encryption { get; set; }

        /// <summary>
        ///     PubNub channel name
        /// </summary>
        public string address { get; set; }

        /// <summary>
        ///     PubNub subscriber credentials required to subscribe to the channel
        /// </summary>
        public string subscriberKey { get; set; }

        /// <summary>
        ///     PubNub subscriber credentials required to subscribe to the channel. Optional (for PubNub transport type only)
        /// </summary>
        public string secretKey { get; set; }

        /// <summary>
        ///     Encryption algorithm 'AES' (for PubNub transport type only)
        /// </summary>
        public string encryptionAlgorithm { get; set; }

        /// <summary>
        ///     Key for notification message decryption (for PubNub transport type only)
        /// </summary>
        public string encryptionKey { get; set; }

        /// <summary>
        ///     Notifications transportation provider name
        ///     Enum: PubNub, WebHook, RC/APNS, RC/GCM
        /// </summary>
        public string transportType { get; set; }

        /// <summary>
        ///     Name of a certificate. Supported for 'RC/APNS' and 'RC/GCM' transport types
        /// </summary>
        public string certificateName { get; set; }

        /// <summary>
        ///     Identifier of a registration. Supported for 'RC/APNS' and 'RC/GCM' transport types
        /// </summary>
        public string registrationId { get; set; }
    }
}