using Newtonsoft.Json;

namespace RingCentral
{
    public class ExportTaskResultInfo : Serializable
    {
        // Size of the collected data archive in bytes
        public int? size;
        // Canonical URI for downloading an archive
        public string uri;
    }
}