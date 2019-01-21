using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class SyncInfoCallLog : Serializable
    {
        // Type of synchronization
        // Enum: FSync, ISync
        public string syncType;
        // Synchronization token
        public string syncToken;
        // The last synchronization datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string syncTime;
    }
}