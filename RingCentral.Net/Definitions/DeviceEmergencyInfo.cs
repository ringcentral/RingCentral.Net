namespace RingCentral
{
    public class DeviceEmergencyInfo
    {
        /// <summary>
        /// </summary>
        public DeviceEmergencyAddress address;

        /// <summary>
        /// Company emergency response location details
        /// </summary>
        public DeviceEmergencyLocationInfo location;

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
    }
}