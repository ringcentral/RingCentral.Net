namespace RingCentral
{
    public class MessageChanges
    {
        /// <summary>
        ///     Type of messages to be collected
        ///     Example: Fax
        ///     Enum: EMail, Fax, SMS, VoiceMail, Pager, Text
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Number of new messages. Can be omitted if the value is zero
        ///     Format: int32
        /// </summary>
        public long? newCount { get; set; }

        /// <summary>
        ///     Number of updated messages. Can be omitted if the value is zero
        ///     Format: int32
        /// </summary>
        public long? updatedCount { get; set; }
    }
}