namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listExtensionDevices
    /// </summary>
    public class ListExtensionDevicesParameters
    {
        /// <summary>
        ///     Pooling type of a device
        ///     Enum: Host, Guest, None
        /// </summary>
        public string linePooling { get; set; }

        /// <summary>
        ///     Device feature or multiple features supported
        ///     Enum: Intercom, Paging, BLA, HELD
        /// </summary>
        public string feature { get; set; }

        /// <summary>
        ///     Number of a page to be returned
        ///     Default: 1
        /// </summary>
        public string page { get; set; }

        /// <summary>
        ///     Number of records per page to be returned
        ///     Default: 100
        /// </summary>
        public string perPage { get; set; }

        /// <summary>
        ///     Device type
        ///     Default: HardPhone
        ///     Enum: Room, SoftPhone, OtherPhone, HardPhone, Paging, WebRTC
        /// </summary>
        public string line { get; set; }

        /// <summary>
        ///     Type of phone line
        ///     Enum: Standalone, StandaloneFree, BlaPrimary, BlaSecondary
        /// </summary>
        public string lineType { get; set; }
    }
}