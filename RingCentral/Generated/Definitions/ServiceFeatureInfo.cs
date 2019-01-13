using Newtonsoft.Json;

namespace RingCentral
{
    public class ServiceFeatureInfo : Serializable
    {
        // Feature name
        public string featureName;
        // Feature status, shows feature availability for the extension
        public bool? enabled;
    }
}