namespace RingCentral
{
    // List of messages retrieved for an account and other filter criteria such as `batchId` and `fromPhoneNumber` specified in the request
    public class MessageListResponse
    {
        /// <summary>
        /// An array containing individual messages
        /// </summary>
        public MessageListMessageResponse[] records { get; set; }

        /// <summary>
        /// </summary>
        public PagingResource paging { get; set; }
    }
}