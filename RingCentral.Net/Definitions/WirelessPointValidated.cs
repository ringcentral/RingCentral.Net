namespace RingCentral
{
    public class WirelessPointValidated
    {
        /// <summary>
        /// Internal identifier of a wireless point
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Unique 48-bit identifier of the wireless access point complying with MAC address conventions
        /// </summary>
        public string bssid { get; set; }

        /// <summary>
        /// Validation result status
        /// Enum: Valid, Invalid
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public ValidationError[] errors { get; set; }
    }
}