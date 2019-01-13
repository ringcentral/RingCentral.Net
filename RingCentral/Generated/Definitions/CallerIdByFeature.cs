using Newtonsoft.Json;

namespace RingCentral
{
    public class CallerIdByFeature : Serializable
    {
        public string feature;
        public CallerIdByFeatureInfo callerId;
    }
}