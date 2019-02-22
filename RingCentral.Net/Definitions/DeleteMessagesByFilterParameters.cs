namespace RingCentral
{
    public class DeleteMessagesByFilterParameters
    {
        public string[] conversationId;

        // Messages received earlier then the date specified will be deleted. The default value is 'Now'
        public string dateTo;

        // Type of messages to be deleted
        // Default: All
        // Enum: Fax, SMS, VoiceMail, Pager, Text, All
        public string type;
    }
}