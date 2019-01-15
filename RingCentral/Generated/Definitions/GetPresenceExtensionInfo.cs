using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GetPresenceExtensionInfo : Serializable
    {
        // Internal identifier of an extension
        public string id;
        // Canonical URI of an extension
        public string uri;
        // Extension number (usually 3 or 4 digits)
        public string extensionNumber;
    }
}