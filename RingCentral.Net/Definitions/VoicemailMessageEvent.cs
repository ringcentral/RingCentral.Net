namespace RingCentral
{
    public class VoicemailMessageEvent
    {
        /// <summary>
        ///     Universally unique identifier of a notification
        /// </summary>
        public string uuid { get; set; }

        /// <summary>
        ///     Event filter URI
        /// </summary>
        public string @event { get; set; }

        /// <summary>
        ///     Datetime of sending a notification in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone,
        ///     for example *2016-03-10T18:07:52.534Z*
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        ///     Internal identifier of a subscription
        /// </summary>
        public string subscriptionId { get; set; }

        /// <summary>
        ///     Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId { get; set; }

        /// <summary>
        /// </summary>
        public VoicemailMessageEventBody body { get; set; }
    }
}