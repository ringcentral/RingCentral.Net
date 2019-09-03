namespace RingCentral
{
    public class PrivateIpRangeInfo
    {
        /// <summary>
        /// </summary>
        public string id;

        /// <summary>
        /// </summary>
        public string startIp;

        /// <summary>
        /// </summary>
        public string endIp;

        /// <summary>
        /// Network name
        /// </summary>
        public string name;

        /// <summary>
        /// Emergency address information. Only one of a pair `emergencyAddress` or `emergencyLocationId` should be specified, otherwise the error is returned
        /// </summary>
        public LocationUpdatesEmergencyAddressInfo emergencyAddress;

        /// <summary>
        /// Emergency response location (address) internal identifier. Only one of a pair `emergencyAddress` or `emergencyLocationId` should be specified, otherwise the error is returned
        /// </summary>
        public string emergencyLocationId;
    }
}