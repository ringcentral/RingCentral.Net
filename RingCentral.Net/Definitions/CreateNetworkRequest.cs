namespace RingCentral
{
    public class CreateNetworkRequest
    {
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
        public PrivateIpRangeInfoRequest[] privateIpRanges;

        /// <summary>
        /// </summary>
        public ERLLocationInfo emergencyLocation;
    }
}