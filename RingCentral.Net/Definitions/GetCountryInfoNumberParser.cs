namespace RingCentral
{
    public class GetCountryInfoNumberParser
    {
        /// <summary>
        /// Internal identifier of a country
        /// </summary>
        public string id;

        /// <summary>
        /// Canonical URI of a country
        /// </summary>
        public string uri;

        /// <summary>
        /// Country calling code defined by ITU-T recommendations E.123 and E.164, see Calling Codes
        /// </summary>
        public string callingCode;

        /// <summary>
        /// Emergency calling feature availability/emergency address requirement indicator
        /// </summary>
        public bool? emergencyCalling;

        /// <summary>
        /// Country code according to the ISO standard, see ISO 3166
        /// </summary>
        public string isoCode;

        /// <summary>
        /// Official name of a country
        /// </summary>
        public string name;
    }
}