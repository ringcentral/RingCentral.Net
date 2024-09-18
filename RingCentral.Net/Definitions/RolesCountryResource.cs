namespace RingCentral
{
    public class RolesCountryResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Two-letter country code in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format
        ///     Example: US
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        ///     Country calling code defined by [ITU-T](http://en.wikipedia.org/wiki/ITU-T)
        ///     recommendations, [E.123](http://en.wikipedia.org/wiki/E.123) and
        ///     [E.164](http://en.wikipedia.org/wiki/E.164).
        ///     See also [Calling Codes](http://en.wikipedia.org/wiki/List_of_country_calling_codes)
        /// </summary>
        public string callingCode { get; set; }

        /// <summary>
        /// </summary>
        public bool? emergencyCalling { get; set; }

        /// <summary>
        /// </summary>
        public bool? numberSelling { get; set; }

        /// <summary>
        /// </summary>
        public bool? loginAllowed { get; set; }

        /// <summary>
        /// </summary>
        public bool? freeSoftphoneLine { get; set; }

        /// <summary>
        /// </summary>
        public bool? signupAllowed { get; set; }
    }
}