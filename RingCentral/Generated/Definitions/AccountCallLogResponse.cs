using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class AccountCallLogResponse : Serializable
    {
        // List of call log records
        public CallLogRecord[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}