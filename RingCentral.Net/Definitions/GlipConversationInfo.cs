namespace RingCentral
{
    public class GlipConversationInfo
    {
        /* Internal identifier of a conversation */
        public string id;

        /* Type of a conversation */
        // Enum: Direct, Personal, Group
        public string type;

        /* Conversation creation datetime in ISO 8601 format */
        public string creationTime;

        /* Conversation last change datetime in ISO 8601 format */
        public string lastModifiedTime;

        public GlipChatMemberInfo[] members;
    }
}