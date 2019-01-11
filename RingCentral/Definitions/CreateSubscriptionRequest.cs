namespace RingCentral
{
    public class CreateSubscriptionRequest : Serializable
    {
        public string[] eventFilters;
        public NotificationDeliveryModeRequest deliveryMode;
        public int? expiresIn;
    }
}
