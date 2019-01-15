using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ReferenceInfo : Serializable
    {
        // Non-RC identifier of an extension
        public string @ref;
        // Type of external identifier
        // Enum: PartnerId, CustomerDirectoryId
        public string type;
    }
}