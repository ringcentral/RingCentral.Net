namespace RingCentral
{
    public class EmergencyLocationList
    {
        /// <summary>
        /// </summary>
        public EmergencyLocationInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}