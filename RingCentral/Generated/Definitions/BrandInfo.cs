using Newtonsoft.Json;

namespace RingCentral
{
    public class BrandInfo : Serializable
    {
        // Internal identifier of a brand
        public string id;
        // Brand name, for example  RingCentral UK ,  ClearFax 
        public string name;
        // Home country information
        public CountryInfo homeCountry;
    }
}