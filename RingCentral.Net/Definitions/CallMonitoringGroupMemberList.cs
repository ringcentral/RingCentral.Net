namespace RingCentral
{
    public class CallMonitoringGroupMemberList
    {
        /// <summary>
        ///     Link to a call monitoring group members resource
        ///     Required
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of a call monitoring group members
        ///     Required
        /// </summary>
        public CallMonitoringGroupMemberInfo[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}