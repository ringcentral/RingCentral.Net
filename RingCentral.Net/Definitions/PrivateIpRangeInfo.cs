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
        ///     Emergency address information (or information assigned to the switch or
        ///     wireless point - in case of using them). Only one of a pair `emergencyAddress`
        ///     or `emergencyLocationId` should be specified, otherwise an error is returned
        /// </summary>
        public PrivateIpRangeInfoEmergencyAddress emergencyAddress { get; set; }

        /// <summary>
        ///     Emergency response location (address) internal identifier.
        ///     Only one of a pair `emergencyAddress` or `emergencyLocationId` should
        ///     be specified, otherwise an error is returned
        /// </summary>
        public string emergencyLocationId { get; set; }

        /// <summary>
        /// </summary>
        public bool? matched { get; set; }
    }
}