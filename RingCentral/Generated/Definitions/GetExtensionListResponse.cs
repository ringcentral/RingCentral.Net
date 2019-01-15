using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GetExtensionListResponse : Serializable
    {
        // List of extensions with extension information
        public GetExtensionInfoResponse[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}