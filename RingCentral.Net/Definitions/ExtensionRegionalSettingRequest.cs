namespace RingCentral
{
    /// <summary>
    ///     Regional data (timezone, home country, language) of an extension.
    ///     The default is Company (Auto-Receptionist) settings
    /// </summary>
    public class ExtensionRegionalSettingRequest
    {
        /// <summary>
        /// </summary>
        public ExtensionCountryInfoRequest homeCountry { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionTimezoneInfoRequest timezone { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionLanguageInfoRequest language { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionGreetingLanguageInfoRequest greetingLanguage { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionFormattingLocaleInfoRequest formattingLocale { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionCurrencyInfoRequest currency { get; set; }

        /// <summary>
        ///     Time format (12-hours or 24-hours).
        ///     Default: 12h
        ///     Enum: 12h, 24h
        /// </summary>
        public string timeFormat { get; set; }
    }
}