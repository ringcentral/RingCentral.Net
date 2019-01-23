namespace RingCentral
{
    public class CallMonitoringGroupMemberList : Serializable
    {
        // Link to a call monitoring group members resource
        public string uri; // Required
        // List of a call monitoring group members
        public CallMonitoringGroupMemberInfo[] records; // Required
        // Information on navigation
        public NavigationInfo navigation; // Required
        // Information on paging
        public PagingInfo paging; // Required
    }
}