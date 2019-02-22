namespace RingCentral
{
    public class CallQueues
    {
        // Link to a call queues resource
        public string uri; // Required

        // List of call queues
        public CallQueueInfo[] records; // Required

        // Information on navigation
        public ProvisioningNavigationInfo navigation; // Required

        // Information on paging
        public ProvisioningPagingInfo paging; // Required
    }
}