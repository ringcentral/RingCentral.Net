namespace RingCentral
{
    public class CreateWebhookSubscriptionRequest
    {
        /// <summary>
        ///     The list of event filters corresponding to events the user is subscribed to
        ///     Required
        /// </summary>
        public string[] eventFilters { get; set; }

        /// <summary>
        ///     Subscription lifetime in seconds. The maximum subscription lifetime depends upon the specified `transportType`:
        ///     | Transport type      | Maximum permitted lifetime     |
        ///     | ------------------- | ------------------------------ |
        ///     | `WebHook`           | 315360000 seconds (10 years)   |
        ///     | `RC/APNS`, `RC/GSM` | 7776000 seconds (90 days)      |
        ///     | `PubNub`            | 900 seconds (15 minutes)       |
        ///     | `WebSocket`         | n/a (the parameter is ignored) |
        ///     Minimum: 1
        ///     Format: int32
        /// </summary>
        public long? expiresIn { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public WebhookDeliveryModeRequest deliveryMode { get; set; }
    }
}