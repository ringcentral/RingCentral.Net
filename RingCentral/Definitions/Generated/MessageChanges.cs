namespace RingCentral
{
    public class MessageChanges : Serializable
    {
        // Message type
        // Enum: Voicemail, SMS, Fax, Pager
        public string type;
        // The number of new messages. Can be omitted if the value is zero
        public long? newCount;
        // The number of updated messages. Can be omitted if the value is zero
        public long? updatedCount;
    }
}