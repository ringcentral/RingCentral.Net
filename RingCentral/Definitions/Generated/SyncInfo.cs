using Newtonsoft.Json;

namespace RingCentral
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