namespace RingCentral
{
    public class GetMessageSyncResponse
    {
        /// <summary>
        /// Link to the message sync resource
        /// </summary>
        public string uri;

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