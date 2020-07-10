namespace RingCentral
{
    public class NetworkInfo
    {
        /// <summary>
        /// Internal identifier of a network
        /// </summary>
        public string id;

        /// <summary>
        /// Link to a network resource
        /// </summary>
        public string uri;

        /// <summary>
        /// </summary>
        public string name;

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site;

        /// <summary>
        /// </summary>
        public PublicIpRangeInfo[] publicIpRanges;

        /// <summary>
        /// </summary>
        public PrivateIpRangeInfo[] privateIpRanges;

        /// <summary>
        /// Emergency response location information
        /// </summary>
        public ERLLocationInfo emergencyLocation;
    }
}