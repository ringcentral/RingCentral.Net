namespace RingCentral
{
    public class CallQueueInfo
    {
        /// <summary>
        /// Link to a call queue
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Internal identifier of a call queue
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Extension number of a call queue
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// Name of a call queue
        /// </summary>
        public string name { get; set; }
    }
}