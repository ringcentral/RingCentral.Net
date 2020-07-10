namespace RingCentral
{
    public class ModelInfo
    {
        /// <summary>
        /// Internal identifier of a HardPhone device model
        /// </summary>
        public string id;

        /// <summary>
        /// Device name
        /// </summary>
        public string name;

        /// <summary>
        /// Addons description
        /// </summary>
        public AddonInfo[] addons;

        /// <summary>
        /// Device feature or multiple features supported
        /// Enum: BLA, CommonPhone, Intercom, Paging, HELD
        /// </summary>
        public string[] features;

        /// <summary>
        /// Max supported count of phone lines
        /// </summary>
        public long? lineCount;
    }
}