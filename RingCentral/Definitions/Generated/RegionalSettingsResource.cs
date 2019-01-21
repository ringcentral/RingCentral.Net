using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class RegionalSettingsResource : Serializable
    {
        public TimezoneResource timezone;
        public CountryResource homeCountry;
        public LanguageResource language;
        public LanguageResource greetingLanguage;
        public LanguageResource formattingLocale;
    }
}