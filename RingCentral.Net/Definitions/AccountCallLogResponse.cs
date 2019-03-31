namespace RingCentral
{
    public class AccountCallLogResponse
    {
        /// <summary>
        /// List of call log records
        /// Required
        /// </summary>
        public CallLogRecord[] records;

        /// <summary>
        /// Information on navigation
        /// Required
        /// </summary>
        public CallLogNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// Required
        /// </summary>
        public CallLogPagingInfo paging;
    }
}