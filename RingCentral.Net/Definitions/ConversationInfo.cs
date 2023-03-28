namespace RingCentral
{
    /// <summary>
    ///     SMS and Pager only. Information about a conversation the message belongs to
    /// </summary>
    public class ConversationInfo
    {
        /// <summary>
        ///     Internal identifier of a conversation
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Deprecated. Link to a conversation resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }
    }
}