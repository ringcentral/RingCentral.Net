namespace RingCentral
{
    public class UserCallLogResponse
    {
        /// <summary>
        /// List of call log records
        /// Required
        /// </summary>
        public UserCallLogRecord[] records { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public CallLogNavigationInfo navigation { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public CallLogPagingInfo paging { get; set; }
    }
}