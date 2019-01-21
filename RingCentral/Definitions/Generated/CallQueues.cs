using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallQueues : Serializable
    {
        // Link to a call queues resource
        public string uri; // Required
        // List of call queues
        public CallQueueInfo[] records; // Required
        // Information on navigation
        public NavigationInfo navigation; // Required
        // Information on paging
        public PagingInfo paging; // Required
    }
}