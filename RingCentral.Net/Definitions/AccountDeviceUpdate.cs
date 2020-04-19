namespace RingCentral
{
    public class AccountDeviceUpdate
    {
        /// <summary>
        /// Address for emergency cases. The same emergency address is assigned to all numbers of a single device. If the emergency address is also specified in `emergency` resource, then this value is ignored
        /// </summary>
        public EmergencyServiceAddressResourceRequest emergencyServiceAddress;

        /// <summary>
        /// Device emergency settings
        /// </summary>
        public DeviceEmergencyInfo emergency;

        /// <summary>
        /// Information on extension that the device is assigned to
        /// </summary>
        public DeviceUpdateExtensionInfo extension;

        /// <summary>
        /// Information on phone lines added to a device
        /// </summary>
        public DeviceUpdatePhoneLinesInfo phoneLines;

        /// <summary>
        /// Supported only for devices assigned to Limited extensions. If true, enables users to log in to this phone as a common phone.
        /// </summary>
        public bool? useAsCommonPhone;
    }
}