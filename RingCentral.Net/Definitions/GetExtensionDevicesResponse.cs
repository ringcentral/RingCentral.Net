namespace RingCentral
{
    public class GetExtensionDevicesResponse
    {
        /* List of extension devices */
        public GetDeviceInfoResponse[] records; // Required

        /* Information on navigation */
        public DeviceProvisioningNavigationInfo navigation; // Required

        /* Information on paging */
        public DeviceProvisioningPagingInfo paging; // Required
    }
}