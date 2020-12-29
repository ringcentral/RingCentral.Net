namespace RingCentral
{
    // Regional data (timezone, home country, language) of an extension/account. The default is Company (Auto-Receptionist) settings
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