using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class RecipientInfo : Serializable
    {
        // Link to a recipient extension resource
        public string uri;
        // Internal identifier of a recipient extension
        public string id;
    }
}