namespace RingCentral
{
    public class CallMonitoringGroupMemberList
    {
        // Link to a call monitoring group members resource
        public string uri; // Required

        // List of a call monitoring group members
        public CallMonitoringGroupMemberInfo[] records; // Required

        // Information on navigation
        public ProvisioningNavigationInfo navigation; // Required

        // Information on paging
        public ProvisioningPagingInfo paging; // Required
    }
}