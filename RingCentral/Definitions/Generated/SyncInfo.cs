using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class SyncInfo : Serializable
    {
        // Enum: FSync, ISync
        public string syncType;
        public string syncToken;
        public string syncTime;
        public bool? olderRecordsExist;
    }
}