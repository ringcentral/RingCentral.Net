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
        ///     A ISO country code value complying with the
        ///     [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)
        ///     format.
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        ///     Country calling code defined by [ITU-T](http://en.wikipedia.org/wiki/ITU-T)
        ///     recommendations [E.123](http://en.wikipedia.org/wiki/E.123) and
        ///     [E.164](http://en.wikipedia.org/wiki/E.164),
        ///     see [Calling Codes](http://en.wikipedia.org/wiki/List_of_country_calling_codes)
        /// </summary>
        public string callingCode { get; set; }
    }
}