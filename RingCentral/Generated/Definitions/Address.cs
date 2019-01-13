using Newtonsoft.Json;

namespace RingCentral
{
    public class Address : Serializable
    {
        public string country;
        public string locality;
        public string postalCode;
        public string region;
        public string streetAddress;
        public string type;
    }
}