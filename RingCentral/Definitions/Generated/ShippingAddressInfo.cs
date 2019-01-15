using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ShippingAddressInfo : Serializable
    {
        // Name of a receiver
        public string customerName;
        // Street address, line 1 - street address, P.O. box, company name, c/o
        public string street;
        // Street address, line 2 - apartment, suite, unit, building, floor, etc.
        public string street2;
        // City name
        public string city;
        // State/province name
        public string state;
        // Internal identifier of a state
        public string stateId;
        // ISO code of a state
        public string stateIsoCode;
        // Full name of a state
        public string stateName;
        // Internal identifier of a country
        public string countryId;
        // ISO code of a country
        public string countryIsoCode;
        // Country name
        public string country;
        // Full name of a country
        public string countryName;
        // Zip code
        public string zip;
    }
}