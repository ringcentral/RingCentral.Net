using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class SyncInfo : Serializable
    {
        public string syncType;
        public string syncToken;
        public string syncTime;
        public bool? olderRecordsExist;
    }
}