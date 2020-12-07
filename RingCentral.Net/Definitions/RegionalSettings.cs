namespace RingCentral
{
    // Extension region data (timezone, home country, language) || Account level region data (web service Auto-Receptionist settings) || Information about regional settings. The default is Company settings
    public class RegionalSettings
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
    }
}