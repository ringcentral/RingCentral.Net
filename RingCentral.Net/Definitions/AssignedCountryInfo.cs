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
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Country code according to the ISO standard, see [ISO 3166](https://www.iso.org/iso-3166-country-codes.html)
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        ///     Official name of a country
        /// </summary>
        public string name { get; set; }
    }
}