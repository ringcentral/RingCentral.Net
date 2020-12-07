namespace RingCentral
{
    public class AccountDeviceUpdate
    {
        /// <summary>
        /// </summary>
        public EmergencyServiceAddressResourceRequest emergencyServiceAddress;

        /// <summary>
        /// </summary>
        public DeviceEmergencyInfo emergency;

        /// <summary>
        /// </summary>
        public DeviceUpdateExtensionInfo extension;

        /// <summary>
        /// </summary>
        public DeviceUpdatePhoneLinesInfo phoneLines;

        /// <summary>
        /// Supported only for devices assigned to Limited extensions. If true, enables users to log in to this phone as a common phone.
        /// </summary>
        public bool? useAsCommonPhone;
    }
}