namespace RingCentral
{
    public class CallQueuePresenceEvent
    {
        /// <summary>
        /// Universally unique identifier of a notification
        /// </summary>
        public string uuid;

        /// <summary>
        /// Event filter URI
        /// </summary>
        public string @event;

        /// <summary>
        /// Datetime of sending a notification in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z*
        /// </summary>
        public string timestamp;

        /// <summary>
        /// Internal identifier of a subscription
        /// </summary>
        public string subscriptionId;

        /// <summary>
        /// </summary>
        public CallQueuePresenceEventBody body;
    }
}