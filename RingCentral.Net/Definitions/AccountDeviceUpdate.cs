namespace RingCentral
{
    public class AccountDeviceUpdate
    {
        /// <summary>
        /// Address for emergency cases. The same emergency address is assigned to all numbers of a single device
        /// </summary>
        public DeviceEmergencyAddressInfoRequest emergencyServiceAddress;

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