namespace RingCentral
{
    public class UpdateNetworkRequest
    {
        /// <summary>
        ///     Internal identifier of a network
        ///     Example: 2874044
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string uri { get; set; }

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