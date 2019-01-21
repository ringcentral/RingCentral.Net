using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ExtensionCallerIdInfo : Serializable
    {
        // Canonical URL of a caller ID resource
        public string uri;
        public CallerIdByDevice[] byDevice;
        public CallerIdByFeature[] byFeature;
        // If 'True', then user first name and last name will be used as caller ID when making outbound calls from extension
        public bool? extensionNameForOutboundCalls;
        // If 'True', then extension number will be used as caller ID when making internal calls
        public bool? extensionNumberForInternalCalls;
    }
}