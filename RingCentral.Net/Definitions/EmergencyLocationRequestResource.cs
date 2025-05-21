namespace RingCentral
{
    public class EmergencyLocationRequestResource
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
        public SiteBasicInfo site { get; set; }

        /// <summary>
        ///     Emergency address status
        ///     Enum: Valid, Invalid
        /// </summary>
        public string addressStatus { get; set; }

        /// <summary>
        ///     Status of an emergency response location usage.
        ///     Enum: Active, Inactive
        /// </summary>
        public string usageStatus { get; set; }

        /// <summary>
        ///     Address format ID
        /// </summary>
        public string addressFormatId { get; set; }

        /// <summary>
        ///     Visibility of an emergency response location. If `Private`
        ///     is set, then a location is visible only for restricted number of users,
        ///     specified in `owners` array
        ///     Default: Public
        ///     Enum: Public
        /// </summary>
        public string visibility { get; set; }

        /// <summary>
        ///     Specifies emergency address validation during the ERL creation/update.
        ///     If set to 'true', then address validation for non-US addresses is skipped
        /// </summary>
        public bool? trusted { get; set; }
    }
}