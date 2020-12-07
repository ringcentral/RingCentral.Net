namespace RingCentral
{
    // Apple notification data
    public class GlipAPNSInfo
    {
        /// <summary>
        /// </summary>
        public APSInfo aps;

        /// <summary>
        /// Datetime of a call action in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        public string timestamp;

        /// <summary>
        /// Universally unique identifier of a notification
        /// </summary>
        public string uuid;

        /// <summary>
        /// Event filter URI
        /// </summary>
        public string @event;

        /// <summary>
        /// Internal identifier of a subscription
        /// </summary>
        public string subscriptionId;

        /// <summary>
        /// </summary>
        public GlipUnreadMessageCountInfo body;
    }
}