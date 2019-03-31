namespace RingCentral
{
    public class GetExtensionDevicesResponse
    {
        /// <summary>
        /// List of extension devices
        /// Required
        /// </summary>
        public GetDeviceInfoResponse[] records;

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