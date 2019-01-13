using Newtonsoft.Json;

namespace RingCentral
{
    public class SyncInfo : Serializable
    {
        public string syncType;
        public string syncToken;
        public string syncTime;
        public bool? olderRecordsExist;
    }
}