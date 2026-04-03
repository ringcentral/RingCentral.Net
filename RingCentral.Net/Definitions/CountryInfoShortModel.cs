namespace RingCentral
{
    public class CountryInfoShortModel
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
    }
}