namespace RingCentral
{
    public class AccountCallLogResponse
    {
        /// <summary>
        ///     Link to the list of company call log records
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of call log records
        ///     Required
        /// </summary>
        public CompanyCallLogRecord[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallLogNavigationInfo navigation { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallLogPagingInfo paging { get; set; }
    }
}