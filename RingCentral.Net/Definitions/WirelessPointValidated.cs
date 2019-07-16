namespace RingCentral
{
    public class WirelessPointValidated
    {
        /// <summary>
        /// Internal identifier of a wireless point
        /// </summary>
        public string id;

        /// <summary>
        /// Unique 48-bit identifier of the wireless access point that follows MAC address conventions
        /// </summary>
        public string bssid;

        /// <summary>
        /// Validation result status
        /// Enum: Valid, Invalid
        /// </summary>
        public string status;

        /// <summary>
        /// </summary>
        public ValidationError[] errors;
    }
}