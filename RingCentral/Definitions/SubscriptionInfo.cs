namespace RingCentral
{
    public class SubscriptionInfo : Serializable
    {
        public string id;
        public string uri;
        public string[] eventFilters;
        public DisabledFilterInfo[] disabledFilters;
        public string expirationTime;
        public int? expiresIn;
        public string status;
        public string creationTime;
        public NotificationDeliveryMode deliveryMode;
        public NotificationBlacklistedData blacklistedData;
    }
}
