namespace RingCentral
{
    // Brief information on a phone number country || Extension country information || Home country information
    public class CountryInfo
    {
        /// <summary>
        /// Internal identifier of a home country
        /// </summary>
        public string id;

        /// <summary>
        /// Canonical URI of a home country
        /// </summary>
        public string uri;

        /// <summary>
        /// Official name of a home country
        /// </summary>
        public string name;

        /// <summary>
        /// ISO code of a country
        /// </summary>
        public string isoCode;

        /// <summary>
        /// Calling code of a country
        /// </summary>
        public string callingCode;
    }
}