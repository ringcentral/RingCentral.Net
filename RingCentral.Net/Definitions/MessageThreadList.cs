namespace RingCentral
{
    public class MessageThreadList
    {
        /// <summary>
        ///     Required
        /// </summary>
        public MessageThread[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}