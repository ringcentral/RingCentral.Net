using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class EmergencyAddress : Serializable
    {
        // 'True' if specifying of emergency address is required
        public bool? required;
        // 'True' if only local emergency address can be specified
        public bool? localOnly;
    }
}