using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ExtensionStatusInfo : Serializable
    {
        // A free-form user comment, describing the status change reason
        public string comment;
        // Type of suspension
        public string reason;
    }
}