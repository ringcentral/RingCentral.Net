using Newtonsoft.Json;

namespace RingCentral
{
    public class CallMonitoringExtensionUpdate : Serializable
    {
        // Only the following extension types are allowed: User, DigitalUser, VirtualUser, FaxUser, Limited
        public string id;
        public string[] permissions;
    }
}