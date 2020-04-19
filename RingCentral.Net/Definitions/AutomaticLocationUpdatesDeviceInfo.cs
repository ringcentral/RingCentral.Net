namespace RingCentral
{
    public class AutomaticLocationUpdatesDeviceInfo
    {
        /// <summary>
        /// Internal identifier of a device
        /// </summary>
        public string id;

        /// <summary>
        /// Device type
        /// Default: HardPhone
        /// Enum: HardPhone, SoftPhone, OtherPhone
        /// </summary>
        public string type;

        /// <summary>
        /// Serial number for HardPhone (is returned only when the phone is shipped and provisioned)
        /// </summary>
        public string serial;

        /// <summary>
        /// Specifies if Automatic Location Updates feature is enabled
        /// </summary>
        public bool? featureEnabled;

        /// <summary>
        /// Device name
        /// </summary>
        public string name;

        /// <summary>
        /// HardPhone model information
        /// </summary>
        public AutomaticLocationUpdatesModelInfo model;

        /// <summary>
        /// Site data
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site;

        /// <summary>
        /// Phone lines information
        /// </summary>
        public AutomaticLocationUpdatesPhoneLine[] phoneLines;
    }
}