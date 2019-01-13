using Newtonsoft.Json;

namespace RingCentral
{
    public class ReferenceInfo : Serializable
    {
        // Non-RC identifier of an extension
        public string @ref;
        // Type of external identifier
        public string type;
    }
}