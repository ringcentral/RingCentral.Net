namespace RingCentral
{
    public class GetTimezoneListResponse
    {
        // List of timezones
        public GetTimezoneInfoResponse[] records; // Required

        // Information on navigation
        public NavigationInfo navigation; // Required

        // Information on paging
        public PagingInfo paging; // Required
    }
}