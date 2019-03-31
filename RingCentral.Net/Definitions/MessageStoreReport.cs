namespace RingCentral
{
    public class MessageStoreReport
    {
        /// <summary>
        /// Internal identifier of a message store report task
        /// </summary>
        public string id;

        /// <summary>
        /// Link to a task
        /// </summary>
        public string uri;

        /// <summary>
        /// Status of a message store report task
        /// Enum: Accepted, Pending, InProgress, AttemptFailed, Failed, Completed, Cancelled
        /// </summary>
        public string status;

        /// <summary>
        /// Internal identifier of an account
        /// </summary>
        public string accountId;

        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string extensionId;

        /// <summary>
        /// Task creation time
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Time of the last task modification
        /// </summary>
        public string lastModifiedTime;

        /// <summary>
        /// Ending time for collecting messages
        /// </summary>
        public string dateTo;

        /// <summary>
        /// Starting time for collecting messages
        /// </summary>
        public string dateFrom;
    }
}