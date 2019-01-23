using Newtonsoft.Json;

namespace RingCentral
{
    public class BlockedCallerGreetingInfo : Serializable
    {
        // Type of a greeting
        public string type;
        public PresetInfo preset;
    }
}