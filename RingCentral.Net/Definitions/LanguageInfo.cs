namespace RingCentral
{
    public class LanguageInfo
    {
        /// <summary>
        /// Internal identifier of a language
        /// </summary>
        public string id;

        /// <summary>
        /// Canonical URI of a language
        /// </summary>
        public string uri;

        /// <summary>
        /// Indicates whether a language is available as greeting language
        /// </summary>
        public bool? greeting;

        /// <summary>
        /// Indicates whether a language is available as formatting locale
        /// </summary>
        public bool? formattingLocale;

        /// <summary>
        /// Localization code of a language
        /// </summary>
        public string localeCode;

        /// <summary>
        /// Country code according to the ISO standard, see [ISO 3166](https://www.iso.org/iso-3166-country-codes.html)
        /// </summary>
        public string isoCode;

        /// <summary>
        /// Official name of a language
        /// </summary>
        public string name;

        /// <summary>
        /// Indicates whether a language is available as UI language
        /// </summary>
        public bool? ui;
    }
}