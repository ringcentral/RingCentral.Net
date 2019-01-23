namespace RingCentral
{
    public class GetCountryInfoNumberParser : Serializable
    {
        // Internal identifier of a country
        public string id;
        // Canonical URI of a country
        public string uri;
        // Country calling code defined by ITU-T recommendations E.123 and E.164, see Calling Codes
        public string callingCode;
        // Emergency calling feature availability/emergency address requirement indicator
        public bool? emergencyCalling;
        // Country code according to the ISO standard, see ISO 3166
        public string isoCode;
        // Official name of a country
        public string name;
    }
}