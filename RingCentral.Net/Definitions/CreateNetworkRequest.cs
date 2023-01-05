namespace RingCentral
{
    public class CreateNetworkRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public PublicIpRangeInfo[] publicIpRanges { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public PrivateIpRangeInfoRequest[] privateIpRanges { get; set; }

        /// <summary>
        /// </summary>
        public ERLLocationInfo emergencyLocation { get; set; }
    }
}