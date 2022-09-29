namespace RingCentral
{
    public class ExtensionPresenceEvent
    {
        /// <summary>
        ///     Universally unique identifier of a notification
        /// </summary>
        public string uuid { get; set; }

        /// <summary>
        ///     Event filter name
        /// </summary>
        public string @event { get; set; }

        /// <summary>
        ///     Timestamp when this notification was sent in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including
        ///     timezone, for example *2016-03-10T18:07:52.534Z*
        ///     Format: date-time
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        ///     Internal identifier of a subscription
        /// </summary>
        public string subscriptionId { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionPresenceEventBody body { get; set; }
    }
}