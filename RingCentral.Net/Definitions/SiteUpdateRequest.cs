namespace RingCentral
{
    public class SiteUpdateRequest
    {
        /// <summary>
        ///     Extension user first name
        ///     Required
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
        ///     Site extension contact email
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
        public OperatorInfo @operator { get; set; }
    }
}