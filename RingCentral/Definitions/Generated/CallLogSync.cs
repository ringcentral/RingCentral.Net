using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallLogSync : Serializable
    {
        // List of call log records with synchronization information. For ISync the total number of returned records is limited to 250; this includes both new records and the old ones, specified by the recordCount parameter
        public CallLogRecord[] records;
        // Sync information (type, token and time)
        public SyncInfoCallLog syncInfo;
    }
}