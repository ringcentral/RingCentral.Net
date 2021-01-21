namespace RingCentral
{
    public class GetMessageInfoMultiResponse
    {
        /// <summary>
        /// Internal identifier of a resource
        /// </summary>
        public string resourceId { get; set; }

        /// <summary>
        /// Status code of resource retrieval
        /// </summary>
        public long? status { get; set; }

        /// <summary>
        /// </summary>
        public MessageBody body { get; set; }
    }
}