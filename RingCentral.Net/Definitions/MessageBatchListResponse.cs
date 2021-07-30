namespace RingCentral
{
    public class MessageBatchListResponse
    {
        /// <summary>
        /// </summary>
        public MessageBatchInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PagingResource paging { get; set; }
    }
}