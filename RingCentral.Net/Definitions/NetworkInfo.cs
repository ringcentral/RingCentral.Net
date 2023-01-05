namespace RingCentral
{
    public class NetworkInfo
    {
        /// <summary>
        ///     Internal identifier of a network
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to a network resource
        ///     Format: uri
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
        public PrivateIpRangeInfo[] privateIpRanges { get; set; }

        /// <summary>
        /// </summary>
        public ERLLocationInfo emergencyLocation { get; set; }
    }
}