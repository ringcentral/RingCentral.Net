using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ArchiveInfo : Serializable
    {
        // Archive size in bytes
        public long? size;
        // Link for archive download
        public string uri;
    }
}