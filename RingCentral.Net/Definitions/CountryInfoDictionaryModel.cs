namespace RingCentral
{
    public class CountryInfoDictionaryModel
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
        ///     The official name of a country
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Country code according to the ISO standard, see
        ///     [ISO 3166](https://www.iso.org/iso-3166-country-codes.html)
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        ///     Country calling code defined by [ITU-T](http://en.wikipedia.org/wiki/ITU-T)
        ///     recommendations [E.123](http://en.wikipedia.org/wiki/E.123) and
        ///     [E.164](http://en.wikipedia.org/wiki/E.164),
        ///     see [Calling Codes](http://en.wikipedia.org/wiki/List_of_country_calling_codes)
        /// </summary>
        public string callingCode { get; set; }

        /// <summary>
        ///     Emergency calling feature availability/emergency address requirement indicator
        /// </summary>
        public bool? emergencyCalling { get; set; }

        /// <summary>
        ///     Indicates that phone numbers are available for this country
        /// </summary>
        public bool? numberSelling { get; set; }

        /// <summary>
        ///     Indicates that login with the phone number of this country is allowed
        /// </summary>
        public bool? loginAllowed { get; set; }

        /// <summary>
        ///     Indicates that signup/billing is allowed for this country
        /// </summary>
        public bool? signupAllowed { get; set; }

        /// <summary>
        ///     Indicates that free phone line for softphone is available for this country
        /// </summary>
        public bool? freeSoftphoneLine { get; set; }

        /// <summary>
        ///     Indicates that the local dialing is supported in this country and default area code can be set
        /// </summary>
        public bool? localDialing { get; set; }
    }
}