namespace RingCentral
{
    public class GetExtensionDevicesResponse
    {
        /// <summary>
        /// Link to the list of extension devices
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// List of extension devices
        /// Required
        /// </summary>
        public ExtensionDeviceResponse[] records { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public DeviceProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public DeviceProvisioningPagingInfo paging { get; set; }
    }
}