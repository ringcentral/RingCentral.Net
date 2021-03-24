namespace RingCentral
{
    public class GlipConversationInfo
    {
        /// <summary>
        /// Internal identifier of a conversation
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Type of a conversation
        /// Enum: Direct, Personal, Group
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Conversation creation datetime in ISO 8601 format
        /// Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        /// Conversation last change datetime in ISO 8601 format
        /// Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        /// List of glip members
        /// </summary>
        public CreateGlipMember[] members { get; set; }
    }
}