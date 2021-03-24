namespace RingCentral
{
    public class GlipPostInfo
    {
        /// <summary>
        /// Internal identifier of a post
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Internal identifier of a group a post belongs to
        /// </summary>
        public string groupId { get; set; }

        /// <summary>
        /// Type of a post
        /// Enum: TextMessage, PersonJoined, PersonsAdded
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// For 'TextMessage' post type only. Text of a message
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Internal identifier of a user - author of a post
        /// </summary>
        public string creatorId { get; set; }

        /// <summary>
        /// For 'PersonsAdded' post type only. Identifiers of persons added to a group
        /// </summary>
        public string[] addedPersonIds { get; set; }

        /// <summary>
        /// Post creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        /// Post last modification datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        /// List of posted attachments
        /// </summary>
        public GlipMessageAttachmentInfo[] attachments { get; set; }

        /// <summary>
        /// </summary>
        public GlipMentionsInfo[] mentions { get; set; }

        /// <summary>
        /// Label of activity type
        /// </summary>
        public string activity { get; set; }

        /// <summary>
        /// Title of a message. (Can be set for bot's messages only)
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Link to an image used as an icon for this message
        /// </summary>
        public string iconUri { get; set; }

        /// <summary>
        /// Emoji used as an icon for this message
        /// </summary>
        public string iconEmoji { get; set; }
    }
}