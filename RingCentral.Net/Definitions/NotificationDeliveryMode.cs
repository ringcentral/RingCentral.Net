namespace RingCentral
{
    // Delivery mode data
    public class NotificationDeliveryMode
    {
        /// <summary>
        /// Optional parameter. Specifies if the message will be encrypted or not
        /// </summary>
        public bool? encryption;

        /// <summary>
        /// PubNub channel name
        /// </summary>
        public string address;

        /// <summary>
        /// PubNub subscriber credentials required to subscribe to the channel
        /// </summary>
        public string subscriberKey;

        /// <summary>
        /// PubNub subscriber credentials required to subscribe to the channel. Optional (for PubNub transport type only)
        /// </summary>
        public string secretKey;

        /// <summary>
        /// Encryption algorithm 'AES' (for PubNub transport type only)
        /// </summary>
        public string encryptionAlgorithm;

        /// <summary>
        /// Key for notification message decryption (for PubNub transport type only)
        /// </summary>
        public string encryptionKey;

        /// <summary>
        /// Notifications transportation provider name
        /// Enum: PubNub, WebHook, RC/APNS, RC/GCM
        /// </summary>
        public string transportType;

        /// <summary>
        /// Name of a certificate. Supported for 'RC/APNS' and 'RC/GCM' transport types
        /// </summary>
        public string certificateName;

        /// <summary>
        /// Identifier of a registration. Supported for 'RC/APNS' and 'RC/GCM' transport types
        /// </summary>
        public string registrationId;
    }
}