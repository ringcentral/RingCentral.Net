namespace RingCentral
{
    public class SubscriptionInfo
    {
        /// <summary>
        /// Internal identifier of a subscription
        /// </summary>
        public string id;

        /// <summary>
        /// Canonical URI of a subscription
        /// </summary>
        public string uri;

        /// <summary>
        /// Collection of API resources (message-store/presence/detailed presence) corresponding to events the user is subscribed to
        /// </summary>
        public string[] eventFilters;

        /// <summary>
        /// Collection of API resources (message-store/presence/detailed presence) corresponding to events the user is not subscribed to due to certain limitations
        /// </summary>
        public DisabledFilterInfo[] disabledFilters;

        /// <summary>
        /// Subscription expiration datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        public string expirationTime;

        /// <summary>
        /// Subscription lifetime in seconds
        /// Default: 900
        /// </summary>
        public long? expiresIn;

        /// <summary>
        /// Subscription status
        /// Enum: Active, Suspended, Blacklisted
        /// </summary>
        public string status;

        /// <summary>
        /// Subscription creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Delivery mode data
        /// Required
        /// </summary>
        public NotificationDeliveryMode deliveryMode;

        /// <summary>
        /// </summary>
        public NotificationBlacklistedData blacklistedData;
    }
}