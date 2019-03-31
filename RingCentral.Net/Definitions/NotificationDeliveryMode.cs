namespace RingCentral
{
    public class NotificationDeliveryMode
    {
        /// <summary>
        /// Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)
        /// Enum: PubNub, APNS, PubNub/APNS/VoIP
        /// </summary>
        public string transportType;

        /// <summary>
        /// Optional parameter. Specifies if the message will be encrypted or not. For APNS transport type the value is always  false
        /// </summary>
        public bool? encryption;

        /// <summary>
        /// PubNub channel name. For APNS transport type - internal identifier of a device  device_token
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
    }
}