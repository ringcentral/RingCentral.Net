using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class Meta : Serializable
    {
        public string created;
        public string lastModified;
        // resource location URI
        public string location;
        public string resourceType;
    }
}