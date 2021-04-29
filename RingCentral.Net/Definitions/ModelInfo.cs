namespace RingCentral
{
    // HardPhone model information
    public class ModelInfo
    {
        /// <summary>
        ///     Internal identifier of a HardPhone device model
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Device name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Addons description
        /// </summary>
        public AddonInfo[] addons { get; set; }

        /// <summary>
        /// </summary>
        public string deviceClass { get; set; }

        /// <summary>
        ///     Device feature or multiple features supported
        ///     Enum: BLA, CommonPhone, Intercom, Paging, HELD
        /// </summary>
        public string[] features { get; set; }

        /// <summary>
        ///     Max supported count of phone lines
        /// </summary>
        public long? lineCount { get; set; }
    }
}