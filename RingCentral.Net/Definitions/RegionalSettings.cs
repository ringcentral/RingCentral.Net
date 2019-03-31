namespace RingCentral
{
    public class RegionalSettings
    {
        /// <summary>
        /// Extension country information
        /// </summary>
        public CountryInfo homeCountry;

        /// <summary>
        /// Extension timezone information
        /// </summary>
        public TimezoneInfo timezone;

        /// <summary>
        /// User interface language data
        /// </summary>
        public LanguageInfo language;

        /// <summary>
        /// Information on language used for telephony greetings
        /// </summary>
        public GreetingLanguageInfo greetingLanguage;

        /// <summary>
        /// Formatting language preferences for numbers, dates and currencies
        /// </summary>
        public FormattingLocaleInfo formattingLocale;

        /// <summary>
        /// Time format setting. The default value is '12h' = ['12h', '24h']
        /// Enum: 12h, 24h
        /// </summary>
        public string timeFormat;
    }
}