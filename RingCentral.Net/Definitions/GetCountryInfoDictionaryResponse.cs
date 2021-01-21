namespace RingCentral
{
    public class GetCountryInfoDictionaryResponse
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
        /// Country calling code defined by ITU-T recommendations [E.123](https://www.itu.int/rec/T-REC-E.123-200102-I/en) and [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I)
        /// </summary>
        public string callingCode { get; set; }

        /// <summary>
        /// Emergency calling feature availability/emergency address requirement indicator
        /// </summary>
        public bool? emergencyCalling { get; set; }

        /// <summary>
        /// Country code according to the ISO standard, see [ISO 3166](https://www.iso.org/iso-3166-country-codes.html)
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        /// Official name of a country
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Determines whether phone numbers are available for a country
        /// </summary>
        public bool? numberSelling { get; set; }

        /// <summary>
        /// Specifies whether login with the phone numbers of this country is enabled or not
        /// </summary>
        public bool? loginAllowed { get; set; }

        /// <summary>
        /// Indicates whether signup/billing is allowed for a country
        /// </summary>
        public bool? signupAllowed { get; set; }

        /// <summary>
        /// Specifies if free phone line for softphone is available for a country or not
        /// </summary>
        public bool? freeSoftphoneLine { get; set; }
    }
}