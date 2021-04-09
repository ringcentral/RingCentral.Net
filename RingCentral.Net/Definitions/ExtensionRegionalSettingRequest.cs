namespace RingCentral
{
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
        ///     Time format setting
        ///     Default: 12h
        ///     Enum: 12h, 24h
        /// </summary>
        public string timeFormat { get; set; }
    }
}