namespace RingCentral
{
    public class SubscriptionInfo
    {
        // Internal identifier of a subscription
        public string id;

        // Canonical URI of a subscription
        public string uri;

        // Collection of API resources (message-store/presence/detailed presence) corresponding to events the user is subscribed to
        public string[] eventFilters;

        // Collection of API resources (message-store/presence/detailed presence) corresponding to events the user is not subscribed to due to certain limitations
        public DisabledFilterInfo[] disabledFilters;

        // Subscription expiration datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example 2016-03-10T18:07:52.534Z
        public string expirationTime;

        // Subscription lifetime in seconds
        // Default: 900
        public long? expiresIn;

        // Subscription status
        // Enum: Active, Suspended, Blacklisted
        public string status;

        // Subscription creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example 2016-03-10T18:07:52.534Z
        public string creationTime;

        // Delivery mode data
        public NotificationDeliveryMode deliveryMode; // Required

        public NotificationBlacklistedData blacklistedData;
    }
}