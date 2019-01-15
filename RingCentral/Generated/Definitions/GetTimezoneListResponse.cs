using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GetTimezoneListResponse : Serializable
    {
        // List of timezones
        public GetTimezoneInfoResponse[] records; // Required
        // Information on navigation
        public NavigationInfo navigation; // Required
        // Information on paging
        public PagingInfo paging; // Required
    }
}