namespace RingCentral
{
    public class PubNubDeliveryMode
    {
        /// <summary>
        ///     Notifications transport type
        ///     Required
        ///     Enum: PubNub
        /// </summary>
        public string transportType { get; set; }

        /// <summary>
        ///     Optional. Specifies if notification messages will be encrypted
        ///     or not. Please note that for some event filters (e.g. presence) encryption is mandatory and
        ///     `false` value provided by caller will be ignored.
        ///     Required
        /// </summary>
        public bool? encryption { get; set; }

        /// <summary>
        ///     PubNub channel name
        ///     Required
        ///     Example: 54770517599294_6dda849e
        /// </summary>
        public string address { get; set; }

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