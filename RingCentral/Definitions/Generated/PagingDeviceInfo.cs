using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class PagingDeviceInfo : Serializable
    {
        // Internal identifier of a paging device
        public string id;
        // Link to a paging device resource
        public string uri;
        // Name of a paging device
        public string name;
    }
}