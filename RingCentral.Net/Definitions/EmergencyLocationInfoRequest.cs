namespace RingCentral
{
    public class EmergencyLocationInfoRequest
    {
        /// <summary>
        /// Internal identifier of the emergency response location
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyLocationAddressInfo address { get; set; }

        /// <summary>
        /// Emergency response location name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public ShortSiteInfo site { get; set; }

        /// <summary>
        /// Emergency address status
        /// Enum: Valid, Invalid
        /// </summary>
        public string addressStatus { get; set; }

        /// <summary>
        /// Status of emergency response location usage.
        /// Enum: Active, Inactive
        /// </summary>
        public string usageStatus { get; set; }

        /// <summary>
        /// Visibility of an emergency response location. If `Private` is set, then location is visible only for restricted number of users, specified in `owners` array
        /// Default: Public
        /// Enum: Private, Public
        /// </summary>
        public string visibility { get; set; }

        /// <summary>
        /// List of private location owners
        /// </summary>
        public LocationOwnerInfo[] owners { get; set; }
    }
}