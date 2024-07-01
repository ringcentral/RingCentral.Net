namespace RingCentral
{
    public class MessageTemplateResponse
    {
        /// <summary>
        ///     Internal identifier of a template
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Name of a template
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        /// </summary>
        public TemplateInfo body { get; set; }

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