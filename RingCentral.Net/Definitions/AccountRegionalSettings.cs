namespace RingCentral
{
    /// <summary>
    ///     Account level region data (web service Auto-Receptionist settings)
    /// </summary>
    public class AccountRegionalSettings
    {
        /// <summary>
        /// </summary>
        public CountryInfoShortModel homeCountry { get; set; }

        /// <summary>
        /// </summary>
        public TimezoneInfo timezone { get; set; }

        /// <summary>
        /// </summary>
        public RegionalLanguageInfo language { get; set; }

        /// <summary>
        /// </summary>
        public GreetingLanguageInfo greetingLanguage { get; set; }

        /// <summary>
        /// </summary>
        public FormattingLocaleInfo formattingLocale { get; set; }

        /// <summary>
        ///     Time format (12-hours or 24-hours).
        ///     Default: 12h
        ///     Enum: 12h, 24h
        /// </summary>
        public string timeFormat { get; set; }

        /// <summary>
        /// </summary>
        public CurrencyInfo currency { get; set; }
    }
}