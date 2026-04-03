namespace RingCentral
{
    public class SubscriptionInfo
    {
        /// <summary>
        ///     Canonical URI of a subscription resource
        ///     Required
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a subscription
        ///     Required
        ///     Example: 95fecfc9-9cdc-4e94-a78a-89fd65889d37
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     The list of event filter names corresponding to events the user is subscribed to
        ///     Required
        /// </summary>
        public string[] eventFilters { get; set; }

        /// <summary>
        ///     The list of event filter names corresponding to events the user is not subscribed to due to
        ///     certain limitations
        /// </summary>
        public DisabledFilterInfo[] disabledFilters { get; set; }

        /// <summary>
        ///     Subscription expiration time in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601)
        ///     format including timezone, for example *2016-03-10T18:07:52.534Z*
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string expirationTime { get; set; }

        /// <summary>
        ///     Subscription lifetime in seconds
        ///     Minimum: 1
        ///     Format: int32
        /// </summary>
        public long? expiresIn { get; set; }

        /// <summary>
        ///     Subscription status
        ///     Required
        ///     Enum: Active, Blacklisted
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Subscription creation time in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601)
        ///     format including timezone, for example *2016-03-10T18:07:52.534*
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public NotificationDeliveryMode deliveryMode { get; set; }

        /// <summary>
        ///     Returned if a WebHook subscription is blacklisted
        /// </summary>
        public SubscriptionInfoBlacklistedData blacklistedData { get; set; }
    }
}