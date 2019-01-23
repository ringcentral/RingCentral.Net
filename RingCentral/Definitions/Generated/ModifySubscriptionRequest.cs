namespace RingCentral
{
    public class ModifySubscriptionRequest : Serializable
    {
        // Collection of URIs to API resources
        public string[] eventFilters; // Required
        // Notification delivery settings
        public NotificationDeliveryModeRequest deliveryMode;
        // Subscription lifetime in seconds. Max value is 7 days (604800 sec). For *WebHook* transport type max value might be set up to 630720000 seconds (20 years)
        public long? expiresIn;
    }
}