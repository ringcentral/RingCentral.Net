using Newtonsoft.Json;

namespace RingCentral
{
    public class CallQueues : Serializable
    {
        // Link to a call queues resource
        public string uri;
        // List of call queues
        public CallQueueInfo[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}