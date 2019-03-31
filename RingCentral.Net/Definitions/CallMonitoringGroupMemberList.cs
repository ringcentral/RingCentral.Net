namespace RingCentral
{
    public class CallMonitoringGroupMemberList
    {
        /// <summary>
        /// Link to a call monitoring group members resource
        /// Required
        /// </summary>
        public string uri;

        /// <summary>
        /// List of a call monitoring group members
        /// Required
        /// </summary>
        public CallMonitoringGroupMemberInfo[] records;

        /// <summary>
        /// Information on navigation
        /// Required
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// Required
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}