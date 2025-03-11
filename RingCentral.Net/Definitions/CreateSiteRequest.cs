namespace RingCentral
{
    public class CreateSiteRequest
    {
        /// <summary>
        ///     Internal identifier of a site extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Extension user first name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Extension number
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Custom name of a caller. Max number of characters is 15 (only
        ///     alphabetical symbols, numbers and commas are supported)
        /// </summary>
        public string callerIdName { get; set; }

        /// <summary>
        ///     Extension user email
        ///     Format: email
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// </summary>
        public ContactBusinessAddressInfo businessAddress { get; set; }

        /// <summary>
        /// </summary>
        public RegionalSettings regionalSettings { get; set; }

        /// <summary>
        /// </summary>
        public SiteOperatorReference @operator { get; set; }

        /// <summary>
        ///     Site access status for cross-site limitation
        ///     Enum: Limited, Unlimited
        /// </summary>
        public string siteAccess { get; set; }

        /// <summary>
        /// </summary>
        public string[] accessibleSiteIds { get; set; }

        /// <summary>
        ///     Site code value
        /// </summary>
        public string code { get; set; }
    }
}