namespace RingCentral
{
    // Regional data (timezone, home country, language) of an extension/account. The default is Company (Auto-Receptionist) settings
    public class RegionalSettings
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
    }
}