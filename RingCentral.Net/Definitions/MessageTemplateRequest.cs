namespace RingCentral
{
    public class MessageTemplateRequest
    {
        /// <summary>
        ///     Name of a template
        ///     Required
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public MessageTemplateInfo body { get; set; }

        /// <summary>
        /// </summary>
        public Site site { get; set; }
    }
}