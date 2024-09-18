namespace RingCentral
{
    /// <summary>
    ///     Target number country information. Either `id` or `isoCode` can be specified.
    /// </summary>
    public class SmsRequestCountryInfo
    {
        /// <summary>
        ///     Internal identifier of a country
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Two-letter country code in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format
        ///     Example: US
        /// </summary>
        public string isoCode { get; set; }
    }
}