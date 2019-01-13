using Newtonsoft.Json;

namespace RingCentral
{
    public class GetExtensionDevicesResponse : Serializable
    {
        // List of extension devices
        public GetDeviceInfoResponse[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}