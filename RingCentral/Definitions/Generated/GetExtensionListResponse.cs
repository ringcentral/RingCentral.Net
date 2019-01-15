using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GetExtensionListResponse : Serializable
    {
        // List of extensions with extension information
        public GetExtensionInfoResponse[] records; // Required
        // Information on navigation
        public NavigationInfo navigation; // Required
        // Information on paging
        public PagingInfo paging; // Required
    }
}