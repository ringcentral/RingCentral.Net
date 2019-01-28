namespace RingCentral
{
    public class GetExtensionDevicesResponse
    {
        // List of extension devices
        public GetDeviceInfoResponse[] records; // Required

        // Information on navigation
        public NavigationInfo navigation; // Required

        // Information on paging
        public PagingInfo paging; // Required
    }
}