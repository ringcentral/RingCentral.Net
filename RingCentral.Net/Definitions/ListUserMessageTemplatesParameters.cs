namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listUserMessageTemplates
    /// </summary>
    public class ListUserMessageTemplatesParameters
    {
        /// <summary>
        ///     Site ID(s) to filter user message templates, associated with particular sites.
        ///     By default the value is all - templates with all sites will be returned
        /// </summary>
        public string[] siteIds { get; set; }

        /// <summary>
        ///     Specifies if a template is available on a user (Personal) or a company (Company) level
        ///     Enum: Company, Personal
        /// </summary>
        public string scope { get; set; }
    }
}