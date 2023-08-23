namespace RingCentral
{
    /// <summary>
    ///     Emergency response location information
    /// </summary>
    public class EmergencyLocationInfo
    {
        /// <summary>
        ///     Internal identifier of an emergency response location
        ///     Required
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