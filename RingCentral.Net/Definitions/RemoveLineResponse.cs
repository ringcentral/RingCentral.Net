namespace RingCentral
{
    public class RemoveLineResponse
    {
        /// <summary>
        ///     Internal identifier of a source device
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Device type
        ///     Required
        ///     Default: HardPhone
        ///     Enum: HardPhone, SoftPhone, OtherPhone, MobileDevice, BLA, Paging, WebPhone, WebRTC, ZoomMobile, ZoomPhone, Room,
        ///     Unknown
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     The display name of a source device
        ///     Required
        ///     Example: My Device N1
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Serial number of a device (HardPhone)
        ///     Example: ff:ff:ff:ff:ff:ff
        /// </summary>
        public string serial { get; set; }
    }
}