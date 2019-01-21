using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CustomCompanyGreetingLanguageInfo : Serializable
    {
        // Internal identifier of a greeting language
        public string id;
        // Link to a greeting language
        public string uri;
        // Name of a greeting language
        public string name;
        // Locale code of a greeting language
        public string localeCode;
    }
}