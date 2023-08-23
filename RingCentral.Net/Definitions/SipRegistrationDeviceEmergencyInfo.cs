namespace RingCentral
{
    /// <summary>
    ///     Emergency response location settings of a device
    /// </summary>
    public class SipRegistrationDeviceEmergencyInfo
    {
        /// <summary>
        ///     Address for emergency cases. The same emergency address is assigned to all the numbers of one device
        /// </summary>
        public SipRegistrationDeviceEmergencyInfoAddress address { get; set; }

        /// <summary>
        /// </summary>
        public SipRegistrationDeviceLocationInfo location { get; set; }

        /// <summary>
        ///     Specifies if emergency address is out of country
        /// </summary>
        public bool? outOfCountry { get; set; }

        /// <summary>
        ///     Emergency address status
        ///     Enum: Valid, Invalid, Processing
        /// </summary>
        public string addressStatus { get; set; }

        /// <summary>
        ///     Specifies whether to return only private or only public (company) ERLs (Emergency Response Locations)
        ///     Enum: Private, Public
        /// </summary>
        public string visibility { get; set; }

        /// <summary>
        ///     Resulting status of emergency address synchronization. Returned
        ///     if `syncEmergencyAddress` parameter is set to 'True'
        ///     Enum: Verified, Updated, Deleted, NotRequired, Unsupported, Failed
        /// </summary>
        public string syncStatus { get; set; }

        /// <summary>
        ///     Ability to register new emergency address for a phone line
        ///     using devices sharing this line or only main device (line owner)
        ///     Enum: MainDevice, AnyDevice
        /// </summary>
        public string addressEditableStatus { get; set; }

        /// <summary>
        ///     Indicates if emergency address is required for the country of a phone line
        /// </summary>
        public bool? addressRequired { get; set; }

        /// <summary>
        ///     Indicates if out of country emergency address is not allowed for the country of a phone line
        /// </summary>
        public bool? addressLocationOnly { get; set; }
    }
}