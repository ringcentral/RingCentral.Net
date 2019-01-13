using Newtonsoft.Json;

namespace RingCentral
{
    public class CountryInfo : Serializable
    {
        // Internal identifier of a home country
        public string id;
        // Canonical URI of a home country
        public string uri;
        // Official name of a home country
        public string name;
    }
}