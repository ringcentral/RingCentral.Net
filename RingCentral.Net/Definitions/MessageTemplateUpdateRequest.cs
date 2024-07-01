namespace RingCentral
{
    public class MessageTemplateUpdateRequest
    {
        /// <summary>
        ///     Name of a template
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public TemplateInfo body { get; set; }

        /// <summary>
        /// </summary>
        public Site site { get; set; }
    }
}