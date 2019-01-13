using Newtonsoft.Json;

namespace RingCentral
{
    public class ArchiveInfo : Serializable
    {
        // Archive size in bytes
        public int? size;
        // Link for archive download
        public string uri;
    }
}