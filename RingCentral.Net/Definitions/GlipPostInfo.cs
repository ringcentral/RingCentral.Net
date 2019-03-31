namespace RingCentral
{
    public class GlipPostInfo
    {
        /// <summary>
        /// Internal identifier of a post
        /// </summary>
        public string id;

        /// <summary>
        /// Internal identifier of a group a post belongs to
        /// </summary>
        public string groupId;

        /// <summary>
        /// Type of a post
        /// Enum: TextMessage, PersonJoined, PersonsAdded
        /// </summary>
        public string type;

        /// <summary>
        /// For 'TextMessage' post type only. Text of a message
        /// </summary>
        public string text;

        /// <summary>
        /// Internal identifier of a user - author of a post
        /// </summary>
        public string creatorId;

        /// <summary>
        /// For 'PersonsAdded' post type only. Identifiers of persons added to a group
        /// </summary>
        public string[] addedPersonIds;

        /// <summary>
        /// Post creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Post last modification datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        public string lastModifiedTime;

        /// <summary>
        /// List of posted attachments
        /// </summary>
        public GlipMessageAttachmentInfo[] attachments;

        /// <summary>
        /// </summary>
        public GlipMentionsInfo[] mentions;

        /// <summary>
        /// Label of activity type
        /// </summary>
        public string activity;

        /// <summary>
        /// Title of a message. (Can be set for bot's messages only)
        /// </summary>
        public string title;

        /// <summary>
        /// Link to an image used as an icon for this message
        /// </summary>
        public string iconUri;

        /// <summary>
        /// Emoji used as an icon for this message
        /// </summary>
        public string iconEmoji;
    }
}