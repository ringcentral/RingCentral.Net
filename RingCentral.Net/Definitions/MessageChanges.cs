namespace RingCentral
{
    public class MessageChanges
    {
        /// <summary>
        /// Message type
        /// Enum: Voicemail, SMS, Fax, Pager
        /// </summary>
        public string type;

        /// <summary>
        /// The number of new messages. Can be omitted if the value is zero
        /// </summary>
        public long? newCount;

        /// <summary>
        /// The number of updated messages. Can be omitted if the value is zero
        /// </summary>
        public long? updatedCount;
    }
}