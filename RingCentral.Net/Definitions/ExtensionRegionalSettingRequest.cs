namespace RingCentral
{
    public class ExtensionRegionalSettingRequest
    {
        /// <summary>
        /// </summary>
        public ExtensionCountryInfoRequest homeCountry;

        /// <summary>
        /// </summary>
        public ExtensionTimezoneInfoRequest timezone;

        /// <summary>
        /// </summary>
        public ExtensionLanguageInfoRequest language;

        /// <summary>
        /// </summary>
        public ExtensionGreetingLanguageInfoRequest greetingLanguage;

        /// <summary>
        /// </summary>
        public ExtensionFormattingLocaleInfoRequest formattingLocale;

        /// <summary>
        /// Time format setting
        /// Default: 12h
        /// Enum: 12h, 24h
        /// </summary>
        public string timeFormat;
    }
}