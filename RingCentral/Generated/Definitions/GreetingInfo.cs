using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GreetingInfo : Serializable
    {
        // Type of a greeting, specifying the case when the greeting is played.
        public string type;
        // Usage type of a greeting, specifying if the greeting is applied to user extension or department extension.
        public string usageType;
        public PresetInfo preset;
    }
}