namespace RingCentral
{
    public class GetMessageInfoMultiResponse
    {
        /// <summary>
        /// Internal identifier of a resource
        /// </summary>
        public string resourceId;

        /// <summary>
        /// Status code of resource retrieval
        /// </summary>
        public long? status;

        /// <summary>
        /// </summary>
        public MessageBody body;
    }
}