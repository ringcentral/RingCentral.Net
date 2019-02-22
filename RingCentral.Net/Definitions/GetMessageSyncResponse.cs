namespace RingCentral
{
    public class GetMessageSyncResponse
    {
        // List of message records with synchronization information
        public GetMessageInfoResponse[] records; // Required

        // Sync type, token and time
        public SyncInfoMessages syncInfo; // Required
    }
}