using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ServiceFeatureValue : Serializable
    {
        public string featureName;
        public bool? enabled;
        public string reason;
    }
}