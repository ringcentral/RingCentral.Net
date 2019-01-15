using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallLogRecordDeviceInfo : Serializable
    {
        // Internal identifier of a device
        public string id;
        // string to a device
        public string uri;
    }
}