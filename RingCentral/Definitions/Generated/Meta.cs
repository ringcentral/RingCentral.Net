using Newtonsoft.Json;

namespace RingCentral
{
    // resource metadata
    public class Meta : Serializable
    {
        public string created;
        public string lastModified;
        // resource location URI
        public string location;
        // Enum: User, Group
        public string resourceType;
    }
}