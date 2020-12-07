namespace RingCentral
{
    public class UserCallLogResponse
    {
        /// <summary>
        /// List of call log records
        /// Required
        /// </summary>
        public UserCallLogRecord[] records;

        /// <summary>
        /// Required
        /// </summary>
        public CallLogNavigationInfo navigation;

        /// <summary>
        /// Required
        /// </summary>
        public CallLogPagingInfo paging;
    }
}