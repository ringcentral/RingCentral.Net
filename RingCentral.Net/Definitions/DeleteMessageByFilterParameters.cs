namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation deleteMessageByFilter
    /// </summary>
    public class DeleteMessageByFilterParameters
    {
        /// <summary>
        ///     ID(s) of a conversation to delete
        /// </summary>
        public string[] conversationId { get; set; }

        /// <summary>
        ///     Messages received earlier then the date specified will be deleted.
        ///     The default value is current date/time
        ///     Format: date-time
        /// </summary>
        public string dateTo { get; set; }

        /// <summary>
        ///     Type of messages to be deleted
        ///     Default: All
        ///     Enum: Fax, SMS, VoiceMail, Pager, Text, All
        /// </summary>
        public string type { get; set; }
    }
}