namespace RingCentral
{
    public class AutomaticLocationUpdatesDeviceInfo
    {
        /// <summary>
        /// Internal identifier of a device
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Device type
        /// Default: HardPhone
        /// Enum: HardPhone, SoftPhone, OtherPhone
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Serial number for HardPhone (is returned only when the phone is shipped and provisioned)
        /// </summary>
        public string serial { get; set; }

        /// <summary>
        /// Specifies if Automatic Location Updates feature is enabled
        /// </summary>
        public bool? featureEnabled { get; set; }

        /// <summary>
        /// Device name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesModelInfo model { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site { get; set; }

        /// <summary>
        /// Phone lines information
        /// </summary>
        public AutomaticLocationUpdatesPhoneLine[] phoneLines { get; set; }
    }
}