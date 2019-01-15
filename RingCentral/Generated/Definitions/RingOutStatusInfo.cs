using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class RingOutStatusInfo : Serializable
    {
        // Status of a call
        public string callStatus;
        // Status of a calling party
        public string callerStatus;
        // Status of a called party
        public string calleeStatus;
    }
}