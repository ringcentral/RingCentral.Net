namespace RingCentral
{
    // HardPhone model information
    public class DeviceModelInfo
    {
        /// <summary>
        ///     Addon identifier. For HardPhones of certain types, which are compatible with this addon identifier
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Device name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Addons description
        ///     Required
        /// </summary>
        public DeviceAddonInfo[] addons { get; set; }

        /// <summary>
        ///     Device feature or multiple features supported
        ///     Enum: BLA, Intercom, Paging, HELD
        /// </summary>
        public string[] features { get; set; }
    }
}