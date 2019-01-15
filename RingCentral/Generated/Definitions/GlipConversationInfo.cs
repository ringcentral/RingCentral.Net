using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GlipConversationInfo : Serializable
    {
        // Internal identifier of a conversation
        public string id;
        // Type of a conversation
        public string type;
        // Conversation creation datetime in ISO 8601 format
        public string creationTime;
        // Conversation last change datetime in ISO 8601 format
        public string lastModifiedTime;
    }
}