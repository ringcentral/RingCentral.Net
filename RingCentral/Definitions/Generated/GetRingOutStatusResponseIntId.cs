using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GetRingOutStatusResponseIntId : Serializable
    {
        // Internal identifier of a RingOut call
        public long? id;
        public string uri;
        // RingOut status information
        public RingOutStatusInfo status;
    }
}