namespace RingCentral
{
    public class SubscriptionInfo
    {
        /// <summary>
        ///     Internal identifier of a subscription
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a subscription
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Collection of API resources (message-store/presence/detailed presence) corresponding to events the user is
        ///     subscribed to
        /// </summary>
        public string[] eventFilters { get; set; }

        /// <summary>
        ///     Collection of API resources (message-store/presence/detailed presence) corresponding to events the user is not
        ///     subscribed to due to certain limitations
        /// </summary>
        public DisabledFilterInfo[] disabledFilters { get; set; }

        /// <summary>
        ///     Subscription expiration datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone,
        ///     for example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string expirationTime { get; set; }

        /// <summary>
        ///     Subscription lifetime in seconds
        /// </summary>
        public long? expiresIn { get; set; }

        /// <summary>
        ///     Subscription status
        ///     Enum: Active, Suspended, Blacklisted
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Subscription creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for
        ///     example 2016-03-10T18:07:52.534Z
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public NotificationDeliveryMode deliveryMode { get; set; }

        /// <summary>
        /// </summary>
        public NotificationBlacklistedData blacklistedData { get; set; }

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