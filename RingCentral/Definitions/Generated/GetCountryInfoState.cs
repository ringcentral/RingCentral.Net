using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GetCountryInfoState : Serializable
    {
        // Internal identifier of a state
        public string id;
        // Canonical URI of a state
        public string uri;
    }
}