namespace RingCentral
{
    public class CountryInfoBasicModel
    {
        /// <summary>
        ///     Internal identifier of a country
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a country resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     The official name of a country
        /// </summary>
        public string name { get; set; }
    }
}