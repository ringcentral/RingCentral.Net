namespace RingCentral
{
    /// <summary>
    ///     Recording information
    /// </summary>
    public class Recording
    {
        /// <summary>
        ///     recording id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     recording start time
        ///     Format: int64
        /// </summary>
        public long? startTime { get; set; }

        /// <summary>
        ///     recording url
        /// </summary>
        public string contentUri { get; set; }

        /// <summary>
        /// </summary>
        public JsValue metadata { get; set; }

        /// <summary>
        ///     recording status
        ///     Enum: Processing, Processed, Error, Corrupted, InProgress
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     availability status
        ///     Required
        ///     Enum: Alive, Deleted, Purged, NotAvailable
        /// </summary>
        public string availabilityStatus { get; set; }
    }
}