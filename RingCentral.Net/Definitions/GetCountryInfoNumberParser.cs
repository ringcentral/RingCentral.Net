namespace RingCentral
{
    // Information on a user home country || Information on a country the phone number belongs to
    public class GetCountryInfoNumberParser
    {
        /// <summary>
        /// Internal identifier of a country
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Canonical URI of a country
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Country calling code defined by ITU-T recommendations E.123 and E.164, see Calling Codes
        /// </summary>
        public string callingCode { get; set; }

        /// <summary>
        /// Emergency calling feature availability/emergency address requirement indicator
        /// </summary>
        public bool? emergencyCalling { get; set; }

        /// <summary>
        /// Country code according to the ISO standard, see ISO 3166
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        /// Official name of a country
        /// </summary>
        public string name { get; set; }
    }
}