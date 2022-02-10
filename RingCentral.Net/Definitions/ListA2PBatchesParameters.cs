namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listA2PBatches
    /// </summary>
    public class ListA2PBatchesParameters
    {
        /// <summary>
        ///     The default is 24 hours before `dateTo`
        ///     Format: date-time
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     The default is current time
        ///     Format: date-time
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        ///     Current status of a message batch
        ///     Enum: Processing, Sent, Completed
        /// </summary>
        public string[] status { get; set; }

        /// <summary>
        ///     Phone number in E.164 format from which the messages are going to be sent
        /// </summary>
        public string from { get; set; }

        /// <summary>
        ///     Token of the page to be retrieved
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     Number of records to be returned for the page
        /// </summary>
        public string perPage { get; set; }
    }
}