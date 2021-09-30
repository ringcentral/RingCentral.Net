namespace RingCentral
{
    // Device information
    public class DeviceInfoRequest
    {
        /// <summary>
        ///     Device unique identifier, retrieved at previous session (if any)
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Supported for iOS devices only. Certificate name (used by iOS applications for APNS subscription)
        /// </summary>
        public string appExternalId { get; set; }

        /// <summary>
        ///     Supported for SoftPhone only. Computer name
        /// </summary>
        public string computerName { get; set; }

        /// <summary>
        ///     Serial number for HardPhone; `endpoint_id` for softphone and mobile applications. Returned only when the phone is
        ///     shipped and provisioned
        /// </summary>
        public string serial { get; set; }
    }
}