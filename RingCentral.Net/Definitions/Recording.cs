namespace RingCentral
{
    /// <summary>
    ///     Recording information
    /// </summary>
    public class Recording
    {
        /// <summary>
        ///     Recording id
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Recording start time
        ///     Format: int64
        /// </summary>
        public long? startTime { get; set; }

        /// <summary>
        ///     Secure Link to the recording file
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// </summary>
        public JsValue metadata { get; set; }

        /// <summary>
        ///     Recording processing status
        ///     Enum: Processing, Processed, Error, Corrupted, InProgress, Purged, Failed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Availability status
        ///     Required
        ///     Enum: Alive, Deleted, Purged, NotAvailable
        /// </summary>
        public string availabilityStatus { get; set; }

        /// <summary>
        ///     During meeting AI team analyze code and after meeting finished generates text summary about this meeting
        /// </summary>
        public string longSummary { get; set; }

        /// <summary>
        ///     During meeting AI team analyze code and after meeting finished generates text summary about this meeting
        /// </summary>
        public string shortSummary { get; set; }

        /// <summary>
        ///     During meeting AI team analyze code and after meeting finished generates key words used in meeting
        /// </summary>
        public string[] keywords { get; set; }
    }
}