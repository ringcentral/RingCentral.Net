namespace RingCentral
{
    public class SwitchesList
    {
        /// <summary>
        ///     Switches map
        /// </summary>
        public SwitchInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}