namespace RingCentral
{
    public class GetExtensionDevicesResponse
    {
        /// <summary>
        /// Link to the list of extension devices
        /// </summary>
        public string uri;

        /// <summary>
        /// List of extension devices
        /// Required
        /// </summary>
        public ExtensionDeviceResponse[] records;

        /// <summary>
        /// Information on navigation
        /// Required
        /// </summary>
        public DeviceProvisioningNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// Required
        /// </summary>
        public DeviceProvisioningPagingInfo paging;
    }
}