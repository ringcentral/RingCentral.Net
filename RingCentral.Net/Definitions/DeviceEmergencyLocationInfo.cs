namespace RingCentral
{
    /// <summary>
    ///     Company emergency response location details
    /// </summary>
    public class DeviceEmergencyLocationInfo
    {
        /// <summary>
        ///     Internal identifier of the emergency response location
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Location name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Address format ID
        /// </summary>
        public string addressFormatId { get; set; }
    }
}