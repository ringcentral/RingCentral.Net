namespace RingCentral
{
    /// <summary>
    ///     Company emergency response location details
    /// </summary>
    public class EmergencyLocationResponseResource
    {
        /// <summary>
        ///     Internal identifier of an emergency response location
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public CommonEmergencyLocationAddressInfo address { get; set; }

        /// <summary>
        ///     Emergency response location name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public ShortSiteInfo site { get; set; }

        /// <summary>
        ///     Emergency address status
        ///     Enum: Valid, Invalid, Provisioning
        /// </summary>
        public string addressStatus { get; set; }

        /// <summary>
        ///     Status of emergency response location usage.
        ///     Enum: Active, Inactive
        /// </summary>
        public string usageStatus { get; set; }

        /// <summary>
        ///     Resulting status of emergency address synchronization. Returned
        ///     if `syncEmergencyAddress` parameter is set to `true`
        ///     Enum: Verified, Updated, Deleted, ActivationProcess, NotRequired, Unsupported, Failed
        /// </summary>
        public string syncStatus { get; set; }

        /// <summary>
        ///     Enum: LocationWithElins, LocationWithEndpoint
        /// </summary>
        public string addressType { get; set; }

        /// <summary>
        ///     Visibility of an emergency response location. If `Private`
        ///     is set, then location is visible only for the restricted number of users,
        ///     specified in `owners` array
        ///     Default: Public
        ///     Enum: Private, Public
        /// </summary>
        public string visibility { get; set; }

        /// <summary>
        ///     List of private location owners
        /// </summary>
        public LocationOwnerInfo[] owners { get; set; }

        /// <summary>
        ///     Address format ID
        /// </summary>
        public string addressFormatId { get; set; }

        /// <summary>
        ///     If 'true' address validation for non-us addresses is skipped
        /// </summary>
        public bool? trusted { get; set; }
    }
}