namespace RingCentral
{
    public class GlipConversationInfo
    {
        /// <summary>
        /// Internal identifier of a conversation
        /// </summary>
        public string id;

        /// <summary>
        /// Type of a conversation
        /// Enum: Direct, Personal, Group
        /// </summary>
        public string type;

        /// <summary>
        /// Conversation creation datetime in ISO 8601 format
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Conversation last change datetime in ISO 8601 format
        /// </summary>
        public string lastModifiedTime;

        /// <summary>
        /// </summary>
        public GlipChatMemberInfo[] members;
    }
}