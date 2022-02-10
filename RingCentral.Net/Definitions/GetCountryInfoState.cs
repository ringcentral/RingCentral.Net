namespace RingCentral
{
    /// <summary>
    ///     Information on a country the state belongs to
    /// </summary>
    public class GetCountryInfoState
    {
        /// <summary>
        ///     Internal identifier of a state
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a state
        /// </summary>
        public string uri { get; set; }
    }
}