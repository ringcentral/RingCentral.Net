namespace RingCentral
{
    public class GetMessageSyncResponse
    {
        /// <summary>
        /// List of message records with synchronization information
        /// Required
        /// </summary>
        public GetMessageInfoResponse[] records;

        /// <summary>
        /// Sync type, token and time
        /// Required
        /// </summary>
        public SyncInfoMessages syncInfo;
    }
}