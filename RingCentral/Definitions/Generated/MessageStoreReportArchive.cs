using Newtonsoft.Json;

namespace RingCentral
{
    public class MessageStoreReportArchive : Serializable
    {
        public ArchiveInfo[] records;
    }
}