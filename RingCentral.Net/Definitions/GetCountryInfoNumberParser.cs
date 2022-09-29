namespace RingCentral
{
    public class GetCountryInfoNumberParser
    {
        /// <summary>
        ///     Internal identifier of a country
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a country resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Country calling code defined by ITU-T recommendations `E.123`
        ///     and `E.164`, see Calling Codes
        ///     Example: 1
        /// </summary>
        public string callingCode { get; set; }

        /// <summary>
        ///     Country code in `ISO 3166` alpha-2 format
        ///     Example: US
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        ///     The official name of the country.
        ///     Example: United States
        /// </summary>
        public string name { get; set; }
    }
}