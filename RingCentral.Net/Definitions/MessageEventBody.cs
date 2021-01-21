namespace RingCentral
{
    // Notification payload body
    public class MessageEventBody
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        /// Datetime when the message was last modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        public string lastUpdated { get; set; }

        /// <summary>
        /// Message Changes
        /// </summary>
        public MessageChanges[] changes { get; set; }

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        public string ownerId { get; set; }
    }
}