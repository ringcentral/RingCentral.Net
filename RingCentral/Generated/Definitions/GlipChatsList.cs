using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GlipChatsList : Serializable
    {
        // List of chats
        public GlipChatInfo[] records; // Required
        public GlipNavigationInfo navigation;
    }
}