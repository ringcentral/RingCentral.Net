namespace RingCentral
{
    public class MessageStoreReport
    {
        /// <summary>
        ///     Internal identifier of a message store report task
        ///     Example: 400142200026-400142200026-bd162f24028442489385eb3f44c18354
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a task
        ///     Format: uri
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
        ///     The end of the time range to collect message records in ISO 8601 format including timezone
        ///     Format: date-time
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        ///     The beginning of the time range to collect call log records in ISO 8601 format including timezone
        ///     Format: date-time
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     The time when this task was started
        ///     Format: date-time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     The time when this task was finished
        ///     Format: date-time
        /// </summary>
        public string finishTime { get; set; }

        /// <summary>
        ///     Type of messages to be collected.
        ///     Example: Fax,VoiceMail
        ///     Enum: Fax, SMS, VoiceMail, Pager
        /// </summary>
        public string[] messageTypes { get; set; }
    }
}