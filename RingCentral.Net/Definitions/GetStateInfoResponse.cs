namespace RingCentral
{
    public class GetStateInfoResponse
    {
        /// <summary>
        /// Internal identifier of a state
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Canonical URI of a state
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public GetCountryInfoState country { get; set; }

        /// <summary>
        /// Short code for a state (2-letter usually)
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        /// Official name of a state
        /// </summary>
        public string name { get; set; }
    }
}