namespace RingCentral
{
    // Site data. If multi-site feature is turned on for the account, then ID of a site must be specified. In order to assign a wireless point to the main site (company) site ID should be set to `main-site`
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