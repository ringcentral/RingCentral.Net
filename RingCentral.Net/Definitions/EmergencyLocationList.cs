namespace RingCentral
{
    public class EmergencyLocationList
    {
        /// <summary>
        ///     Link to the emergency location list resource
        /// </summary>
        public string uri { get; set; }

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