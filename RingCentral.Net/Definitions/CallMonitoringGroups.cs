namespace RingCentral
{
    public class CallMonitoringGroups
    {
        /// <summary>
        ///     Link to a call monitoring groups resource
        ///     Required
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of call monitoring group members
        ///     Required
        /// </summary>
        public CallMonitoringGroup[] records { get; set; }

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