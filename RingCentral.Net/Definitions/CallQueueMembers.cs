namespace RingCentral
{
    public class CallQueueMembers
    {
        /// <summary>
        /// Link to a call queue members resource
        /// Required
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// List of call queue members
        /// Required
        /// </summary>
        public CallQueueMemberInfo[] records { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}