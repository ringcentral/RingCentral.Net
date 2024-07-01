namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listCompanyMessageTemplates
    /// </summary>
    public class ListCompanyMessageTemplatesParameters
    {
        /// <summary>
        ///     Site ID(s) to filter company message templates, associated with particular sites
        ///     By default the value is all - templates with all sites will be returned
        /// </summary>
        public string[] siteIds { get; set; }
    }
}