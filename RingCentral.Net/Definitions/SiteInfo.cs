namespace RingCentral
{
    public class SiteInfo
    {
        /// <summary>
        ///     Internal identifier of a site extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to a site resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Extension user first name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Extension number
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Custom name of a caller. Max number of characters is 15 (only alphabetical symbols, numbers and commas are supported)
        /// </summary>
        public string callerIdName { get; set; }

        /// <summary>
        ///     Extension user email
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
        public OperatorInfo @operator { get; set; }

        /// <summary>
        ///     Site code value. Returned only if specified
        /// </summary>
        public string code { get; set; }
    }
}