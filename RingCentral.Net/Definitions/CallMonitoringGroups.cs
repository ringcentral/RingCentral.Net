namespace RingCentral
{
    public class CallMonitoringGroups
    {
        /// <summary>
        /// Link to a call monitoring groups resource
        /// Required
        /// </summary>
        public string uri;

        /// <summary>
        /// List of call monitoring group members
        /// Required
        /// </summary>
        public CallMonitoringGroup[] records;

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