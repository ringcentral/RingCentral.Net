using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class BlockedCallerGreetingInfo : Serializable
    {
        // Type of a greeting
        public string type;
        public PresetInfo preset;
    }
}