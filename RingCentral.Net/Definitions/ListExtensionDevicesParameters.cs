namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listExtensionDevices
    /// </summary>
    public class ListExtensionDevicesParameters
    {
        /// <summary>
        ///     The result set page number (1-indexed) to return
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 1
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     The number of items per page. If provided value in the request
        ///     is greater than a maximum, the maximum value is applied
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 100
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Pooling type of device - Host - a device with standalone paid phone line which can be linked to a soft client
        ///     instance - Guest - a device with a linked phone line - None - a device without a phone line or with specific line
        ///     (free, BLA, etc.)
        ///     Enum: Host, Guest, None
        /// </summary>
        public string linePooling { get; set; }

        /// <summary>
        ///     Device feature or multiple features supported
        ///     Enum: BLA, CommonPhone, Intercom, Paging, HELD
        /// </summary>
        public string[] feature { get; set; }

        /// <summary>
        ///     Device type
        ///     Default: HardPhone
        ///     Enum: HardPhone, SoftPhone, OtherPhone, MobileDevice, BLA, Paging, WebPhone, WebRTC, Room
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     The type of phone line
        ///     Enum: Unknown, Standalone, StandaloneFree, BlaPrimary, BlaSecondary
        /// </summary>
        public string lineType { get; set; }
    }
}