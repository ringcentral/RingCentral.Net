namespace RingCentral
{
    /// <summary>
    ///     Regional data (timezone, home country, language) of an extension/account.
    ///     The default is Company (Auto-Receptionist) settings
    /// </summary>
    public class RegionalSettings
    {
        /// <summary>
        /// </summary>
        public CountryInfoShortModel homeCountry { get; set; }

        /// <summary>
        /// </summary>
        public TimezoneInfoBase timezone { get; set; }

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
    }
}