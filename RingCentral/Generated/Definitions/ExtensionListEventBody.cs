using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ExtensionListEventBody : Serializable
    {
        // Internal identifier of an extension
        public string extensionId;
        // Type of extension info change
        public string eventType;
        // Internal identifier of a subscription owner extension
        public string ownerId;
    }
}