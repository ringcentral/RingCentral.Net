namespace RingCentral
{
    public class UpdateNetworkRequest
    {
        /// <summary>
        /// </summary>
        public string name;

        /// <summary>
        /// </summary>
        public string site;

        /// <summary>
        /// </summary>
        public PublicIpRangeInfo[] publicIpRanges;

        /// <summary>
        /// </summary>
        public PrivateIpRangeInfo[] privateIpRanges;
    }
}