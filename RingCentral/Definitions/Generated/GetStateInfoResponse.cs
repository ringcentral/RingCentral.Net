namespace RingCentral
{
    public class GetStateInfoResponse : Serializable
    {
        // Internal identifier of a state
        public string id;

        // Canonical URI of a state
        public string uri;

        // Information on a country the state belongs to
        public GetCountryInfoState country;

        // Short code for a state (2-letter usually)
        public string isoCode;

        // Official name of a state
        public string name;
    }
}