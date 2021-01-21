namespace RingCentral
{
    // User interface language data
    public class LanguageInfo
    {
        /// <summary>
        /// Internal identifier of a language
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Canonical URI of a language
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Indicates whether a language is available as greeting language
        /// </summary>
        public bool? greeting { get; set; }

        /// <summary>
        /// Indicates whether a language is available as formatting locale
        /// </summary>
        public bool? formattingLocale { get; set; }

        /// <summary>
        /// Localization code of a language
        /// </summary>
        public string localeCode { get; set; }

        /// <summary>
        /// Country code according to the ISO standard, see [ISO 3166](https://www.iso.org/iso-3166-country-codes.html)
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        /// Official name of a language
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Indicates whether a language is available as UI language
        /// </summary>
        public bool? ui { get; set; }
    }
}