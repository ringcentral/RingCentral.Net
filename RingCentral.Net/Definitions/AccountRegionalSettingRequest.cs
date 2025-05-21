namespace RingCentral
{
    public class AccountRegionalSettingRequest
    {
        /// <summary>
        /// </summary>
        public AccountCountryInfoRequest homeCountry { get; set; }

        /// <summary>
        /// </summary>
        public AccountTimezoneInfoRequest timezone { get; set; }

        /// <summary>
        /// </summary>
        public AccountLanguageInfoRequest language { get; set; }

        /// <summary>
        /// </summary>
        public AccountGreetingLanguageInfoRequest greetingLanguage { get; set; }

        /// <summary>
        /// </summary>
        public AccountFormattingLocaleInfoRequest formattingLocale { get; set; }

        /// <summary>
        ///     Time format (12-hours or 24-hours).
        ///     Default: 12h
        ///     Enum: 12h, 24h
        /// </summary>
        public string timeFormat { get; set; }
    }
}