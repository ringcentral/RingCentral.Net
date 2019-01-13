using Newtonsoft.Json;

namespace RingCentral
{
    public class GetLocationListResponse : Serializable
    {
        // List of locations
        public LocationInfo[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}