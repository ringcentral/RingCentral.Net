using Newtonsoft.Json;

namespace RingCentral
{
    public class ExtensionInfoGrants : Serializable
    {
        // Internal identifier of an extension
        public string id;
        // Canonical URI of an extension
        public string uri;
        // Extension short number (usually 3 or 4 digits)
        public string extensionNumber;
        // Extension type
        public string type;
    }
}