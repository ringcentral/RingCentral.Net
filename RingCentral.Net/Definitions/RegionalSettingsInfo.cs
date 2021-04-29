namespace RingCentral
{
    public class RegionalSettingsInfo
    {
        /// <summary>
        /// </summary>
        public DeviceTimezoneResource timezone { get; set; }

        /// <summary>
        /// </summary>
        public DeviceCountryResource homeCountry { get; set; }

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