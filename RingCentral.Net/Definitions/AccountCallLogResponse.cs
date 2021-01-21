namespace RingCentral
{
    public class AccountCallLogResponse
    {
        /// <summary>
        /// Link to the list of company call log records
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// List of call log records
        /// </summary>
        public CompanyCallLogRecord[] records { get; set; }

        /// <summary>
        /// </summary>
        public CallLogNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public CallLogPagingInfo paging { get; set; }
    }
}