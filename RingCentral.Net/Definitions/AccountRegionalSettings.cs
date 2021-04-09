namespace RingCentral
{
    // Account level region data (web service Auto-Receptionist settings)
    public class AccountRegionalSettings
    {
        /// <summary>
        /// </summary>
        public CountryInfo homeCountry { get; set; }

        /// <summary>
        /// </summary>
        public TimezoneInfo timezone { get; set; }

        /// <summary>
        /// </summary>
        public LanguageInfo language { get; set; }

        /// <summary>
        /// </summary>
        public GreetingLanguageInfo greetingLanguage { get; set; }

        /// <summary>
        /// </summary>
        public FormattingLocaleInfo formattingLocale { get; set; }

        /// <summary>
        ///     Time format setting. The default value is '12h' = ['12h', '24h']
        ///     Enum: 12h, 24h
        /// </summary>
        public string timeFormat { get; set; }

        /// <summary>
        /// </summary>
        public CurrencyInfo currency { get; set; }
    }
}