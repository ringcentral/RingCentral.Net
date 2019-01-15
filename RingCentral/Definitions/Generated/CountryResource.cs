using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CountryResource : Serializable
    {
        public string uri;
        public string id;
        public string name;
        public string isoCode;
        public string callingCode;
        public bool? emergencyCalling;
        public bool? numberSelling;
        public bool? loginAllowed;
    }
}