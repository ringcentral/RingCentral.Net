namespace RingCentral
{
    public class BulkAddDevicesItem
    {
        /// <summary>
        ///     Internal identifier of a cost center
        ///     Example: 224149
        /// </summary>
        public string costCenterId { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public BulkOperationExtensionReference extension { get; set; }

        /// <summary>
        ///     Device type. Only "OtherPhone" and "WebRTC" device types are supported at the moment
        ///     Required
        ///     Enum: OtherPhone, WebRTC
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Only "address" is supported at the moment
        ///     Required
        /// </summary>
        public BulkAddDevicesItemEmergency emergency { get; set; }

        /// <summary>
        ///     To be used to assign a number by id
        ///     Required
        /// </summary>
        public BulkAddDevicesItemPhoneInfo phoneInfo { get; set; }
    }
}