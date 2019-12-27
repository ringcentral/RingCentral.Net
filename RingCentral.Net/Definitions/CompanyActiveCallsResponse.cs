namespace RingCentral
{
    public class CompanyActiveCallsResponse
    {
        /// <summary>
        /// Link to the list of company active call records
        /// </summary>
        public string uri;

        /// <summary>
        /// List of call log records
        /// Required
        /// </summary>
        public CompanyCallLogRecord[] records;

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