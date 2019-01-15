using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GetTimezoneListResponse : Serializable
    {
        // List of timezones
        public GetTimezoneInfoResponse[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}