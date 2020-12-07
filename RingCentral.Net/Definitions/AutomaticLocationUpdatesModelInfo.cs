namespace RingCentral
{
    // HardPhone model information
    public class AutomaticLocationUpdatesModelInfo
    {
        /// <summary>
        /// Device model identifier
        /// </summary>
        public string id;

        /// <summary>
        /// Device name
        /// </summary>
        public string name;

        /// <summary>
        /// Device feature or multiple features supported
        /// Enum: BLA, Intercom, Paging, HELD
        /// </summary>
        public string[] features;
    }
}