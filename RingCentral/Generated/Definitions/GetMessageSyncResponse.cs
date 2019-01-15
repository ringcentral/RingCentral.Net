using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GetMessageSyncResponse : Serializable
    {
        // List of message records with synchronization information
        public GetMessageInfoResponse[] records;
        // Sync type, token and time
        public SyncInfoMessages syncInfo;
    }
}