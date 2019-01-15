using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallMonitoringGroupMemberList : Serializable
    {
        // Link to a call monitoring group members resource
        public string uri;
        // List of a call monitoring group members
        public CallMonitoringGroupMemberInfo[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}