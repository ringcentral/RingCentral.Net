namespace RingCentral
{
    public class CallLogResponse
    {
        /// <summary>
        ///     Link to the list of company/user call log records
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of call log records
        ///     Required
        /// </summary>
        public CallLogRecord[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}