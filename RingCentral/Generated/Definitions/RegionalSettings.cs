using Newtonsoft.Json;

namespace RingCentral
{
    public class RegionalSettings : Serializable
    {
        // Extension country information
        public CountryInfo homeCountry;
        // Extension timezone information
        public TimezoneInfo timezone;
        // User interface language data
        public LanguageInfo language;
        // Information on language used for telephony greetings
        public GreetingLanguageInfo greetingLanguage;
        // Formatting language preferences for numbers, dates and currencies
        public FormattingLocaleInfo formattingLocale;
        // Time format setting. The default value is '12h' = ['12h', '24h']
        public string timeFormat;
    }
}