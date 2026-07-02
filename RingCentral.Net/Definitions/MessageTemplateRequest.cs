namespace RingCentral
{
    public class MessageTemplateRequest
    {
        /// <summary>
        ///     Internal identifier of a template. Ignored on input
        /// </summary>
        public string id { get; set; }

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
        ///     Specifies if a template is available on a user (Personal) or a company (Company) level
        ///     Enum: Company, Personal
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        /// </summary>
        public Site site { get; set; }
    }
}