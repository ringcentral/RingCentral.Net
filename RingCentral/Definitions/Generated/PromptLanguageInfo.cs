namespace RingCentral
{
    public class PromptLanguageInfo : Serializable
    {
        // Link to a prompt language
        public string uri;

        // Internal identifier of a language
        public string id;

        // Language name
        public string name;

        // Language locale code
        public string localeCode;
    }
}