namespace RingCentral
{
    public class GetTimezoneInfoResponse
    {
        /// <summary>
        ///     Internal identifier of a timezone
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a timezone
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Short name of a timezone
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Description of a timezone
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// </summary>
        public string bias { get; set; }
    }
}