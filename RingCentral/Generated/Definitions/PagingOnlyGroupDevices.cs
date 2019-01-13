using Newtonsoft.Json;

namespace RingCentral
{
    public class PagingOnlyGroupDevices : Serializable
    {
        // List of paging devices assigned to this group
        public PagingDeviceInfo[] records;
        // Information on navigation
        public NavigationInfo navigation;
        // Information on paging
        public PagingInfo paging;
    }
}