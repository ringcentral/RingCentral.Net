namespace RingCentral
{
    public class UpdateNetworkRequest
    {
        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public PublicIpRangeInfo[] publicIpRanges { get; set; }

        /// <summary>
        /// </summary>
        public PrivateIpRangeInfoRequest[] privateIpRanges { get; set; }

        /// <summary>
        /// </summary>
        public ERLLocationInfo emergencyLocation { get; set; }
    }
}