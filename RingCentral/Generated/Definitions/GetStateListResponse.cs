using Newtonsoft.Json;

namespace RingCentral
{
    public class GetStateListResponse : Serializable
    {
        // List of states
        public GetStateInfoResponse[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}