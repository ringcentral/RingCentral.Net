namespace RingCentral
{
    public class AccountCountryInfoRequest
    {
        /// <summary>
        ///     Internal identifier of a country
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Two-letter country code in ISO 3166-1 alpha-2 format
        ///     Required
        /// </summary>
        public string isoCode { get; set; }
    }
}