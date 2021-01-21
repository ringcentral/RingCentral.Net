namespace RingCentral
{
    public class CompanyActiveCallsResponse
    {
        /// <summary>
        /// Link to the list of company active call records
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// List of call log records
        /// Required
        /// </summary>
        public CompanyCallLogRecord[] records { get; set; }

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