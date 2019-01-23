namespace RingCentral
{
    public class LanguageInfo : Serializable
    {
        // Internal identifier of a language
        public string id;
        // Canonical URI of a language
        public string uri;
        // Indicates whether a language is available as greeting language
        public bool? greeting;
        // Indicates whether a language is available as formatting locale
        public bool? formattingLocale;
        // Localization code of a language
        public string localeCode;
        // Official name of a language
        public string name;
        // Indicates whether a language is available as UI language
        public bool? ui;
    }
}