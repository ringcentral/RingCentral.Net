using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ContactBusinessAddressInfo : Serializable
    {
        // Country name of an extension user company
        public string country;
        // State/province name of an extension user company. Mandatory for the USA, UK and Canada
        public string state;
        // City name of an extension user company
        public string city;
        // Street address of an extension user company
        public string street;
        // Zip code of an extension user company
        public string zip;
    }
}