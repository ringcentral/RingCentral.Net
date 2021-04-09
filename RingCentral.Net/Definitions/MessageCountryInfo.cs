namespace RingCentral
{
    public class MessageCountryInfo
    {
        /// <summary>
        ///     Internal identifier of a country
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a country
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Official name of a country
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     ISO code of a country
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        ///     Calling code of a country
        /// </summary>
        public string callingCode { get; set; }
    }
}