using Newtonsoft.Json;

namespace RingCentral
{
    public class GetMessageList : Serializable
    {
        // List of records with message information
        public GetMessageInfoResponse[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}