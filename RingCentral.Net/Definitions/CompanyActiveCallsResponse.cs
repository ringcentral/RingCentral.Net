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
        /// Required
        /// </summary>
        public CallLogNavigationInfo navigation;

        /// <summary>
        /// Required
        /// </summary>
        public CallLogPagingInfo paging;
    }
}