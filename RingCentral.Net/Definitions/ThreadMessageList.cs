namespace RingCentral
{
    public class ThreadMessageList
    {
        /// <summary>
        ///     Required
        /// </summary>
        public ThreadMessageModel[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}