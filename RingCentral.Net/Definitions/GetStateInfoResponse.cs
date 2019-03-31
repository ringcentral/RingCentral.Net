namespace RingCentral
{
    public class GetStateInfoResponse
    {
        /// <summary>
        /// Internal identifier of a state
        /// </summary>
        public string id;

        /// <summary>
        /// Canonical URI of a state
        /// </summary>
        public string uri;

        /// <summary>
        /// Information on a country the state belongs to
        /// </summary>
        public GetCountryInfoState country;

        /// <summary>
        /// Short code for a state (2-letter usually)
        /// </summary>
        public string isoCode;

        /// <summary>
        /// Official name of a state
        /// </summary>
        public string name;
    }
}