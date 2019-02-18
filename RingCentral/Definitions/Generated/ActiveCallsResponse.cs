namespace RingCentral
{
    public class ActiveCallsResponse
    {
        // List of call log records
        public CallLogRecord[] records; // Required

        // Information on navigation
        public CallLogNavigationInfo navigation; // Required

        // Information on paging
        public CallLogPagingInfo paging; // Required
    }
}