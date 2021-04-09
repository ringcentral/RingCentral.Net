namespace RingCentral
{
    // SMS and Pager only. Information about a conversation the message belongs to
    public class ConversationInfo
    {
        /// <summary>
        ///     Internal identifier of a conversation
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Deprecated. Link to a conversation resource
        /// </summary>
        public string uri { get; set; }
    }
}