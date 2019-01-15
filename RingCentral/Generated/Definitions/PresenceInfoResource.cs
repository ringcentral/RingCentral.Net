using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class PresenceInfoResource : Serializable
    {
        public string userStatus;
        public string dndStatus;
        public string message;
        public bool? allowSeeMyPresence;
        public bool? ringOnMonitoredCall;
        public bool? pickUpCallsOnHold;
        public ActiveCallInfo[] activeCalls;
    }
}