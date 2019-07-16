namespace RingCentral
{
    public class GlipWebhookInfo
    {
        /// <summary>
        /// Internal identifier of a webhook
        /// </summary>
        public string id;

        /// <summary>
        /// Internal identifier of the user who created a webhook
        /// </summary>
        public string creatorId;

        /// <summary>
        /// Internal identifiers of groups where a webhook has been created
        /// </summary>
        public string[] groupIds;

        /// <summary>
        /// Webhook creation time in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Webhook last update time in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        public string lastModifiedTime;

        /// <summary>
        /// Public link to send a webhook payload
        /// </summary>
        public string uri;

        /// <summary>
        /// Current status of a webhook
        /// Enum: Active, Suspended, Deleted
        /// </summary>
        public string status;
    }
}