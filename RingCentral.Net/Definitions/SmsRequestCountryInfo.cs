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
        ///     ISO 3166-1 alpha-2 code of a country
        /// </summary>
        public string isoCode { get; set; }
    }
}