namespace RingCentral
{
    public class ModelInfo
    {
        /// <summary>
        /// Addon identifier. For HardPhones of certain types, which are compatible with this addon identifier
        /// </summary>
        public string id;

        /// <summary>
        /// Device name
        /// </summary>
        public string name;

        /// <summary>
        /// Addons description
        /// Required
        /// </summary>
        public AddonInfo[] addons;

        /// <summary>
        /// Device feature or multiple features supported
        /// Enum: BLA, Intercom, Paging, HELD
        /// </summary>
        public string[] features;

        /// <summary>
        /// Max supported count of phone lines
        /// </summary>
        public long? lineCount;
    }
}