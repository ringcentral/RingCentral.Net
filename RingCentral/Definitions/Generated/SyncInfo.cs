namespace RingCentral
{
    public class SyncInfo
    {
        // Enum: FSync, ISync
        public string syncType;
        public string syncToken;
        public string syncTime;
        public bool? olderRecordsExist;
    }
}