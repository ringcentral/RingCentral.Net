namespace RingCentral
{
    public class CallLogExtractSyncResponse
    {
        /// <summary>
        ///     Link to the list of call log records with sync information
        ///     Required
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
        public CallLogExtractSyncInfo syncInfo { get; set; }
    }
}