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
        /// Information on navigation
        /// </summary>
        public CallLogNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// </summary>
        public CallLogPagingInfo paging;
    }
}