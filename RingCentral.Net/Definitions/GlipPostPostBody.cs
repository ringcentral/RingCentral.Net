namespace RingCentral
{
    public class GlipPostPostBody
    {
        /// <summary>
        /// Post text.
        /// Required
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Identifier(s) of attachments.
        /// </summary>
        public GlipAttachmentInfoRequest[] attachments { get; set; }
    }
}