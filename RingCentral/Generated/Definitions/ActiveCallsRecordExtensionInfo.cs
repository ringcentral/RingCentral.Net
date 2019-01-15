using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ActiveCallsRecordExtensionInfo : Serializable
    {
        // Link to an extension on whose behalf a call is initiated
        public string uri;
        // Internal identifier of an extension on whose behalf a call is initiated
        public string id;
    }
}