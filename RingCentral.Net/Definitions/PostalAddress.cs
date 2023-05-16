namespace RingCentral
{
    /// <summary>
    ///     Postal address/location
    /// </summary>
    public class PostalAddress
    {
        /// <summary>
        ///     Street address
        ///     Required
        ///     Example: 20 Davis Dr
        /// </summary>
        public string street { get; set; }

        /// <summary>
        ///     Street address (2nd line)
        /// </summary>
        public string street2 { get; set; }

        /// <summary>
        ///     City name
        ///     Required
        ///     Example: Belmont
        /// </summary>
        public string city { get; set; }

        /// <summary>
        ///     State or province information in the target country
        ///     Example: CA
        /// </summary>
        public string state { get; set; }

        /// <summary>
        ///     Postal code in the target country
        ///     Required
        ///     Example: 94002
        /// </summary>
        public string zip { get; set; }

        /// <summary>
        ///     ISO-3166-1 2-letter country code (alpha2)
        ///     Required
        ///     Example: US
        /// </summary>
        public string country { get; set; }
    }
}