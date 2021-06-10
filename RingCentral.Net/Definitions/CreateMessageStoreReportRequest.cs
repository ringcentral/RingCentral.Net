namespace RingCentral
{
    public class CreateMessageStoreReportRequest
    {
        /// <summary>
        ///     Only messages created before the date will be collected. The default value is current time
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        ///     Only messages created after (or including) the date will be collected. The default value is current time minus 24 hours
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     Enum: EMail, Fax, SMS, VoiceMail, Pager, Text
        /// </summary>
        public string[] messageTypes { get; set; }
    }
}