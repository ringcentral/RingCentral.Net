namespace RingCentral
{
    // Timezone setting. For extension bulk assignment is configured automatically based on contact info setting
    public class TimezoneResource
    {
        /// <summary>
        /// Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// </summary>
        public string bias { get; set; }
    }
}