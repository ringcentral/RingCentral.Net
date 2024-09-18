namespace RingCentral
{
    /// <summary>
    ///     User interface language data
    /// </summary>
    public class LanguageInfo
    {
        /// <summary>
        ///     Internal identifier of a language
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a language
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Indicates whether a language is available as
        ///     greeting language
        /// </summary>
        public bool? greeting { get; set; }

        /// <summary>
        ///     Indicates whether a language is available as
        ///     formatting locale
        /// </summary>
        public bool? formattingLocale { get; set; }

        /// <summary>
        ///     Localization code of a language
        /// </summary>
        public string localeCode { get; set; }

        /// <summary>
        ///     Two-letter country code in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format
        ///     Example: US
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        ///     Official name of a language
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Indicates whether a language is available as UI language
        /// </summary>
        public bool? ui { get; set; }

        /// <summary>
        ///     Time format
        /// </summary>
        public string timeFormat { get; set; }

        /// <summary>
        ///     Date format
        /// </summary>
        public string dateFormat { get; set; }
    }
}