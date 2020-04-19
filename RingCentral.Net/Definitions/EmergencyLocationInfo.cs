namespace RingCentral
{
    public class EmergencyLocationInfo
    {
        /// <summary>
        /// Internal identifier of the emergency response location
        /// </summary>
        public string id;

        /// <summary>
        /// </summary>
        public EmergencyLocationAddressInfo address;

        /// <summary>
        /// Emergency response location name
        /// </summary>
        public string name;

        /// <summary>
        /// </summary>
        public ShortSiteInfo site;

        /// <summary>
        /// Emergency address status
        /// Enum: Valid, Invalid
        /// </summary>
        public string addressStatus;

        /// <summary>
        /// Status of emergency response location usage.
        /// Enum: Active, Inactive
        /// </summary>
        public string usageStatus;

        /// <summary>
        /// Visibility of an emergency response location. If `Private` is set, then location is visible only for restricted number of users, specified in `owners` array
        /// Default: Public
        /// Enum: Private, Public
        /// </summary>
        public string visibility;
    }
}