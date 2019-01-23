namespace RingCentral
{
    public class GlipConversationsList : Serializable
    {
        // List of conversations
        public GlipConversationInfo[] records; // Required
        public GlipNavigationInfo navigation;
    }
}