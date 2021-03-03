namespace RingCentral
{
    // Post data. At least one attribute should be provided (text or attachments)
    public class GlipPostPostBody
    {
        /// <summary>
        /// Text of a post. Maximum length is 10000 symbols. Mentions can be added in .md format [![:Type](id)]
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Identifier(s) of attachments. Maximum number of attachments is 25
        /// </summary>
        public GlipAttachmentInfoRequest[] attachments { get; set; }
    }
}