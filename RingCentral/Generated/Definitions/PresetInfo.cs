using Newtonsoft.Json;

namespace RingCentral
{
    public class PresetInfo : Serializable
    {
        // Link to a greeting resource
        public string uri;
        // Internal identifier of a greeting
        public string id;
        // Name of a greeting
        public string name;
    }
}