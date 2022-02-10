namespace RingCentral
{
    /// <summary>
    ///     HardPhone model information
    /// </summary>
    public class AutomaticLocationUpdatesModelInfo
    {
        /// <summary>
        ///     Device model identifier
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Device name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Device feature or multiple features supported
        ///     Enum: BLA, Intercom, Paging, HELD
        /// </summary>
        public string[] features { get; set; }
    }
}