namespace RingCentral
{
    public class NotificationDeliveryMode : Serializable
    {
        // Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)
        // Enum: PubNub, APNS, PubNub/APNS/VoIP
        public string transportType;
        // Optional parameter. Specifies if the message will be encrypted or not. For APNS transport type the value is always  false
        public bool? encryption;
        // PubNub channel name. For APNS transport type - internal identifier of a device  device_token
        public string address;
        // PubNub subscriber credentials required to subscribe to the channel
        public string subscriberKey;
        // PubNub subscriber credentials required to subscribe to the channel. Optional (for PubNub transport type only)
        public string secretKey;
        // Encryption algorithm 'AES' (for PubNub transport type only)
        public string encryptionAlgorithm;
        // Key for notification message decryption (for PubNub transport type only)
        public string encryptionKey;
    }
}