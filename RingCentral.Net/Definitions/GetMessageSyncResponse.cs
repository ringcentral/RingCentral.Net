namespace RingCentral
{
    public class GetMessageSyncResponse
    {
        /// <summary>
        ///     Link to the message sync resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of message records with synchronization information
        ///     Required
        /// </summary>
        public GetMessageInfoResponse[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public SyncInfoMessages syncInfo { get; set; }
    }
}