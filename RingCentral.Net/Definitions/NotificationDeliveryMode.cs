namespace RingCentral
{
    public class NotificationDeliveryMode
    {
        /// <summary>
        ///     Notifications transport name, e.g. "WebHook"
        ///     Required
        ///     Enum: PubNub, RC/APNS, RC/GCM, WebHook, WebSocket
        /// </summary>
        public string transportType { get; set; }

        /// <summary>
        ///     For a "WebHook" transport - URL of a consumer service (cannot be changed during subscription update)
        ///     Example: https://acme.com/myservice/webhook
        /// </summary>
        public string address { get; set; }

        /// <summary>
        ///     Optional parameter. Specifies if the message will be encrypted
        ///     or not. If request contains any presence event filter the value by default
        ///     is 'true' (even if specified as 'false'). If request contains only message
        ///     event filters the value by default is 'false'
        /// </summary>
        public bool? encryption { get; set; }

        /// <summary>
        ///     Certificate name (for "RC/APNS" and "RC/GCM" transport types only)
        /// </summary>
        public string certificateName { get; set; }

        /// <summary>
        ///     Registration identifier (for "RC/APNS" and "RC/GCM" transport types only)
        /// </summary>
        public string registrationId { get; set; }

        /// <summary>
        ///     Subscription verification token ensuring data security (For "Webhook" transport type only)
        /// </summary>
        public string verificationToken { get; set; }

        /// <summary>
        ///     PubNub subscriber credentials required to subscribe to the channel (for "PubNub" transport type only)
        /// </summary>
        public string subscriberKey { get; set; }

        /// <summary>
        ///     PubNub subscriber credentials required to subscribe to the channel (for "PubNub" transport type only)
        /// </summary>
        public string secretKey { get; set; }

        /// <summary>
        ///     Encryption algorithm "AES" (for "PubNub" transport type only)
        /// </summary>
        public string encryptionAlgorithm { get; set; }

        /// <summary>
        ///     Key for notification message decryption (for "PubNub" transport type only)
        /// </summary>
        public string encryptionKey { get; set; }
    }
}