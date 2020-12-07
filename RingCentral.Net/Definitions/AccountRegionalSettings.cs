namespace RingCentral
{
    // Account level region data (web service Auto-Receptionist settings)
    public class AccountRegionalSettings
    {
        /// <summary>
        /// </summary>
        public CountryInfo homeCountry;

        /// <summary>
        /// </summary>
        public TimezoneInfo timezone;

        /// <summary>
        /// </summary>
        public LanguageInfo language;

        /// <summary>
        /// </summary>
        public GreetingLanguageInfo greetingLanguage;

        /// <summary>
        /// </summary>
        public FormattingLocaleInfo formattingLocale;

        /// <summary>
        /// Time format setting. The default value is '12h' = ['12h', '24h']
        /// Enum: 12h, 24h
        /// </summary>
        public string timeFormat;

        /// <summary>
        /// </summary>
        public CurrencyInfo currency;
    }
}