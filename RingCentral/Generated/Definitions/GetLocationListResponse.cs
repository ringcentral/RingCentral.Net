using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GetLocationListResponse : Serializable
    {
        // List of locations
        public LocationInfo[] records;
        // Information on navigation
        public NavigationInfo navigation; // Required
        // Information on paging
        public PagingInfo paging; // Required
    }
}