using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipPostInfo : Serializable
    {
        // Internal identifier of a post
        public string id;
        // Internal identifier of a group a post belongs to
        public string groupId;
        // Type of a post
        // Enum: TextMessage, PersonJoined, PersonsAdded
        public string type;
        // For 'TextMessage' post type only. Text of a message
        public string text;
        // Internal identifier of a user - author of a post
        public string creatorId;
        // For 'PersonsAdded' post type only. Identifiers of persons added to a group
        public string[] addedPersonIds;
        // Post creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string creationTime;
        // Post last modification datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string lastModifiedTime;
        // List of posted attachments
        public GlipMessageAttachmentInfo[] attachments;
        public GlipMentionsInfo[] mentions;
        // Label of activity type
        public string activity;
        // Title of a message. (Can be set for bot's messages only)
        public string title;
        // Link to an image used as an icon for this message
        public string iconUri;
        // Emoji used as an icon for this message
        public string iconEmoji;
    }
}