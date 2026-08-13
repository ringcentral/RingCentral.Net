namespace RingCentral
{
    public class WebAppDeviceRecord
    {
        /// <summary>
        ///     Internal identifier of a device
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Device type. Always `WebPhone` for Web Phone (RC App) devices
        ///     Required
        ///     Enum: WebPhone
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Device name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Endpoint ID of the Web Phone (RC App) instance
        /// </summary>
        public string serial { get; set; }

        /// <summary>
        ///     Current registration status of the device. Set to `Online` when the device
        ///     has an active registration; otherwise `Offline`.
        ///     Required
        ///     Default: Offline
        ///     Enum: Offline, Online
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Time to live (TTL) of the current registration, in seconds.
        ///     Returned only while the device has an active registration.
        ///     Format: int32
        /// </summary>
        public long? expiresIn { get; set; }
    }
}