namespace RingCentral
{
    public class UpdateNetworkRequest
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
    }
}