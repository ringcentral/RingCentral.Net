namespace RingCentral
{
    // SMS and Pager only. Identifier of a conversation the message belongs to || Information about a conversation the message belongs to
    public class ConversationInfo
    {
        /// <summary>
        /// Internal identifier of a conversation
        /// </summary>
        public string id;

        /// <summary>
        /// Deprecated. Link to a conversation resource
        /// </summary>
        public string uri;
    }
}