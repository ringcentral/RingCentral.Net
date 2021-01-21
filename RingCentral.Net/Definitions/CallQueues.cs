namespace RingCentral
{
    public class CallQueues
    {
        /// <summary>
        /// Link to a call queues resource
        /// Required
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// List of call queues
        /// Required
        /// </summary>
        public CallQueueInfo[] records { get; set; }

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