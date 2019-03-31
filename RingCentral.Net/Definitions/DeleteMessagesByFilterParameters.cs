namespace RingCentral
{
    public class DeleteMessagesByFilterParameters
    {
        /// <summary>
        /// </summary>
        public string[] conversationId;

        /// <summary>
        /// Messages received earlier then the date specified will be deleted. The default value is 'Now'
        /// </summary>
        public string dateTo;

        /// <summary>
        /// Type of messages to be deleted
        /// Default: All
        /// Enum: Fax, SMS, VoiceMail, Pager, Text, All
        /// </summary>
        public string type;
    }
}