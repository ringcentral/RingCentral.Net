namespace RingCentral
{
    public class CreateMessageStoreReportRequest
    {
        /// <summary>
        ///     The end of the time range to collect message records in ISO 8601 format including timezone.
        ///     Default is the current time
        ///     Format: date-time
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        ///     The beginning of the time range to collect call log records in ISO 8601 format including timezone.
        ///     Default is the current time minus 24 hours
        ///     Format: date-time
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     Types of messages to be collected. If not specified, all messages without message type filtering will be returned.
        ///     Multiple values are accepted
        ///     Example: Fax,VoiceMail
        ///     Enum: Fax, SMS, VoiceMail, Pager
        /// </summary>
        public string[] messageTypes { get; set; }
    }
}