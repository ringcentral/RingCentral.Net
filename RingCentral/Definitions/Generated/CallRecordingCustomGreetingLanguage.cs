using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallRecordingCustomGreetingLanguage : Serializable
    {
        // Link to a language
        public string uri;
        // Internal identifier of a language
        public string id;
        // Language name
        public string name;
        // Language locale code
        public string localeCode;
    }
}