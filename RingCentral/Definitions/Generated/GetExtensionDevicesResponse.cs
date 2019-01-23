using Newtonsoft.Json;

namespace RingCentral
{
    public class GetExtensionDevicesResponse : Serializable
    {
        // List of extension devices
        public GetDeviceInfoResponse[] records; // Required
        // Information on navigation
        public NavigationInfo navigation; // Required
        // Information on paging
        public PagingInfo paging; // Required
    }
}