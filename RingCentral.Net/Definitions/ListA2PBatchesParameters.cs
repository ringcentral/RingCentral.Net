namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listA2PBatches
    /// </summary>
    public class ListA2PBatchesParameters
    {
        /// <summary>
        ///     Phone number in E.164 format from which the messages are going to be sent
        ///     Example: 15551234455
        /// </summary>
        public string from { get; set; }

        /// <summary>
        ///     A list of batch statuses to filter the results
        ///     Example: Queued,Processing
        ///     Enum: Queued, Processing, Sent, Completed
        /// </summary>
        public string[] status { get; set; }

        /// <summary>
        ///     The page token of the page to be retrieved
        ///     Example: pgt1
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     The number of records to be returned per page
        ///     Format: int64
        ///     Example: 1
        /// </summary>
        public long? perPage { get; set; }
    }
}