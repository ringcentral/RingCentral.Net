using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallMonitoringGroups : Serializable
    {
        // Link to a call monitoring groups resource
        public string uri; // Required
        // List of call monitoring group members
        public CallMonitoringGroup[] records; // Required
        // Information on navigation
        public NavigationInfo navigation; // Required
        // Information on paging
        public PagingInfo paging; // Required
    }
}