namespace RingCentral
{
    public class MessageStoreReport
    {
        /// <summary>
        ///     Internal identifier of a message store report task
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to a task
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Status of a message store report task
        ///     Enum: Accepted, Pending, InProgress, AttemptFailed, Failed, Completed, Cancelled
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Internal identifier of an account
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Task creation time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Time of the last task modification
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Ending time for collecting messages
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        ///     Starting time for collecting messages
        /// </summary>
        public string dateFrom { get; set; }
    }
}