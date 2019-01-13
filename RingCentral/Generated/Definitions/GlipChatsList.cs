using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipChatsList : Serializable
    {
        // List of chats
        public GlipChatInfo[] records;
        public GlipNavigationInfo navigation;
    }
}