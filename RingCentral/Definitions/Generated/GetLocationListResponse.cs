namespace RingCentral
{
    public class GetLocationListResponse
    {
        // List of locations
        public LocationInfo[] records;

        // Information on navigation
        public NavigationInfo navigation; // Required

        // Information on paging
        public PagingInfo paging; // Required
    }
}