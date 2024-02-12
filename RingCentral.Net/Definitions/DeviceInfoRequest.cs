namespace RingCentral
{
    /// <summary>
    ///     Device information
    /// </summary>
    public class DeviceInfoRequest
    {
        /// <summary>
        ///     Device unique identifier, retrieved at previous session (if any)
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Supported for iOS devices only. Certificate name (used by iOS
        ///     applications for APNS subscription)
        /// </summary>
        public string appExternalId { get; set; }

        /// <summary>
        ///     Computer name (for devices of `SoftPhone` type only)
        /// </summary>
        public string computerName { get; set; }

        /// <summary>
        ///     Endpoint/device instance identifier for Softphone and mobile applications
        /// </summary>
        public string serial { get; set; }
    }
}