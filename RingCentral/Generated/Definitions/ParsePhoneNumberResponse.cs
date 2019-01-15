using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ParsePhoneNumberResponse : Serializable
    {
        // Canonical URI of a resource
        public string uri;
        // Information on a user home country
        public GetCountryInfoNumberParser[] homeCountry; // Required
        // Parsed phone numbers data
        public PhoneNumberInfoNumberParser[] phoneNumbers; // Required
    }
}