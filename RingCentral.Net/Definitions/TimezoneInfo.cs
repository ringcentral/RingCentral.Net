namespace RingCentral
{
    // Extension timezone information
    public class TimezoneInfo
    {
        /// <summary>
        ///     Internal identifier of a timezone
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Canonical URI of a timezone
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Short name of a timezone
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Meaningful description of the timezone
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// </summary>
        public string bias { get; set; }
    }
}