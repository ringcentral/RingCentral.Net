namespace RingCentral
{
    public class AccountDeviceUpdate
    {
        /// <summary>
        /// </summary>
        public EmergencyServiceAddressResourceRequest emergencyServiceAddress { get; set; }

        /// <summary>
        /// </summary>
        public DeviceEmergencyInfo emergency { get; set; }

        /// <summary>
        /// </summary>
        public DeviceUpdateExtensionInfo extension { get; set; }

        /// <summary>
        /// </summary>
        public DeviceUpdatePhoneLinesInfo phoneLines { get; set; }

        /// <summary>
        ///     Supported only for devices assigned to Limited extensions. If true, enables users to log in to this phone as a
        ///     common phone.
        /// </summary>
        public bool? useAsCommonPhone { get; set; }
    }
}