namespace RingCentral
{
    /// <summary>
    ///     Timezone information
    /// </summary>
    public class TimezoneInfoBase
    {
        /// <summary>
        ///     Internal identifier of a timezone
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Short name of a timezone
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Meaningful description of the timezone
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Time difference (offset) in minutes from Coordinated Universal Time (UTC) that a specific locale follows
        /// </summary>
        public string bias { get; set; }
    }
}