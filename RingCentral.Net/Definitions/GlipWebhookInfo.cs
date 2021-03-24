namespace RingCentral
{
    public class GlipWebhookInfo
    {
        /// <summary>
        /// Internal identifier of a webhook
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Internal identifier of the user who created a webhook
        /// </summary>
        public string creatorId { get; set; }

        /// <summary>
        /// Internal identifiers of groups where a webhook has been created
        /// </summary>
        public string[] groupIds { get; set; }

        /// <summary>
        /// Webhook creation time in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        /// Webhook last update time in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        /// Public link to send a webhook payload
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Current status of a webhook
        /// Enum: Active, Suspended, Deleted
        /// </summary>
        public string status { get; set; }
    }
}