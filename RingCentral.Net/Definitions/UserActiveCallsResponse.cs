namespace RingCentral
{
    public class UserActiveCallsResponse
    {
        /// <summary>
        /// Link to the list of user active call records
        /// </summary>
        public string uri { get; set; }

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