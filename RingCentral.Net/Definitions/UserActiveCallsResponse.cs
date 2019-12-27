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