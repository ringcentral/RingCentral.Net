namespace RingCentral
{
    /// <summary>
    ///     Device emergency settings
    /// </summary>
    public class DeviceEmergencyInfo
    {
        /// <summary>
        /// </summary>
        public CommonEmergencyLocationAddressInfoDefault address { get; set; }

        /// <summary>
        /// </summary>
        public DeviceEmergencyLocationInfo location { get; set; }

        /// <summary>
        ///     Specifies if emergency address is out of country
        /// </summary>
        public bool? outOfCountry { get; set; }

        /// <summary>
        ///     Emergency address status
        ///     Enum: Valid, Invalid, Provisioning
        /// </summary>
        public string addressStatus { get; set; }

        /// <summary>
        ///     Visibility of an emergency response location. If `Private`
        ///     is set, then location is visible only for the restricted number of users,
        ///     specified in `owners` array
        ///     Enum: Private, Public
        /// </summary>
        public string visibility { get; set; }

        /// <summary>
        ///     Resulting status of the emergency address synchronization. Returned
        ///     if `syncEmergencyAddress` parameter is set to `true`
        ///     Enum: Verified, Updated, Deleted, NotRequired, Unsupported, Failed
        /// </summary>
        public string syncStatus { get; set; }

        /// <summary>
        ///     Ability to register new emergency address for a phone line
        ///     using devices sharing this line or only main device (line owner)
        ///     Enum: MainDevice, AnyDevice
        /// </summary>
        public string addressEditableStatus { get; set; }
    }
}