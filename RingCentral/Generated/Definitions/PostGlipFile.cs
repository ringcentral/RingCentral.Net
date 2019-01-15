using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class PostGlipFile : Serializable
    {
        // Internal identifier of a file
        public string id;
        // Link to binary content
        public string contentUri;
        // Name of a file
        public string name;
    }
}