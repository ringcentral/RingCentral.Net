namespace RingCentral
{
    /// <summary>
    ///     Site data
    /// </summary>
    public class IvrMenuSiteInfo
    {
        /// <summary>
        ///     Internal identifier of a site. If the value is not specified in request, then the `main-site` default value is used
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Site name
        /// </summary>
        public string name { get; set; }
    }
}