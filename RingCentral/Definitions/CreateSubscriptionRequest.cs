namespace RingCentral
{
    public class CreateSubscriptionRequest
    {
        public string[] eventFilters;
        public NotificationDeliveryModeRequest deliveryMode;
        public int? expiresIn;
    }
}
