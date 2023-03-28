namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listA2PBatches
    /// </summary>
    public class ListA2PBatchesParameters
    {
        /// <summary>
        ///     The end of the time range to filter the results in ISO 8601 format including timezone. Default is the 'dateTo'
        ///     minus 24 hours
        ///     Format: date-time
        ///     Example: 2020-11-09T16:07:52.597Z
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     The end of the time range to filter the results in ISO 8601 format including timezone. Default is the current time
        ///     Format: date-time
        ///     Example: 2020-11-25T16:07:52.597Z
        /// </summary>
        public string dateTo { get; set; }

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