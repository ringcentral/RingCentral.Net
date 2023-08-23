namespace RingCentral
{
    /// <summary>
    ///     Company emergency response location details
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
        ///     Address format id
        /// </summary>
        public string addressFormatId { get; set; }
    }
}