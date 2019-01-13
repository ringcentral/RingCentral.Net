using Newtonsoft.Json;

namespace RingCentral
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