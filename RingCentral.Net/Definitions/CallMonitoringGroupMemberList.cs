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
        /// Required
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}