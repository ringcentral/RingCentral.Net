namespace RingCentral
{
    /// <summary>
    /// Request body for operation mthSendMessage
    /// </summary>
    public class MthSendMessageRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public NewThreadMessageRequest metadata { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public Attachment[] attachments { get; set; }
    }
}