using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallMonitoringGroups : Serializable
    {
        // Link to a call monitoring groups resource
        public string uri;
        // List of call monitoring group members
        public CallMonitoringGroup[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}