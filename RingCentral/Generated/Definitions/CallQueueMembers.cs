using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallQueueMembers : Serializable
    {
        // Link to a call queue members resource
        public string uri;
        // List of call queue members
        public CallQueueMemberInfo[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}