namespace RingCentral
{
    public class AccountCallLogResponse
    {
        /// <summary>
        /// Link to the list of company call log records
        /// </summary>
        public string uri;

        /// <summary>
        /// List of call log records
        /// </summary>
        public CompanyCallLogRecord[] records;

        /// <summary>
        /// </summary>
        public CallLogNavigationInfo navigation;

        /// <summary>
        /// </summary>
        public CallLogPagingInfo paging;
    }
}