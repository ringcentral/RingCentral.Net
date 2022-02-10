namespace RingCentral
{
    /// <summary>
    ///     Information on navigation
    /// </summary>
    public class ProvisioningNavigationInfo
    {
        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfoUri firstPage { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfoUri nextPage { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfoUri previousPage { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfoUri lastPage { get; set; }
    }
}