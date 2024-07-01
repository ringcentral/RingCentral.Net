namespace RingCentral
{
    /// <summary>
    ///     Specifies a site that message template is associated with. Supported only if the Sites feature is enabled.
    ///     The default is `main-site` value.
    /// </summary>
    public class Site
    {
        /// <summary>
        ///     Internal identifier of a site
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Custom name of a site
        /// </summary>
        public string name { get; set; }
    }
}