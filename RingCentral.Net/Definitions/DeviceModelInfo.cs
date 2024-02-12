namespace RingCentral
{
    /// <summary>
    ///     HardPhone model information
    /// </summary>
    public class DeviceModelInfo
    {
        /// <summary>
        ///     Addon identifier. For HardPhones of certain types, which are compatible with this add-on identifier
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Device name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Add-ons description
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