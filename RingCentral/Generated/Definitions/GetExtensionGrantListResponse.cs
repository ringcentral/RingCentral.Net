using Newtonsoft.Json;

namespace RingCentral
{
    public class GetExtensionGrantListResponse : Serializable
    {
        // List of extension grants with details
        public GrantInfo[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}