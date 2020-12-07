namespace RingCentral
{
    // Site data. If multi-site feature is turned on for the account, then internal identifier of a site must be specified. To assign the wireless point to the main site (company) set site ID to `main-site` || Site data (internal identifier and custom name of a site) || Site data
    public class AutomaticLocationUpdatesSiteInfo
    {
        /// <summary>
        /// Internal identifier of a site
        /// </summary>
        public string id;

        /// <summary>
        /// Link to a site resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Name of a site
        /// </summary>
        public string name;

        /// <summary>
        /// Site code value. Returned only if specified
        /// </summary>
        public string code;
    }
}