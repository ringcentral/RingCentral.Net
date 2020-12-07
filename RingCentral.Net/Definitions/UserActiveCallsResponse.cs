namespace RingCentral
{
    public class UserActiveCallsResponse
    {
        /// <summary>
        /// Link to the list of user active call records
        /// </summary>
        public string uri;

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