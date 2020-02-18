namespace RingCentral
{
    public class SwitchesList
    {
        /// <summary>
        /// Link to the switches list resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Switches map
        /// </summary>
        public SwitchInfo[] records;

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}