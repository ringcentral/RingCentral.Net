using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ConversationInfo : Serializable
    {
        // Internal identifier of a conversation
        public string id;
        // Deprecated. Link to a conversation resource
        public string uri;
    }
}