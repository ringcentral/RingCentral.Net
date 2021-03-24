namespace RingCentral
{
    // Query parameters for operation listExtensionDevices
    public class ListExtensionDevicesParameters
    {
        /// <summary>
        /// Pooling type of a device
        /// Enum: Host, Guest, None
        /// </summary>
        public string linePooling { get; set; }

        /// <summary>
        /// Device feature or multiple features supported
        /// Enum: Intercom, Paging, BLA, HELD
        /// </summary>
        public string feature { get; set; }

        /// <summary>
        /// Number of a page to be returned
        /// Default: 1
        /// </summary>
        public string page { get; set; }

        /// <summary>
        /// Number of records per page to be returned
        /// Default: 100
        /// </summary>
        public string perPage { get; set; }
    }
}