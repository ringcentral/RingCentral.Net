namespace RingCentral
{
    public class CallQueueMembers
    {
        /// <summary>
        /// Link to a call queue members resource
        /// Required
        /// </summary>
        public string uri;

        /// <summary>
        /// List of call queue members
        /// Required
        /// </summary>
        public CallQueueMemberInfo[] records;

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