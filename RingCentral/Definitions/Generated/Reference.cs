using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class Reference : Serializable
    {
        // Enum: PartnerId, CustomerDirectoryId
        public string type;
        public string @ref;
    }
}