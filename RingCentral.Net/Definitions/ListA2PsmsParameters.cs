namespace RingCentral
{
    public class ListA2PsmsParameters
    {
        /// <summary>
        /// Internal identifier of a message batch used for filtering records
        /// </summary>
        public string batchId;

        /// <summary>
        /// Token of a page to be retrieved
        /// </summary>
        public string pageToken;

        /// <summary>
        /// Number of messages to be returned per request
        /// Default: 1000
        /// </summary>
        public long? perPage;
    }
}