namespace RingCentral
{
    public class MessageChanges
    {
        /// <summary>
        ///     Type of the message
        ///     Enum: Fax, SMS, VoiceMail, Pager
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