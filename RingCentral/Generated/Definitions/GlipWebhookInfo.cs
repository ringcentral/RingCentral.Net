using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipWebhookInfo : Serializable
    {
        // Internal identifier of a webhook
        public string id;
        // Internal identifier of the user who created a webhook
        public string creatorId;
        // Internal identifiers of groups where a webhook has been created
        public string[] groupsId;
        // Webhook creation time in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string creationTime;
        // Webhook last update time in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string lastModifiedTime;
        // Public link to send a webhook payload
        public string uri;
        // Current status of a webhook
        public string status;
    }
}