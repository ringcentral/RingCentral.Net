using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipGroupList : Serializable
    {
        // List of groups/teams/private chats
        public GlipGroupInfo[] records;
        public GlipNavigationInfo navigation;
    }
}