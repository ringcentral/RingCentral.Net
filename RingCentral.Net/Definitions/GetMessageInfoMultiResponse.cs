namespace RingCentral
{
    public class GetMessageInfoMultiResponse
    {
        /* Internal identifier of a resource */
        public string resourceId;

        /* Status code of resource retrieval */
        public long? status;

        public MessageBody body;
    }
}