using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GlipGroupList : Serializable
    {
        // List of groups/teams/private chats
        public GlipGroupInfo[] records; // Required
        public GlipNavigationInfo navigation;
    }
}