namespace RingCentral
{
    public class UpdateSubscriptionRequest
    {
        /// <summary>
        ///     The list of event filters corresponding to events the user is subscribed to
        ///     Required
        /// </summary>
        public string[] eventFilters { get; set; }

        /// <summary>
        ///     Subscription lifetime in seconds. For "WebHook" transport type max value might be set up to 315360000
        ///     seconds (10 years). For "RC/APNS" and "RC/GSM" transport types max subscription lifetime is 7776000 seconds (90
        ///     days).
        ///     For "PubNub" transport type the max value is 900 seconds (15 minutes)
        ///     Format: int32
        /// </summary>
        public long? expiresIn { get; set; }
    }
}