namespace RingCentral
{
    public class SiteInfo
    {
        /// <summary>
        /// Internal idetifier of a site extension
        /// </summary>
        public string id;

        /// <summary>
        /// Link to a site resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Extension user first name
        /// </summary>
        public string name;

        /// <summary>
        /// Extension number
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// Custom name of a caller. Max number of characters is 15 (only alphabetical symbols, numbers and commas are supported)
        /// </summary>
        public string callerIdName;

        /// <summary>
        /// Exetnsion user email
        /// </summary>
        public string email;

        /// <summary>
        /// Extension user business address. The default is Company settings
        /// </summary>
        public ContactBusinessAddressInfo businessAddress;

        /// <summary>
        /// Information about regional settings. The default is Company settings
        /// </summary>
        public RegionalSettings regionalSettings;

        /// <summary>
        /// Site Fax/SMS recipient (operator) reference. Multi-level IVR should be enabled
        /// </summary>
        public OperatorInfo @operator;

        /// <summary>
        /// Site code value. Returned only if specified
        /// </summary>
        public string code;
    }
}