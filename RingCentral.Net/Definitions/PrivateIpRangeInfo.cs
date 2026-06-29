namespace RingCentral
{
    public class PrivateIpRangeInfo
    {
        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string startIp { get; set; }

        /// <summary>
        /// </summary>
        public string endIp { get; set; }

        /// <summary>
        ///     Network name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyLocationAddressResource emergencyAddress { get; set; }

        /// <summary>
        /// </summary>
        public bool? matched { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyLocationInfo emergencyLocation { get; set; }
    }
}