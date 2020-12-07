namespace RingCentral
{
    // Emergency response location settings of a device
    public class SipRegistrationDeviceEmergencyInfo
    {
        /// <summary>
        /// </summary>
        public DeviceEmergencyServiceAddressResource address;

        /// <summary>
        /// </summary>
        public SipRegistrationDeviceLocationInfo location;

        /// <summary>
        /// Specifies if emergency address is out of country
        /// </summary>
        public bool? outOfCountry;

        /// <summary>
        /// Emergency address status
        /// Enum: Valid, Invalid
        /// </summary>
        public string addressStatus;

        /// <summary>
        /// Resulting status of emergency address synchronization. Returned if `syncEmergencyAddress` parameter is set to 'True'
        /// Enum: Verified, Updated, Deleted, NotRequired, Unsupported, Failed
        /// </summary>
        public string syncStatus;

        /// <summary>
        /// Ability to register new emergency address for a phone line using devices sharing this line or only main device (line owner)
        /// Enum: MainDevice, AnyDevice
        /// </summary>
        public string addressEditableStatus;

        /// <summary>
        /// 'True' if emergency address is required for the country of a phone line
        /// </summary>
        public bool? addressRequired;

        /// <summary>
        /// 'True' if out of country emergency address is not allowed for the country of a phone line
        /// </summary>
        public bool? addressLocationOnly;
    }
}