namespace RingCentral
{
    public class CallLogSyncResponse
    {
        /// <summary>
        ///     Link to the list of call log records with sync information
        ///     Required
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of call log records with synchronization information. For `ISync` the total number of returned records is
        ///     limited to 250;
        ///     this includes both new records and the old ones, specified by the recordCount parameter
        ///     Required
        /// </summary>
        public CallLogRecord[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallLogSyncInfo syncInfo { get; set; }
    }
}