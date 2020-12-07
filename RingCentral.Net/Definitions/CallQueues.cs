namespace RingCentral
{
    public class CallQueues
    {
        /// <summary>
        /// Link to a call queues resource
        /// Required
        /// </summary>
        public string uri;

        /// <summary>
        /// List of call queues
        /// Required
        /// </summary>
        public CallQueueInfo[] records;

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