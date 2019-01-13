using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipConversationsList : Serializable
    {
        // List of conversations
        public GlipConversationInfo[] records;
        public GlipNavigationInfo navigation;
    }
}