namespace RingCentral
{
    public class RegionalSettingsInfo
    {
        /// <summary>
        /// </summary>
        public TimezoneResource timezone { get; set; }

        /// <summary>
        /// </summary>
        public CountryResource homeCountry { get; set; }

        /// <summary>
        /// </summary>
        public LanguageResource language { get; set; }

        /// <summary>
        /// </summary>
        public LanguageResource greetingLanguage { get; set; }

        /// <summary>
        /// </summary>
        public LanguageResource formattingLocale { get; set; }
    }
}