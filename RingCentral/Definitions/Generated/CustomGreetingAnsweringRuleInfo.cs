using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CustomGreetingAnsweringRuleInfo : Serializable
    {
        // Canonical URI of an answering rule
        public string uri;
        // Internal identifier of an answering rule
        public string id;
    }
}