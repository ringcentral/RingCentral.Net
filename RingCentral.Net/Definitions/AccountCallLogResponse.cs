namespace RingCentral
{
    public class AccountCallLogResponse
    {
        /* List of call log records */
        public CallLogRecord[] records; // Required

        /* Information on navigation */
        public CallLogNavigationInfo navigation; // Required

        /* Information on paging */
        public CallLogPagingInfo paging; // Required
    }
}