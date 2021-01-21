namespace RingCentral
{
    public class AutomaticLocationUpdatesUserList
    {
        /// <summary>
        /// Link to the users list resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesUserInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}