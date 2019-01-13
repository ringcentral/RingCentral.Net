using Newtonsoft.Json;

namespace RingCentral
{
    public class ServiceFeatureValue : Serializable
    {
        public string featureName;
        public bool? enabled;
        public string reason;
    }
}