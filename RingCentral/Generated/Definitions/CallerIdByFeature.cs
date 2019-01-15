using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallerIdByFeature : Serializable
    {
        public string feature;
        public CallerIdByFeatureInfo callerId;
    }
}