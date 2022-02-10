namespace RingCentral
{
    /// <summary>
    ///     Information on navigation
    /// </summary>
    public class DeviceProvisioningNavigationInfo
    {
        /// <summary>
        /// </summary>
        public DeviceProvisioningNavigationInfoUri firstPage { get; set; }

        /// <summary>
        /// </summary>
        public DeviceProvisioningNavigationInfoUri nextPage { get; set; }

        /// <summary>
        /// </summary>
        public DeviceProvisioningNavigationInfoUri previousPage { get; set; }

        /// <summary>
        /// </summary>
        public DeviceProvisioningNavigationInfoUri lastPage { get; set; }
    }
}