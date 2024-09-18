namespace RingCentral
{
    /// <summary>
    ///     Information on a country assigned to an extension user. Returned for the User extension type only
    /// </summary>
    public class AssignedCountryInfo
    {
        /// <summary>
        ///     Internal identifier of an assigned country
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of an assigned country resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Two-letter country code in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format
        ///     Example: US
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        ///     Official name of a country
        /// </summary>
        public string name { get; set; }
    }
}