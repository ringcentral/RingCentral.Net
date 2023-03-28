namespace RingCentral
{
    public class RolesBusinessSiteResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Format: email
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public string callerIdName { get; set; }

        /// <summary>
        /// </summary>
        public BasicExtensionInfoResource @operator { get; set; }

        /// <summary>
        /// </summary>
        public RolesRegionalSettingsResource regionalSettings { get; set; }

        /// <summary>
        /// </summary>
        public ContactAddressInfoResource businessAddress { get; set; }
    }
}