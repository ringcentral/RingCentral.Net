using Newtonsoft.Json;

namespace RingCentral
{
    public class ArchiveInfo : Serializable
    {
        // Archive size in bytes
        public long? size;
        // Link for archive download
        public string uri;
    }
}