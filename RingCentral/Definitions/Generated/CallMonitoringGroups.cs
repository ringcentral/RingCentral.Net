namespace RingCentral
{
    public class CallMonitoringGroups
    {
        // Link to a call monitoring groups resource
        public string uri; // Required

        // List of call monitoring group members
        public CallMonitoringGroupInfo[] records; // Required

        // Information on navigation
        public NavigationInfo navigation; // Required

        // Information on paging
        public PagingInfo paging; // Required
    }
}