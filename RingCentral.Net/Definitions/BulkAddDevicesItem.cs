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
        ///     Required
        /// </summary>
        public BulkAddDevicesItemEmergency emergency { get; set; }

        /// <summary>
        ///     Assign a specific phone number
        ///     Required
        /// </summary>
        public BulkAddDevicesItemPhoneInfo phoneInfo { get; set; }

        /// <summary>
        ///     The option that indicates whether Contact Center Phone Line should be created or not
        /// </summary>
        public bool? contactCenterPhoneLine { get; set; }
    }
}