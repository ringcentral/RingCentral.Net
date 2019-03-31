namespace RingCentral
{
    public class CallMonitoringGroups
    {
        /* Link to a call monitoring groups resource */
        public string uri; // Required

        /* List of call monitoring group members */
        public CallMonitoringGroup[] records; // Required

        /* Information on navigation */
        public ProvisioningNavigationInfo navigation; // Required

        /* Information on paging */
        public ProvisioningPagingInfo paging; // Required
    }
}