using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CustomUserGreetingInfo : Serializable
    {
        // Link to a custom user greeting
        public string uri;
        // Internal identifier of a custom user greeting
        public string id;
        // Type of a custom user greeting
        public string type;
        // Content media type in WAV/MP3 format
        public string contentType;
        // Link to a greeting content (audio file)
        public string contentUri;
        // Information on an answering rule that the greeting is applied to
        public CustomGreetingAnsweringRuleInfo answeringRule;
    }
}