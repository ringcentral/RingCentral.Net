namespace RingCentral
{
    /// <summary>
    /// Company emergency response location details
    /// </summary>
    public class SipRegistrationDeviceLocationInfo
    {
        /// <summary>
        ///     Internal identifier of an emergency response location
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Emergency response location name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Address format ID
        /// </summary>
        public string addressFormatId { get; set; }

        /// <summary>
        ///     Address format statuses
        ///     Enum: Actual, Outdated, Deprecated
        /// </summary>
        public string addressFormatStatus { get; set; }

        /// <summary>
        ///     Specifies emergency address validation during the ERL creation/update.
        ///     If set to 'true', then address validation for non-US addresses is skipped
        /// </summary>
        public bool? trusted { get; set; }
    }
}