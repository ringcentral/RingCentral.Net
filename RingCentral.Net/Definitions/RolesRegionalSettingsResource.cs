namespace RingCentral
{
    public class RolesRegionalSettingsResource
    {
        /// <summary>
        /// </summary>
        public RolesTimezoneResource timezone { get; set; }

        /// <summary>
        /// </summary>
        public RolesCountryResource homeCountry { get; set; }

        /// <summary>
        /// </summary>
        public RolesLanguageResource language { get; set; }

        /// <summary>
        /// </summary>
        public RolesLanguageResource greetingLanguage { get; set; }

        /// <summary>
        /// </summary>
        public RolesLanguageResource formattingLocale { get; set; }

        /// <summary>
        ///     Time format (12-hours or 24-hours).
        ///     Default: 12h
        ///     Enum: 12h, 24h
        /// </summary>
        public string timeFormat { get; set; }

        /// <summary>
        /// </summary>
        public CurrencyResource currency { get; set; }
    }
}