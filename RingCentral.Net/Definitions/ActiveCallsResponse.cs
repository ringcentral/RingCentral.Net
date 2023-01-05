namespace RingCentral
{
    public class ActiveCallsResponse
    {
        /// <summary>
        ///     Link to the list of active call records
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
        public CallLogNavigationInfo navigation { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallLogPagingInfo paging { get; set; }
    }
}