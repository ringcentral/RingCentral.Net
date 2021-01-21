namespace RingCentral
{
    public class NetworksList
    {
        /// <summary>
        /// Link to a networks resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public NetworkInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}