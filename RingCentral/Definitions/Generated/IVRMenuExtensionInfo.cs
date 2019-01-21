using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class IVRMenuExtensionInfo : Serializable
    {
        // Link to an extension resource
        public string uri;
        // Internal identifier of an extension
        public string id;
    }
}